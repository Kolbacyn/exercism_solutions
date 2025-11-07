using System;
using System.Globalization;

public static class HighSchoolSweethearts
{
    public static string DisplaySingleLine(string studentA, string studentB)
    {
        const int totalWidth = 61;
        string heart = "♡";
        int leftSide = totalWidth / 2 - studentA.Length - 1;
        string leftPad = new string(' ', leftSide);
        int rightSide = totalWidth / 2 - studentB.Length - 1;
        string rightPad = new string(' ', rightSide);
        return $"{leftPad}{studentA} {heart} {studentB}{rightPad}";
    }

    public static string DisplayBanner(string studentA, string studentB)
    {
        string[] banner = new string[]
        {
            "     ******       ******",
            "   **      **   **      **",
            " **         ** **         **",
            "**            *            **",
            "**                         **",
            $"**     {studentA} +  {studentB}    **",
            " **                       **",
            "   **                   **",
            "     **               **",
            "       **           **",
            "         **       **",
            "           **   **",
            "             ***",
            "              *"
        };
        return string.Join("\n", banner);
    }

    public static string DisplayGermanExchangeStudents(string studentA
        , string studentB, DateTime start, float hours)
    {
        var germanCulture = CultureInfo.GetCultureInfo("de-DE");
        string formattedDate = start.ToString("dd.MM.yyyy", germanCulture);
        string formattedHours = hours.ToString("N2", germanCulture);

        return $"{studentA} and {studentB} have been dating since {formattedDate} - that's {formattedHours} hours";
    }
}
