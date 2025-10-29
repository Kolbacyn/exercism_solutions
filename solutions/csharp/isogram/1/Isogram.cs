public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var seen = new HashSet<char>();
        string lowered = word.ToLower();

        foreach (char c in lowered)
        {
            if (!char.IsLetter(c))
                continue;

            if (seen.Contains(c))
                return false;
    
            seen.Add(c);
        }
        return true;
    }
}
