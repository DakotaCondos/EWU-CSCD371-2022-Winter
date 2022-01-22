﻿namespace Logger
{
    public abstract class BaseLogger
    {
        public LogType Type;
        public abstract void Log(LogLevel logLevel, string message);

        // There is an existing BaseLogger class. It needs an auto property to hold the class name.
        public abstract string ClassName { get; set; }

    }
}
