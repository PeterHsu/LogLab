using NLog;
using NLog.Config;
using System;

namespace Lab03_ConsoleCoreLog
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
            LogManager.Configuration = new XmlLoggingConfiguration("./Config/nlog.config");
            var logger = LogManager.GetCurrentClassLogger();
            //#範例展示標準的Json輸出所需要的欄位
            logger.Info("Hello {User}", new { Name = "Peter", Age = 18 });
        }
        static void Demo02()
        {
            LogManager.Configuration = new XmlLoggingConfiguration("./Config/nlog2.config");
            var logger = LogManager.GetCurrentClassLogger();
            //#範例展示檔案最大為1K, 只備份10個檔案, 用日期做檔名
            for (int i = 0; i < 100; i++)
            {
                logger.Info("Hello {User}", new { Name = "Peter", Age = 18 });
            }
        }
    }
}
