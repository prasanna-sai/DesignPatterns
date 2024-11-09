using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingFramework
{
    public class LoggerConfig
    {
        public LogLevel LogLevel { get; set; }
        public ILogAppender LogAppender { get; set; }

        public LoggerConfig(LogLevel logLevel, ILogAppender logAppender)
        {
            LogLevel = logLevel;
            LogAppender = logAppender;
        }
    }
}
