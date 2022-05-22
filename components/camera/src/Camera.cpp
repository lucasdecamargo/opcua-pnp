#include <Camera.h>

#include <open62541/client.h>
#include <open62541/client_highlevel.h>
#include <helper.hpp>

#include <namespace_di_generated.h>
#include <namespace_device_model_generated.h>
#include <namespace_pnp_types_generated.h>
#include <namespace_camera_generated.h>

#include <device_model_nodeids.h>
#include <di_nodeids.h>
#include <camera_nodeids.h>

#include <types_pnp_types_generated.h>
#include <types_pnp_types_generated_handling.h>

Camera::Camera(
    std::shared_ptr<spdlog::logger> _loggerApp,
    std::shared_ptr<spdlog::logger> _loggerOpcua,
    const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
    const libconfig::Setting& cameraSettings,
    std::shared_ptr<CameraDevice>& cameraDevice
) :
    cameraSettings(cameraSettings),
    device(cameraDevice),
    logger(std::move(_loggerApp)),
    loggerOpcua(std::move(_loggerOpcua)),
    server(server)
{
    if (!this->createNodesFromNodeset()) {
        throw std::runtime_error("Can not initialize Camera nodeset");
    }

    UA_StatusCode retval = initSkills();
    if (retval != UA_STATUSCODE_GOOD)
        throw pnp::opcua::StatusCodeException(retval);

    retval = setParameters();
    if(retval != UA_STATUSCODE_GOOD)
        throw pnp::opcua::StatusCodeException(retval);
}

Camera::~Camera()
{
    /* ... */
}

UA_StatusCode Camera::initSkills()
{
    UA_NodeId photoSkillId;
    UA_NodeId outImageNodeId;
    {
        LockedServer ls = server->getLocked();

        photoSkillId = UA_NODEID_NUMERIC
        (
            pnp::opcua::UA_Server_getNamespaceIdByName(ls.get(), NAMESPACE_URI_CAMERA),
                UA_CAMERAID_CAMERADEVICE_SKILLS_PHOTOSKILL
        );

        outImageNodeId = UA_NODEID_NUMERIC
        (
            pnp::opcua::UA_Server_getNamespaceIdByName(ls.get(), NAMESPACE_URI_CAMERA),
                UA_CAMERAID_CAMERADEVICE_IMAGEPNG
        );
    }

    photoSkillImpl = new PhotoSkillImpl(server, logger, device, outImageNodeId);

    photoSkill = std::make_unique<pnp::opcua::skill::camera::PhotoSkill>
                        (server, logger, photoSkillId, "PhotoSkill");
    
    photoSkill->setImpl(photoSkillImpl, [this](){ delete photoSkillImpl; });
    photoSkill->transition(pnp::opcua::ProgramStateNumber::READY);

    return UA_STATUSCODE_GOOD;
}

bool Camera::createNodesFromNodeset()
{
    LockedServer ls = server->getLocked();

    if(namespace_di_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the DI namespace failed. Please check previous error output.");
        return false;
    }

    if(namespace_device_model_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the DeviceModel namespace failed. Please check previous error output.");
        return false;
    }

    if(namespace_pnp_types_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the PnPTypes namespace failed. Please check previous error output.");
        return false;
    }

    if(namespace_camera_generated(ls.get()) != UA_STATUSCODE_GOOD)
    {
        logger->error("Adding the Camera namespace failed. Please check previous error output.");
        return false;
    }

    return true;
}

