public static class ResistorColor
{
    private static readonly string[] colorCodes = {
        "black", "brown", "red", "orange", "yellow",
        "green", "blue", "violet", "grey", "white"
    };
    
    public static int ColorCode(string color)
    {
        for (int i = 0; i < colorCodes.Length; i++)
        {
            if (colorCodes[i] == color)
            {
                return i;
            }
        }
        throw new ArgumentException("Invalid color");
    }

    public static string[] Colors() => colorCodes;
}