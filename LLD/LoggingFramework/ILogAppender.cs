﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingFramework
{
    public interface ILogAppender
    {
        void Append(LogMessage logMessage);
    }
}
