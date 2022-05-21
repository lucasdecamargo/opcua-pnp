#include <PhotoSkillImpl.h>

#include <types_pnp_types_generated.h>
#include <types_pnp_types_generated_handling.h>

PhotoSkillImpl::PhotoSkillImpl(
    const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
    const std::shared_ptr<spdlog::logger>& logger,
    const std::shared_ptr<CameraDevice>& cameraDevice,
    UA_NodeId& outImageNodeId
)   
    : pnp::opcua::skill::camera::PhotoSkillImpl(),
        server(server),
        logger(logger),
        device(cameraDevice),
        outImageNodeId(outImageNodeId)
{
    // ...
}

bool PhotoSkillImpl::start()
{
    logger->info("Taking photo and savig it in ImagePNG variable.");

    std::thread t = std::thread([this]()
    {
        UA_ImagePNG image;
        UA_ImagePNG_init(&image);

        try
        {
            if(this->device->read(&image))
            {
                UA_Variant v;
                UA_Variant_init(&v);
                UA_Variant_setScalar(&v, &image, &UA_TYPES[UA_TYPES_IMAGEPNG]);

                LockedServer ls = this->server->getLocked();
                UA_StatusCode ret = UA_Server_writeValue(ls.get(), this->outImageNodeId, v);

                if(ret != UA_STATUSCODE_GOOD)
                {
                    logger->error("Could not set output image data. Err: {}", UA_StatusCode_name(ret));
                    this->photoErrored();
                }

                UA_ImagePNG_clear(&image);
            }

            else
            {
                logger->error("Could not read image.");
                this->photoErrored();
            }
        }
        catch(const std::exception& e)
        {
            logger->critical("When trying to take photo, raised exception: {}", e.what());
            this->photoErrored();
        }

        this->photoFinished();
    });

    t.detach();

    return true;
}

bool PhotoSkillImpl::halt()
{
    return false;
};

bool PhotoSkillImpl::resume()
{
    return false;
};

bool PhotoSkillImpl::suspend()
{
    return false;
};

bool PhotoSkillImpl::reset()
{
    return false;
};