UA_StatusCode Camera::setParameters()
{
    UA_StatusCode ret_cam_info = UA_STATUSCODE_GOOD;
    UA_StatusCode ret_cam_pose = UA_STATUSCODE_GOOD;

    UA_Double dist_coeff[5] = {0,0,0,0,0};
    UA_Double cam_matrix[9] = {1,0,0,0,1,0,0,0,1};

    if(cameraSettings.exists("camera_info"))
    {
        logger->trace("Setting camera info");
        if(cameraSettings["camera_info"].exists("distortion_coefficients"))
        {
            const std::string keys[] = {{"k1"}, {"k2"}, {"p1"}, {"p2"}, {"k3"}};
            
            for(int i = 0; i < 5; i++)
                dist_coeff[i] = (cameraSettings["camera_info"]["distortion_coefficients"].exists(keys[i]) ?
                                 cameraSettings["camera_info"]["distortion_coefficients"].lookup(keys[i]) : 0.0);
        }

        if(cameraSettings["camera_info"].exists("camera_matrix"))
        {            
            

            cam_matrix[0] = (cameraSettings["camera_info"]["camera_matrix"].exists("fx") ?
                             cameraSettings["camera_info"]["camera_matrix"]["fx"] : 1.0);
            cam_matrix[2] = (cameraSettings["camera_info"]["camera_matrix"].exists("cx") ?
                             cameraSettings["camera_info"]["camera_matrix"]["cx"] : 0.0);
            cam_matrix[4] = (cameraSettings["camera_info"]["camera_matrix"].exists("fy") ?
                             cameraSettings["camera_info"]["camera_matrix"]["fy"] : 1.0);
            cam_matrix[5] = (cameraSettings["camera_info"]["camera_matrix"].exists("cy") ?
                             cameraSettings["camera_info"]["camera_matrix"]["cy"] : 0.0);
        }

        UA_CameraInfoDataType camera_info;
        camera_info.distortionCoefficientsSize = 5;
        camera_info.distortionCoefficients = dist_coeff;
        camera_info.cameraMatrixSize = 9;
        camera_info.cameraMatrix = cam_matrix;

        UA_Variant v;
        UA_Variant_init(&v);
        UA_Variant_setScalar(&v, &camera_info, &UA_TYPES_PNP_TYPES[UA_TYPES_PNP_TYPES_CAMERAINFODATATYPE]);

        LockedServer ls = server->getLocked();
        ret_cam_info = UA_Server_writeValue(ls.get(), 
                        UA_NODEID_NUMERIC(
                        pnp::opcua::UA_Server_getNamespaceIdByName(ls.get(), NAMESPACE_URI_CAMERA),
                        UA_CAMERAID_CAMERADEVICE_PARAMETERSET_CAMERAINFO),v);
        
        if(ret_cam_info != UA_STATUSCODE_GOOD)
        {
            logger->error("Failed setting camera info parameter. Returned: "
                            + std::string(UA_StatusCode_name(ret_cam_info)));
        }
    }

    if(cameraSettings.exists("camera_pose.position") && 
       cameraSettings.exists("camera_pose.pose"))
    {
        logger->trace("Setting camera pose");
        UA_PoseDataType pose;

        pose.position.x = cameraSettings["camera_pose"]["position"]["x"];
        pose.position.y = cameraSettings["camera_pose"]["position"]["y"];
        pose.position.z = cameraSettings["camera_pose"]["position"]["z"];
        pose.rotation.r = cameraSettings["camera_pose"]["rotation"]["r"];
        pose.rotation.p = cameraSettings["camera_pose"]["rotation"]["p"];
        pose.rotation.y = cameraSettings["camera_pose"]["rotation"]["y"];

        UA_Variant v;
        UA_Variant_init(&v);
        UA_Variant_setScalar(&v, &pose, &UA_TYPES_PNP_TYPES[UA_TYPES_PNP_TYPES_POSEDATATYPE]);

        LockedServer ls = server->getLocked();
        ret_cam_pose = UA_Server_writeValue(ls.get(), 
                        UA_NODEID_NUMERIC(
                        pnp::opcua::UA_Server_getNamespaceIdByName(ls.get(), NAMESPACE_URI_CAMERA),
                        UA_CAMERAID_CAMERADEVICE_PARAMETERSET_CAMERAPOSE),v);

        if(ret_cam_pose != UA_STATUSCODE_GOOD)
        {
            logger->error("Failed setting camera pose parameter. Returned: "
                            + std::string(UA_StatusCode_name(ret_cam_pose)));
        }
    }

    if(ret_cam_info != UA_STATUSCODE_GOOD && ret_cam_pose == UA_STATUSCODE_GOOD)
        return ret_cam_info;
    else if(ret_cam_pose != UA_STATUSCODE_GOOD && ret_cam_info == UA_STATUSCODE_GOOD)
        return ret_cam_pose;
    else if(ret_cam_pose != UA_STATUSCODE_GOOD && ret_cam_info != UA_STATUSCODE_GOOD)
        return UA_STATUSCODE_BADNOTWRITABLE;
    else
        return UA_STATUSCODE_GOOD;
}
