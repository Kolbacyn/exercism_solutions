using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        if (shiftKey < 0 || shiftKey > 26)
            throw new ArgumentOutOfRangeException(nameof(shiftKey), "Key must be between 0 and 26.");

        var result = new StringBuilder();

        foreach (char c in text)
        {
            if (char.IsUpper(c))
            {
                char shifted = (char)(((c - 'A' + shiftKey) % 26) + 'A');
                result.Append(shifted);
            }
            else if (char.IsLower(c))
            {
                char shifted = (char)(((c - 'a' + shiftKey) % 26) + 'a');
                result.Append(shifted);
            }
            else
            {
                result.Append(c);
            }
        }
        return result.ToString();
    }
}