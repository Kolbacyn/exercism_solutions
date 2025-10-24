using System.Text;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        if (string.IsNullOrEmpty(phrase))
            return string.Empty;
        phrase = phrase.Replace('-', ' ').Replace('_', ' ');
        phrase = Regex.Replace(phrase, @"[^\w\s]", "");

        var words = phrase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var acronym = new StringBuilder();

        foreach (var word in words)
        {
            if (!string.IsNullOrWhiteSpace(word))
                acronym.Append(char.ToUpper(word[0]));
        }
        return acronym.ToString();
    }
}