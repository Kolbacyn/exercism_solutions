public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> oneToOne = new Dictionary<string, int>();
        foreach (var kvp in old)
        {
            if (kvp.Value != null && kvp.Value.Length > 0)
            {
                for (int i = 0; i < kvp.Value.Length; i++)
                {
                    oneToOne[kvp.Value[i].ToLower()] = kvp.Key;
                }
            }
        }
        return oneToOne;
    }
}