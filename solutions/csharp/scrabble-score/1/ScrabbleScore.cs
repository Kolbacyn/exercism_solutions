public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int result = 0;
        foreach (char ch in input)
        {
            result += CheckLetter(ch);
        }
        return result;
    }

    public static int CheckLetter(char letter)
    {
        letter = Char.ToUpper(letter);

        if ("AEIOULNRST".Contains(letter)) return 1;
        if ("DG".Contains(letter)) return 2;
        if ("BCMP".Contains(letter)) return 3;
        if ("FHVWY".Contains(letter)) return 4;
        if ("K".Contains(letter)) return 5;
        if ("JX".Contains(letter)) return 8;
        if ("QZ".Contains(letter)) return 10;
        return 0;
    }
}