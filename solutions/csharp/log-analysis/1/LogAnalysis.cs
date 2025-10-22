public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimeter)
    {
        string[] parts = str.Split(new string[] {delimeter}, StringSplitOptions.None);
        return parts[1];
    }

    public static string SubstringBetween(this string str, string start, string end)
    {
        int initial = str.IndexOf(start);
        if (initial == -1)
            return null;

        initial += start.Length;

        int ending = str.IndexOf(end);
        if (ending == -1)
            return null;

        return str.Substring(initial, ending - initial);
    }
    
    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }

    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}