#ifndef PNP_CVDEVICE_HPP
#define PNP_CVDEVICE_HPP

#include <CameraDevice.h>

#include <opencv2/core.hpp>
#include <opencv2/videoio.hpp>

class CvDevice : public CameraDevice, public cv::VideoCapture
{
public:
    using cv::VideoCapture::grab;
    using cv::VideoCapture::isOpened;
    using cv::VideoCapture::release;

    /**
     * Opens a video file or a capturing device or an IP video stream for video capturing with API Preference
     */ 
    CvDevice(const std::string &filename, int apiPreference=cv::CAP_ANY);
    /**
     * Opens a camera for video capturing
     */ 
    CvDevice(int index=0, int apiPreference=cv::CAP_ANY);

    virtual ~CvDevice();

    bool retrieve(UA_ImagePNG *image, int flag = 0) override;

    /**
     * Grabs, decodes and returns the next video frame. 
     * Creates Image Message
     */ 
    virtual bool read(UA_ImagePNG *image) override;

    /**
     * Opens the capture device
     */ 
    virtual bool open() override;

    /**
     * Returns the specified CameraDevice property
     */ 
    virtual double get(int propId) const override;
    // using cv::VideoCapture::get;
    /**
     * Sets a property in the CameraDevice property
     */ 
    virtual bool set(int propId, double value) override;
    // using cv::VideoCapture::set;

private:
    std::string filename;
    int apiPreference;
    int index;

    bool _retrieve_file_encoding(UA_ByteString &image, cv::Mat &m, int fmt);
    std::string _encStr();
};

#endif