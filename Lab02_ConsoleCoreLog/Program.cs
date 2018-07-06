using Microsoft.Extensions.Configuration;
using NLog;
using NLog.Config;
using System;

namespace Lab02_ConsoleCoreLog
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo01();
            //Demo02();
            Demo03();
            Console.WriteLine();
        }
        static void Demo01()
        {
            //#.NET Core讀取組態的方式如下, 習慣取名為appsettings.json
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            LogManager.Configuration = new XmlLoggingConfiguration(config["nlog.config"]);

            var logger = LogManager.GetCurrentClassLogger();
            logger.Info("Hello Peter!!!");
        }
        static void Demo02()
        {
            LogManager.Configuration = new XmlLoggingConfiguration("./Config/nlog_Demo2.config");
            var logger = LogManager.GetCurrentClassLogger();
            //#以下Log Level有層級關係
            logger.Fatal("Fatal Message");
            logger.Error("Error Message");
            logger.Warn("Warn Message");
            logger.Info("Info Message");
            logger.Debug("Debug Message");
            logger.Trace("Trace Message");
        }
        static void Demo03()
        {
            LogManager.Configuration = new XmlLoggingConfiguration("./Config/nlog_Demo3.config");
            var logger = LogManager.GetCurrentClassLogger();
            //#可用Format格式
            logger.Info("Hello {0}", "Peter");
            //#結構式日誌
            logger.Info("Hello {user}", "Peter");
            logger.Info("Hello {@user}", "Peter");
            logger.Info("Hello {$user}", "Peter");

            logger.Info("Hello {user}", new { Name = "Peter", Age = 18 });
            logger.Info("Hello {@user}", new { Name = "Mandy", Age = 16 }); //#Json
            logger.Info("Hello {$user}", new { Name = "Dash", Age = 10 }); //#ToString
        }
    }
}
