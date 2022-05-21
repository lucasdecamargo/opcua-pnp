#include <CameraDevice.h>
#include <stdexcept>

CameraDevice::CameraDevice()
{
    
}

CameraDevice::~CameraDevice()
{

}

bool CameraDevice::grab()
{
    throw std::logic_error("Not implemented");
}

bool CameraDevice::read(BASE_IMAGE_TYPE *image)
{
    throw std::logic_error("Not implemented");
}

bool CameraDevice::open()
{
    throw std::logic_error("Not implemented");
}

void CameraDevice::release()
{
    throw std::logic_error("Not implemented");
}

bool CameraDevice::isOpened() const
{
    throw std::logic_error("Not implemented");
}

double CameraDevice::get(int propId) const
{
    throw std::logic_error("Not implemented");
}

bool CameraDevice::set(int propId, double value)
{
    throw std::logic_error("Not implemented");
}
