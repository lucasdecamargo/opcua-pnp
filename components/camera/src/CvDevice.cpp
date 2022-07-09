#include <CvDevice.h>

#include <opencv2/imgcodecs.hpp>
#include <opencv2/imgproc/imgproc.hpp>

#include <open62541/types_generated_handling.h>

CvDevice::CvDevice(const std::string &filename, int apiPreference)
    : filename(filename), apiPreference(apiPreference), index(-1)
{

}

CvDevice::CvDevice(int index, int apiPreference)
    : apiPreference(apiPreference), index(index)
{

}

CvDevice::~CvDevice()
{

}

bool CvDevice::retrieve(UA_ImagePNG *image, int flag)
{
    if(image == NULL) return false;
    if(!isOpened()) return false;

    cv::Mat cv_out;
    if(!this->cv::VideoCapture::retrieve(cv_out, flag))
        return false;

    std::vector<UA_Byte> vec;
    cv::imencode(".PNG", cv_out, vec);

    image->length = vec.size();
    image->data = (UA_Byte*)UA_malloc(image->length * sizeof(UA_Byte));
    std::copy(vec.begin(), vec.end(), image->data);

    return true;
}

bool CvDevice::read(UA_ImagePNG *image)
{
    if(grab())
        return retrieve(image);
    else return false;
}

bool CvDevice::open()
{
    if(index != -1) return this->cv::VideoCapture::open(index, apiPreference);
    else return this->cv::VideoCapture::open(filename, apiPreference);
}

double CvDevice::get(int propId) const
{
    return this->cv::VideoCapture::get(propId);
}

bool CvDevice::set(int propId, double value)
{
    return this->cv::VideoCapture::set(propId, value);
}
