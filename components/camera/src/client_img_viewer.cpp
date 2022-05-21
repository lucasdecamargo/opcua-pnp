#include <CameraClient.h>

#include <CLI/CLI.hpp>
#include <libconfig.h++>

#include <spdlog/spdlog.h>
#include <logging.h>
#include <logging_opcua.h>
#include <helper.hpp>

#include <opencv2/imgcodecs.hpp>
#include <opencv2/imgproc/imgproc.hpp>
#include <opencv2/highgui.hpp>


std::shared_ptr<spdlog::logger> logger;

bool running = true;

cv::Mat imgdecode(UA_ImagePNG &img);


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

    std::string configFile = "img_viewer_component.cfg";
    std::string clientCertFiles;
    app.add_option("--config", configFile, "Configuration file path");
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

    logger = pnp::log::LoggerFactory::createLogger("imgviewer",
                                                       settings["logging"]["level"]["app"],
                                                       settings["logging"].exists("path") ? settings["logging"]["path"] : "");

    std::shared_ptr<CameraClient> uaClient;

    int exitCode = EXIT_SUCCESS;

    try 
    {
        if (clientCertFiles.empty()) {
            logger->error("Client certificates are required. Use --certs-client command line option.");
            return (EXIT_FAILURE);
        }

        logger->info("Starting Camera Server ...");

        std::shared_ptr<spdlog::logger> loggerUa = logger->clone(logger->name() + "-ua");
        pnp::log::LoggerFactory::setLoggerLevel(loggerUa, settings["logging"]["level"]["opcua"]);

        uaClient = std::make_shared<CameraClient>(
            logger,
            loggerUa,
            settings["client"]["serverurl"],
            settings["client"]["username"],
            settings["client"]["password"],
            clientCertFiles + std::string("_cert.der"),
            clientCertFiles + std::string("_key.der"),
            "pnp.component.imgviewer",
            "imgviewer"
        );

        UA_StatusCode ret = uaClient->connect();
        if(ret != UA_STATUSCODE_GOOD)
            throw std::runtime_error("Cannot connect to client. STATUSCODE: " +
                std::string(UA_StatusCode_name(ret)));
        ret = uaClient->stepAsync();
        if(ret != UA_STATUSCODE_GOOD)
            throw std::runtime_error("Cannot intialize async client. STATUSCODE: " +
                std::string(UA_StatusCode_name(ret)));

        cv::namedWindow("ImagePNG", cv::WindowFlags::WINDOW_AUTOSIZE);

        cv::Mat img;
        while(running)
        {
            try
            {
                UA_ImagePNG ua_img;
                UA_ImagePNG_init(&ua_img);
                uaClient->readImageNode(&ua_img);
                img = imgdecode(ua_img);
                if(!img.empty())
                {
                    cv::imshow("ImagePNG", img);

                    (char)cv::waitKey(25);
                }
                UA_ImagePNG_clear(&ua_img);
            }
            catch(const std::exception& e)
            {
                logger->error("Failed on reading image: " + std::string(e.what()));
            }

            std::this_thread::yield();
            std::this_thread::sleep_for(std::chrono::milliseconds(1000));
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
    cv::destroyAllWindows();
    uaClient.reset();

    spdlog::shutdown();
    return exitCode;
}


cv::Mat imgdecode(UA_ImagePNG &img)
{
    return cv::imdecode(cv::Mat(1, img.length, CV_8UC1, img.data), cv::IMREAD_UNCHANGED);
}
