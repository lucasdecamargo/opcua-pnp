#include <ImageProcessor.h>

#include <CLI/CLI.hpp>
#include <libconfig.h++>

#include <spdlog/spdlog.h>
#include <logging.h>
#include <logging_opcua.h>
#include <helper.hpp>

#include <skills/image_processor/MarkerDetectionSkill.hpp>
#include <image_processor_nodeids.h>
#include <opencv2/core.hpp>
#include <opencv2/imgproc.hpp>
#include <opencv2/imgcodecs.hpp>

std::shared_ptr<spdlog::logger> logger;

bool running = true;

static void stopHandler(int)
{
    logger->warn("Received Ctrl-C. Shutting down...");
    logger->flush();
    running = false;
}

void set_input_parameters(
    const std::shared_ptr<pnp::opcua::OpcUaServer>& server,
    std::shared_ptr<spdlog::logger> logger)
{
    const UA_Double cam_dist_coeff[] = {0,0,0,0,0};
    const UA_Double cam_matrix[] = {1000      ,0      ,1560,
                                0      ,1000     ,2080,
                                0      ,0      ,1      };
    
    
    UA_ImagePNG image;
    cv::Mat cv_img = cv::imread(IMG_MARKERS);

    std::vector<UA_Byte> vec;
    cv::imencode(".PNG", cv_img, vec);
    image.length = vec.size();
    image.data = (UA_Byte*)UA_malloc(image.length * sizeof(UA_Byte));
    std::copy(vec.begin(), vec.end(), image.data);

    UA_Variant v_img;
    UA_Variant_init(&v_img);
    UA_Variant_setScalar(&v_img, &image, &UA_TYPES[UA_TYPES_IMAGEPNG]);

    {
        LockedServer ls = server->getLocked();
        UA_Server_writeValue(ls.get(), 
            UA_NODEID_NUMERIC(
                pnp::opcua::UA_Server_getNamespaceIdByName(ls.get(), NAMESPACE_URI_IMAGEPROCESSOR),
                UA_IMAGE_PROCESSORID_IMAGEPROCESSORDEVICE_SKILLS_MARKERDETECTIONSKILL_PARAMETERSET_INPUTIMAGE),v_img);
    }

    UA_ImagePNG_clear(&image);

    
    UA_CameraInfoDataType camparams;
    UA_CameraInfoDataType_init(&camparams);
    camparams.cameraMatrixSize = 9;
    camparams.cameraMatrix = (UA_Double*)UA_malloc(9 * sizeof(UA_Double));
    memcpy(&camparams.cameraMatrix[0], &cam_matrix[0], 9*sizeof(UA_Double));
    camparams.distortionCoefficientsSize = 5;
    camparams.distortionCoefficients = (UA_Double*)UA_malloc(5 * sizeof(UA_Double));
    memcpy(&camparams.distortionCoefficients[0], &cam_dist_coeff[0], 5*sizeof(UA_Double));
    
    UA_Variant v_camparams;
    UA_Variant_init(&v_camparams);

    UA_Variant_setScalar(&v_camparams, &camparams, &UA_TYPES_PNP_TYPES[UA_TYPES_PNP_TYPES_CAMERAINFODATATYPE]);

    {
        LockedServer ls = server->getLocked();
        UA_Server_writeValue(ls.get(), 
            UA_NODEID_NUMERIC(
                pnp::opcua::UA_Server_getNamespaceIdByName(ls.get(), NAMESPACE_URI_IMAGEPROCESSOR),
                UA_IMAGE_PROCESSORID_IMAGEPROCESSORDEVICE_SKILLS_MARKERDETECTIONSKILL_PARAMETERSET_CAMERAINFO),v_camparams);
    }

    UA_CameraInfoDataType_clear(&camparams);
}

int main(int argc, char* argv[])
{
    signal(SIGINT, stopHandler);
    signal(SIGTERM, stopHandler);

    CLI::App app{"Camera Server"};

    std::string configFile = "component.cfg";
    std::string certFiles;
    std::string clientCertFiles;
    std::string markersFile;
    app.add_option("--config", configFile, "Configuration file path");
    app.add_option("--certs-server", certFiles, "The server certificate files without extension");
    app.add_option("--certs-client", clientCertFiles, "The client certificate files without extension");
    app.add_option("--markers-file", markersFile, "Path to the CSV markers file containing their ID and size");

    CLI11_PARSE(app, argc, argv);

    libconfig::Config cfg;
    // Read the file. If there is an error, report it and exit.
    try {
        cfg.readFile(configFile.c_str());
    }
    catch (const libconfig::FileIOException& fioex) {
        std::cerr << "I/O error while reading configuration file." << fioex.what() << std::endl;
        return (EXIT_FAILURE);
    }
    catch (const libconfig::ParseException& pex) {
        std::cerr << "Configuration file parse error at " << pex.getFile() << ":" << pex.getLine()
                  << " - " << pex.getError() << std::endl;
        return (EXIT_FAILURE);
    }
    const libconfig::Setting& settings = cfg.getRoot();

    logger = pnp::log::LoggerFactory::createLogger("image-processor",
                                                       settings["logging"]["level"]["app"],
                                                       settings["logging"].exists("path") ? settings["logging"]["path"] : "");

    std::shared_ptr<pnp::opcua::OpcUaServer> uaServer;

    int exitCode = EXIT_SUCCESS;

    try 
    {
        if (clientCertFiles.empty()) {
            logger->error("Client certificates are required. Use --certs-client command line option.");
            return (EXIT_FAILURE);
        }

        if (settings["opcua"]["encryption"] && certFiles.empty()) {
            logger->error("Encryption is enabled but no certificates are given. Use --certs command line option.");
            return (EXIT_FAILURE);
        }

        logger->info("Starting ImageProcessor Server ...");

        uaServer = std::make_shared<pnp::opcua::OpcUaServer>(
                settings,
                logger,
                "pnp.component.imageprocessor",
                "Component - ImageProcessor",
                certFiles,
                "pnp.component.imageprocessor.client",
                "Component - ImageProcessor - Client",
                clientCertFiles);

        std::shared_ptr<spdlog::logger> loggerUa = logger->clone(logger->name() + "-ua");
        pnp::log::LoggerFactory::setLoggerLevel(loggerUa, settings["logging"]["level"]["opcua"]);


        std::shared_ptr<ImageProcessor> imageProcessor = std::make_shared<ImageProcessor>(
            logger, loggerUa, uaServer, settings["image_processor"], markersFile);
        
        set_input_parameters(uaServer,logger);

        if(uaServer->init(true, nullptr) == UA_STATUSCODE_GOOD)
        {
            while(running)
            {
                uaServer->iterate();
                std::this_thread::yield();
                std::this_thread::sleep_for(std::chrono::milliseconds(1));
            }
        }
    }
    catch (const libconfig::SettingNotFoundException& nfex) {
        logger->error("Setting missing in configuration file. {} -> {}", nfex.what(), nfex.getPath());
        logger->flush();
        exitCode = EXIT_FAILURE;
    }
    catch (const std::runtime_error& rex) {
        logger->critical("Could not initialize component. {} ", rex.what());
        logger->flush();
        exitCode = EXIT_FAILURE;
    }
    catch(...)
    {
        std::exception_ptr p = std::current_exception();
        std::clog <<(p ? p.__cxa_exception_type()->name() : "null") << std::endl;
    }
    uaServer.reset();

    spdlog::shutdown();
    return exitCode;
}
