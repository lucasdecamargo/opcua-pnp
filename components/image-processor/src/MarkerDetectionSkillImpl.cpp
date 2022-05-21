#include <MarkerDetectionSkillImpl.h>

#include <types_pnp_types_generated.h>
#include <types_pnp_types_generated_handling.h>

#include <aruco/aruco.h>
#include <opencv2/core.hpp>
#include <opencv2/imgproc.hpp>
#include <opencv2/imgcodecs.hpp>

#include <fstream>
#include <sstream>


cv::Mat __resize(const cv::Mat& in, int height)
{
    if (in.size().height <= height)
        return in;
    float yf = float(height) / float(in.size().height);
    cv::Mat im2;
    cv::resize(in, im2, cv::Size(), yf, yf);
    return im2;
}

aruco::CameraParameters _camera_parameters_create(const double* dist_coeff, const double* cam_matrix, const cv::Mat img)
{
    cv::Mat dist = cv::Mat_<double>(4,1);
    std::memcpy(dist.data, dist_coeff, 4*sizeof(double));

    cv::Mat matrix = cv::Mat_<double>(3,3);
    std::memcpy(matrix.data, cam_matrix, 9 * sizeof(double));

    return aruco::CameraParameters(matrix, dist, cv::Size(img.cols, img.rows));
}

std::map<int, double> _markers_file_parse(const std::string file_path)
{
    std::map<int, double> ret;

    std::fstream fin;
    fin.open(file_path, std::ios::in);

    std::vector<std::string> row;
    std::string line, word, temp;

    if(!fin.is_open()) 
        throw std::ifstream::failure("Could not open file " + file_path);
    
    while(std::getline(fin,line))
    {
        row.clear();
        std::stringstream s(line);

        while(std::getline(s, word, ','))
        {
            row.push_back(word);
        }

        ret[std::stoi(row[0])] = std::stod(row[1]);
    }

    return ret;
}

cv::Mat _imgdecode(const UA_ByteString &img)
{
    return cv::imdecode(cv::Mat(1, img.length, CV_8UC1, img.data), cv::IMREAD_UNCHANGED);
}

MarkerDetectionSkillImpl::MarkerDetectionSkillImpl(
    const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
    const std::shared_ptr<spdlog::logger>& logger,
    const libconfig::Setting& imageProcessorSettings,
    const std::string& markersFilePath
)
  : pnp::opcua::skill::image_processor::MarkerDetectionSkillImpl(),
    server(server), logger(logger), imageProcessorSettings(imageProcessorSettings),
    markersFilePath(markersFilePath)
{
    // ...
}

bool MarkerDetectionSkillImpl::start(
    const UA_CameraInfoDataType& cameraInfo,
    const UA_ByteString& inputImage,
    std::vector<UA_MarkerDataType>& detectedMarkers,
    UA_ImagePNG& outputImage)
{
    logger->trace("MarkerDetectionSkill called");

    std::thread t = std::thread([&]()
    {
        // Check if input image is valid
        if(inputImage.length <= 0 || inputImage.data == NULL)
        {
            logger->error("Input image is invalid");
            return this->detectionFinished();
        }
        
        cv::Mat cv_img;
        try
        {
            cv_img = _imgdecode(inputImage);
        }
        catch(const std::exception& e)
        {
            logger->error("Could not decode input image");
            return this->detectionFinished();
        }

        if(cv_img.empty())
        {
            logger->error("Input image is empty");
            return this->detectionFinished();
        }

        aruco::MarkerDetector marker_detector;
        marker_detector.setDictionary(aruco::Dictionary::ARUCO);

        std::vector<aruco::Marker> markers = marker_detector.detect(cv_img);

        if(markers.empty())
            return this->detectionFinished();

        std::map<int, UA_MarkerDataType> outMarkers;
        for(auto &m: markers)
        {
            outMarkers[m.id].id = m.id;
            outMarkers[m.id].dictionary = UA_String_fromChars("ARUCO");
        }

        // Check markers size
        std::map<int, double> markers_size;
        try
        {
            markers_size = _markers_file_parse(markersFilePath);
        }
        catch(const std::exception& e)
        {
            for(auto &m: outMarkers)
                detectedMarkers.push_back(m.second);
            
            logger->error("Error while reading markers file: " + std::string(e.what()));
            return this->detectionFinished();
        } 

        for(auto &m: markers)
        {
            if(markers_size.find(m.id) != markers_size.end())
                outMarkers[m.id].size = markers_size[m.id];
        }

        // Check camera parameters
        if(cameraInfo.cameraMatrixSize != 9 || cameraInfo.distortionCoefficientsSize < 4)
        {
            for(auto &m: outMarkers)
                detectedMarkers.push_back(m.second);

            logger->warn("Camera info parameters wrong or not set");
            return this->detectionFinished();
        }

        std::map<int, aruco::MarkerPoseTracker> tracker;
        aruco::CameraParameters cam_params = _camera_parameters_create(
            cameraInfo.distortionCoefficients,
            cameraInfo.cameraMatrix,
            cv_img
        );

        for(auto &m: markers)
        {
            if(markers_size.find(m.id) != markers_size.end())
            {
                tracker[m.id].estimatePose(m, cam_params, markers_size[m.id], 
                    imageProcessorSettings.exists("err_ratio") ? imageProcessorSettings["err_ratio"] : 10);

                if(m.isPoseValid())
                {
                    logger->trace("Position valid for marker " + std::to_string(m.id));
                    outMarkers[m.id].position.x = m.Tvec.at<float>(0);
                    outMarkers[m.id].position.y = m.Tvec.at<float>(1);
                    outMarkers[m.id].position.z = m.Tvec.at<float>(2);

                    if(imageProcessorSettings.exists("draw_markers") ? (bool)imageProcessorSettings["draw_markers"] : true)
                    {
                        aruco::CvDrawingUtils::draw3dCube(cv_img, m, cam_params, 2);
                        aruco::CvDrawingUtils::draw3dAxis(cv_img, m, cam_params, 6);
                    }
                }
            }
        }

        for(auto &m: outMarkers)
            detectedMarkers.push_back(m.second);

        if(imageProcessorSettings.exists("output_image") ? (bool)imageProcessorSettings["output_image"] : true)
        {
            // Encode cv_img to PNG and output
            int resize_height = (imageProcessorSettings.exists("outputImage_resize_height") ? 
                                    (int)imageProcessorSettings["outputImage_resize_height"] : (int)0.0);
            
            if(resize_height > 0)
                cv_img = __resize(cv_img, resize_height);
            
            std::vector<UA_Byte> vec;
            cv::imencode(".PNG", cv_img, vec);

            outputImage.length = vec.size();
            outputImage.data = (UA_Byte*)UA_malloc(outputImage.length * sizeof(UA_Byte));
            std::copy(vec.begin(), vec.end(), outputImage.data);
        }

        this->detectionFinished();
    });

    t.detach();

    return true;
}

bool MarkerDetectionSkillImpl::halt()
{
    return false;
};

bool MarkerDetectionSkillImpl::resume()
{
    return false;
};

bool MarkerDetectionSkillImpl::suspend()
{
    return false;
};

bool MarkerDetectionSkillImpl::reset()
{
    return false;
};