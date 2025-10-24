public static class Bob
{
    public static string Response(string statement)
    {
        if (string.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";
        bool isQuestion = statement.TrimEnd().EndsWith("?");
        bool isYell = false;
        bool hasLetters = false;

        foreach (char c in statement)
        {
            if (char.IsLetter(c))
            {
                hasLetters = true;
                if (char.IsUpper(c))
                {
                    isYell = true;
                }
                else
                {
                    isYell = false;
                    break;
                }
            }
        }

        if (isYell && isQuestion)
            return "Calm down, I know what I'm doing!";
        if (isYell && hasLetters)
            return "Whoa, chill out!" ;
        if (isQuestion)
            return "Sure.";
        return "Whatever.";
    }
}