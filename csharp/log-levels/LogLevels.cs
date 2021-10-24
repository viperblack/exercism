using System;

static class LogLine
{
    public static string Message(string logLine)
    {
    
    string[] subs = logLine.Split(':');
    return subs[1].Trim();

        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
    
    string[] subs = logLine.Split(':');
    return subs[0].Replace('[',' ').Replace(']', ' ' ).ToLower().Trim();

        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
    
    string[] subs = logLine.Split(':');
    string msg = subs[1].Trim();
    string lvl = subs[0].Replace('[',' ').Replace(']', ' ' ).Trim().ToLower();
    return msg + " (" + lvl + ")";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
