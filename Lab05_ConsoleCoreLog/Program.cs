using NLog;
using NLog.Config;
using System;

namespace Lab05_ConsoleCoreLog
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager.Configuration = new XmlLoggingConfiguration("./Config/nlog.config");
            var logger = LogManager.GetCurrentClassLogger();
            //#傳送到Synology的Chat
            logger.Info("Hello {User}", new { Name = "Peter", Age = 18 });
            Console.ReadLine();
        }
    }
}

