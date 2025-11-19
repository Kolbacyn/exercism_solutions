using System;
using System.Collections.Generic;
using System.Linq;

public static class FoodChain
{
    private static readonly string[] animals = {
        "fly", "spider", "bird", "cat", "dog", "goat", "cow", "horse"
    };

    private static readonly string[] comments = {
        "", 
        "It wriggled and jiggled and tickled inside her.",
        "How absurd to swallow a bird!",
        "Imagine that, to swallow a cat!",
        "What a hog, to swallow a dog!",
        "Just opened her throat and swallowed a goat!",
        "I don't know how she swallowed a cow!",
        "She's dead, of course!"
    };

    public static string Recite(int startVerse, int endVerse = -1)
    {
        if (endVerse == -1) endVerse = startVerse;

        var verses = new List<string>();

        for (int i = startVerse; i <= endVerse; i++)
        {
            verses.Add(BuildVerse(i));
        }

        return string.Join("\n\n", verses);
    }

    private static string BuildVerse(int verse)
    {
        int index = verse - 1;
        string animal = animals[index];

        var lines = new List<string>
        {
            $"I know an old lady who swallowed a {animal}."
        };

        if (!string.IsNullOrEmpty(comments[index]))
            lines.Add(comments[index]);

        if (animal == "horse")
            return string.Join("\n", lines); // final verse, no follow-up

        // Build the chain backwards
        for (int i = index; i > 0; i--)
        {
            string current = animals[i];
            string previous = animals[i - 1];

            if (current == "bird" && previous == "spider")
                lines.Add($"She swallowed the {current} to catch the {previous} that wriggled and jiggled and tickled inside her.");
            else
                lines.Add($"She swallowed the {current} to catch the {previous}.");
        }

        lines.Add("I don't know why she swallowed the fly. Perhaps she'll die.");

        return string.Join("\n", lines);
    }
}
