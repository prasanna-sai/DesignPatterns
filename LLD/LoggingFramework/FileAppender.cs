using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingFramework
{
    public class FileAppender : ILogAppender
    {
        private readonly string _filePath;

        public FileAppender(string filePath)
        {
            _filePath = filePath;
        }

        public void Append(LogMessage logMessage)
        {
            try
            {
                using (var writer = new StreamWriter(_filePath, true))
                {
                    writer.WriteLine(logMessage.ToString());
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("FileAppender error: " + ex.Message);
            }
        }
    }
}
