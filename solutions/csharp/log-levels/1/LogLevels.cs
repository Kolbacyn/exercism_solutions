static class LogLine
{
    public static string Message(string logLine)
    {
        string[] parts = logLine.Split(new string[] {"]: "}, StringSplitOptions.None);
        return parts[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        string[] parts = logLine.Split(new string[] {"]: "}, StringSplitOptions.None);
        string logLevel = parts[0].TrimStart('[').ToLower();
        return logLevel;
    }

    public static string Reformat(string logLine)
    {
        string[] parts = logLine.Split(new string[] {"]: "}, StringSplitOptions.None);
        string logInfo = parts[1].Trim();
        string logLevel = parts[0].TrimStart('[').ToLower();
        string response = logInfo + " (" + logLevel + ")";
        return response;
    }
}
