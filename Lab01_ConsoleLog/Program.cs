using NLog;
using NLog.Config;
using System;
using System.Configuration;

namespace Lab01_ConsoleLog
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo01();
            Demo02();
            Console.ReadLine();

        }
        static void Demo01()
        {
            //#預設讀取執行目錄裡的nlog.config
            //#範例展示輸出到Console及檔案
            var logger = LogManager.GetCurrentClassLogger();
            logger.Info("Hello World!!!");
        }
        static void Demo02()
        {
            //#從應用程式組態讀取nlog組態檔的位置, 再載入nlog
            var config = new XmlLoggingConfiguration(ConfigurationManager.AppSettings["nlog.config"]);
            LogManager.Configuration = config;

            var logger = LogManager.GetCurrentClassLogger();
            logger.Info("Hello Peter!!!");
        }
    }
}
