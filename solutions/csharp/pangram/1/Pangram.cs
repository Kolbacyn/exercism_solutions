public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var seen = new HashSet<char>();
        foreach (char c in input)
        {
            if (!char.IsLetter(c))
                continue;
            seen.Add(char.ToLower(c));
        }
        return seen.Count == 26;
    }
}
