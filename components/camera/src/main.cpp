#include <Camera.h>

#include <CLI/CLI.hpp>
#include <libconfig.h++>

#include <spdlog/spdlog.h>
#include <logging.h>
#include <logging_opcua.h>
#include <helper.hpp>

#include <Webcam.hpp>

#define CAMERA_DEVICE Webcam

std::shared_ptr<spdlog::logger> logger;

bool running = true;

static void stopHandler(int)
{
    logger->warn("Received Ctrl-C. Shutting down...");
    logger->flush();
    running = false;
}

int main(int argc, char* argv[])
{
    signal(SIGINT, stopHandler);
    signal(SIGTERM, stopHandler);

    CLI::App app{"Camera Server"};

    std::string configFile = "component.cfg";
    std::string certFiles;
    std::string clientCertFiles;
    app.add_option("--config", configFile, "Configuration file path");
    app.add_option("--certs-server", certFiles, "The server certificate files without extension");
    app.add_option("--certs-client", clientCertFiles, "The client certificate files without extension");

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

    logger = pnp::log::LoggerFactory::createLogger("camera",
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

        logger->info("Starting Camera Server ...");

        uaServer = std::make_shared<pnp::opcua::OpcUaServer>(
                settings,
                logger,
                "pnp.component.camera",
                "Component - Camera",
                certFiles,
                "pnp.component.camera.client",
                "Component - Camera - Client",
                clientCertFiles);

        std::shared_ptr<spdlog::logger> loggerUa = logger->clone(logger->name() + "-ua");
        pnp::log::LoggerFactory::setLoggerLevel(loggerUa, settings["logging"]["level"]["opcua"]);

        // std::shared_ptr<CameraDevice> device = std::make_shared<CvDevice>("/home/lucas/Coding/OPCUA/opcua-pnp/video_ex.mp4");
        // std::shared_ptr<CameraDevice> device = std::make_shared<CvDevice>("/home/lucas/Coding/OPCUA/opcua-pnp/markers.jpg");
        std::shared_ptr<CameraDevice> device = std::make_shared<CvDevice>(0);
        // device->set(CameraDeviceProperties::CAP_PROP_FORMAT, CameraDeviceEncoders::BMP);
        device->open();

        std::shared_ptr<Camera> camera = std::make_shared<Camera>(
            logger, loggerUa, uaServer, settings["camera"], device);

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