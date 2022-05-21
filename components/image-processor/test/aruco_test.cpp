#include <aruco/aruco.h>

#include <opencv2/core.hpp>
#include <opencv2/imgproc.hpp>
#include <opencv2/imgcodecs.hpp>
#include <opencv2/highgui.hpp>

#include <iostream>
#include <fstream>
#include <sstream>
#include <stdexcept>

// const double CAM_DIST_COEFF[] = {-0.0381569,0.00708741,-0.00403235,-5.8165e-05,-0.000416013};
// const double CAM_MATRIX[] = {1055.98,0      ,1079.39,
//                              0      ,1055.57,633.503,
//                              0      ,0      ,1      };

const double CAM_DIST_COEFF[] = {0,0,0,0,0};
const double CAM_MATRIX[] = {1000      ,0      ,1560,
                             0      ,1000     ,2080,
                             0      ,0      ,1      };

aruco::CameraParameters camParamsCreate(const double* dist_coeff, const double* cam_matrix, const cv::Mat img)
{
    cv::Mat dist = cv::Mat_<double>(4,1);
    std::memcpy(dist.data, dist_coeff, 4*sizeof(double));

    cv::Mat matrix = cv::Mat_<double>(3,3);
    std::memcpy(matrix.data, cam_matrix, 9 * sizeof(double));

    return aruco::CameraParameters(matrix, dist, cv::Size(img.cols, img.rows));
}

std::map<int, double> markers_file_parse(const std::string file_path)
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

cv::Mat __resize(const cv::Mat& in, int height)
{
    if (in.size().height <= height)
        return in;
    float yf = float(height) / float(in.size().height);
    cv::Mat im2;
    cv::resize(in, im2, cv::Size(), yf, yf);
    return im2;
}

int main()
{
    cv::Mat img = cv::imread(IMG_MARKERS);

    aruco::MarkerDetector marker_detector;
    marker_detector.setDictionary(aruco::Dictionary::ARUCO);

    std::vector<aruco::Marker> markers = marker_detector.detect(img);

    std::cout << "Detected Markers ID: ";
    for(auto &m : markers)
        std::cout << m.id << ", ";
    std::cout << std::endl;

    std::map<int, aruco::MarkerPoseTracker> tracker;

    aruco::CameraParameters cam_params = camParamsCreate(CAM_DIST_COEFF, CAM_MATRIX, img);
    std::map<int, double> markers_size = markers_file_parse(MARKERS_CSV);

    std::cout << "Img Size: " << cam_params.CamSize << std::endl;


    for(auto &m : markers)
    {
        tracker[m.id].estimatePose(m, cam_params, markers_size[m.id]);
        
        if(m.isPoseValid())
        {
            aruco::CvDrawingUtils::draw3dCube(img, m, cam_params, 2);
            aruco::CvDrawingUtils::draw3dAxis(img, m, cam_params, 6);
        }

        std::cout << "Marker[" << m.id << "] Pos.: " << m.Tvec << std::endl;
    }

    img = __resize(img, 800);
    cv::namedWindow("Frame", cv::WindowFlags::WINDOW_AUTOSIZE);
    cv::imshow("Frame", img);
    
    int key;
    do
    {
        key = cv::waitKey(10);
    } while (key != 'q' && key != 'Q');
    


    return 0;
}