public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        if (subjects == null || subjects.Length == 0)
            return Array.Empty<string>();

        var poem = new List<string>();

        for (int i = 0; i < subjects.Length - 1; i++)
        {
            poem.Add($"For want of a {subjects[i]} the {subjects[i + 1]} was lost.");
        }

        poem.Add($"And all for the want of a {subjects[0]}.");

        return poem.ToArray();
    }
}