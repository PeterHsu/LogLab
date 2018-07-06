using NLog;
using NLog.Common;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;

namespace Lab05_ConsoleCoreLog
{
    [Target("HttpGet")]
    public class HTTPGetTarget: NetworkTarget
    {
        protected override void WriteAsyncThreadSafe(AsyncLogEventInfo logEvent)
        {
            logEvent.LogEvent.Message = $"^{logEvent.LogEvent.Message}^";
            string logMessage = this.Layout.Render(logEvent.LogEvent);
            logMessage = logMessage.Split('^')[1].Replace("\"", "");
            logEvent.LogEvent.Message = logMessage;
            base.WriteAsyncThreadSafe(logEvent);
        }
    }
}
