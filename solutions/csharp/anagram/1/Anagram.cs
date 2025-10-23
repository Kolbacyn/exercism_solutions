public class Anagram
{
    private string baseWord;
    
    public Anagram(string baseWord)
    {
        this.baseWord = baseWord.ToLower();
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> matchedWords = new List<string>();
        string sortedBase = new string(baseWord.OrderBy(c => c).ToArray());

        foreach (var word in potentialMatches)
        {
            if (baseWord.Equals(word, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            string sortedPotential = new string(word.ToLower().OrderBy(c => c).ToArray());

            if (sortedBase.Equals(sortedPotential, StringComparison.OrdinalIgnoreCase))
            {
                matchedWords.Add(word);
            }
        }
        return matchedWords.ToArray();
    }
}