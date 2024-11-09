using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingFramework
{
    public class ConsoleAppender : ILogAppender
    {
        public void Append(LogMessage logMessage)
        {
            Console.WriteLine(logMessage.ToString());
        }
    }
}
