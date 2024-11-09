﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingFramework
{
    public class LogMessage
    {
        public LogLevel Level { get; }
        public string Message { get; }
        public long Timestamp { get; }

        public LogMessage(LogLevel level, string message)
        {
            Level = level;
            Message = message;
            Timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        }

        public override string ToString()
        {
            return $"[{Level}] {Timestamp} - {Message}";
        }
    }
}
