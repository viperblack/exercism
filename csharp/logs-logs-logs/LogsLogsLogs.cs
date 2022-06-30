using System;

// TODO: define the 'LogLevel' enum
public enum LogLevel
{
    Unknown = 0,
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42
}
static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {        
        switch (logLine.Substring(0, 5))
        {
            case "[TRC]":
                return LogLevel.Trace;
            case "[DBG]":
                return LogLevel.Debug;
            case "[INF]":
                return LogLevel.Info;
            case "[WRN]":
                return LogLevel.Warning;
            case "[ERR]":
                return LogLevel.Error;
            case "[FTL]":
                return LogLevel.Fatal;
            default:
                return LogLevel.Unknown;
        }
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        switch (logLevel)
        {
            case LogLevel.Unknown:
                return (int)LogLevel.Unknown + ":" + message;
            case LogLevel.Trace:
                return (int)LogLevel.Trace + ":" + message;
            case LogLevel.Debug:
                return (int)LogLevel.Debug + ":" + message;
            case LogLevel.Info:
                return (int)LogLevel.Info + ":" + message;
            case LogLevel.Warning:
                return (int)LogLevel.Warning + ":" + message;
            case LogLevel.Error:
                return (int)LogLevel.Error + ":" + message;
            case LogLevel.Fatal:
                return (int)LogLevel.Fatal + ":" + message;
            default:
                return "Not Found";
        }
    }
}
