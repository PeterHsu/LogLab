using NLog;
using NLog.Config;
using System;
using System.IO;

namespace Lab05_ConsoleCoreLog
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager.Configuration = new XmlLoggingConfiguration("./Config/nlog.config");
            var logger = LogManager.GetCurrentClassLogger();
            File.WriteAllText(@"D:\test\LogLab\Lab05_ConsoleCoreLog\bin\Debug\netcoreapp2.1\c.txt", "abc");
            //#傳送到Synology的Chat
            //logger.Info("測試 {User}", new { Name = "Peter", Age = 18 });
            //#使用Json傳送HTTPGet時, 雙引號會造成錯誤, 所以自訂HttpGetTarget來解決
            logger.Info("測試 {@User}", new { Name = "使用者" });
            Console.ReadLine();
        }
    }
}

