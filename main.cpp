#include <iostream>

#include <MES.h>

#include <CLI/CLI.hpp>
#include <logging.h>
#include <logging_opcua.h>

std::shared_ptr<spdlog::logger> logger;
bool running = true;

static void stopHandler(int)
{
    logger->warn("Received Ctrl-C. Shutting down...");
    logger->flush();
    running = false;
}

static void
registerServerCallback(
        const UA_RegisteredServer* registeredServer,
        void* data
)
{
    auto mes = static_cast<MES*>(data);
    mes->onServerRegister(registeredServer);
}

int main(int argc, char* argv[]) {
    // ------------- General initialization -------------------
    signal(SIGINT, stopHandler);
    signal(SIGTERM, stopHandler);


    std::string configFile = "component.cfg";
    std::string certFiles;
    std::string clientCertFiles;
    
    CLI::App app{"Semantic MES"};
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

    logger = pnp::log::LoggerFactory::createLogger(
            "mes",
            settings["logging"]["level"]["app"],
            settings["logging"].exists("path") ? settings["logging"]["path"] : "");

    std::shared_ptr<pnp::opcua::OpcUaServer> uaServer;

    int exitCode = EXIT_SUCCESS;

    try {
        if (clientCertFiles.empty()) {
            logger->error("Client certificates are required. Use --certs-client command line option.");
            return (EXIT_FAILURE);
        }

        if (settings["opcua"]["encryption"] && certFiles.empty()) {
            logger->error("Encryption is enabled but no certificates are given. Use --certs command line option.");
            return (EXIT_FAILURE);
        }

        logger->info("Starting MES ...");

        uaServer = std::make_shared<pnp::opcua::OpcUaServer>(
                settings,
                logger,
                "pnp.component.mes",
                "PNP MES",
                certFiles,
                "pnp.component.mes.client",
                "PNP MES - Client",
                clientCertFiles);

        if (settings.exists("custom_hostname")) {
            UA_String hostname = UA_STRING_ALLOC(settings["custom_hostname"].c_str());
            UA_String_clear(&uaServer->getServerConfig()->customHostname);
            UA_String_copy(&hostname, &uaServer->getServerConfig()->customHostname);
            UA_String_clear(&hostname);
        }

        std::string clientCert = clientCertFiles + "_cert.der";
        std::string clientKey = clientCertFiles + "_key.der";


        std::shared_ptr<spdlog::logger> loggerUa = logger->clone(logger->name() + "-ua");
        pnp::log::LoggerFactory::setLoggerLevel(loggerUa, settings["logging"]["level"]["opcua"]);

        std::shared_ptr<MES> semanticMES = std::make_shared<MES>(
                logger, loggerUa, uaServer, clientCert, clientKey, settings["pnp"]);

        {
            LockedServer ls = uaServer->getLocked();
            UA_Server_setRegisterServerCallback(ls.get(), &registerServerCallback, (void*) semanticMES.get());
        }

        if (uaServer->init(
                true,
                std::bind(&MES::onServerAnnounce, semanticMES, std::placeholders::_1, std::placeholders::_1)
        ) == UA_STATUSCODE_GOOD) {
            // semanticMES->start();

            while (running)
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
        logger->critical("Could not initialize sMES control. {} ", rex.what());
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
