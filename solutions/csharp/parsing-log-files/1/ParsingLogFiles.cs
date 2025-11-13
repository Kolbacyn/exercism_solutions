using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class LogParser
{
    private static readonly Regex SeparatorRegex = new Regex(@"<[\^\*\=\-]*>", RegexOptions.Compiled);
    
    public bool IsValidLine(string text) =>
        Regex.IsMatch(text, @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]");

    public string[] SplitLogLine(string text) =>
        SeparatorRegex.Split(text);

    public int CountQuotedPasswords(string lines)
    {
        int counter = 0;
        var pattern = @"\""[^\""]*password[^\""]*\""";
        var regex = new Regex(pattern, RegexOptions.IgnoreCase);
        var lineArray = lines.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
    
        foreach (var line in lineArray)
        {
            if (regex.IsMatch(line))
            {
                counter++;
            }
        }
        return counter;
    }

    public string RemoveEndOfLineText(string line) =>
        Regex.Replace(line, @"end-of-line[0-9]+", "");

    public string[] ListLinesWithPasswords(string[] lines)
    {
        var pattern = @"\b(password\w+)";
        var regex = new Regex(pattern, RegexOptions.IgnoreCase);

        var result = new List<string>();

        foreach (var line in lines)
        {
            var match = regex.Match(line);
            if (match.Success)
            {
                result.Add($"{match.Groups[1].Value}: {line}");
            }
            else
            {
                result.Add($"--------: {line}");
            }
        }
        return result.ToArray();
    }
}
