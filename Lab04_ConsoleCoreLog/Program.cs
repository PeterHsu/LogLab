using NLog;
using NLog.Config;
using System;

namespace Lab04_ConsoleCoreLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo01();
            Console.ReadLine();
        }
        static void Demo01()
        {
            LogManager.Configuration = new XmlLoggingConfiguration("./Config/nlog.config");
            var logger = LogManager.GetCurrentClassLogger();
            //#範例輸出到ELK
            //#ELK的日期格式要"${date:universalTime=true:format=o}"
            //#logstash的設定請參考logstash.conf
            //#如果要上到ELK, 則{Users}不能使用中文
            logger.Info("哈囉 {Users}", new { Name = "天才", Age = 18 });
        }
    }
}
