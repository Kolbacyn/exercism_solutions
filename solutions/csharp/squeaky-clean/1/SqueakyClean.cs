using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var result = new StringBuilder();
        bool capitalizeNext = false;
        for (int i = 0; i < identifier.Length; i++)
        {
            if (char.IsLetter(identifier[i]))
                {
                if (identifier[i] >= '\u03B1' && identifier[i] <= '\u03C9')
                    continue;
                if (capitalizeNext)
                {
                    result.Append(char.ToUpper(identifier[i]));
                    capitalizeNext = false;
                }
                else
                {
                    result.Append(identifier[i]);
                }
            }
            else if (char.IsControl(identifier[i]))
                result.Append("CTRL");
            else if (char.IsWhiteSpace(identifier[i]))
                result.Append("_");
            else if (identifier[i] == '-')
                capitalizeNext = true;
            
        }
        return result.ToString();
    }
}
