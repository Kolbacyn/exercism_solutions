using System;
using System.Text.RegularExpressions;

enum LogLevel
{
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
    Unknown = 0
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        string pattern = @"\[(.*?)\]";
        Match match = Regex.Match(logLine, pattern);
        string extracted = string.Empty;
        if (match.Success)
        {
            extracted = match.Groups[1].Value;
        }
        switch (extracted)
        {
            case "INF":
                return LogLevel.Info;
            case "TRC":
                return LogLevel.Trace;
            case "DBG":
                return LogLevel.Debug;
            case "WRN":
                return LogLevel.Warning;
            case "ERR":
                return LogLevel.Error;
            case "FTL":
                return LogLevel.Fatal;
            default:
                return LogLevel.Unknown;
        };
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:{message}";
    }
}
