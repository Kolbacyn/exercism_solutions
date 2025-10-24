public static class ResistorColorDuo
{
    private static readonly string[] colorCodes ={
         "black", "brown", "red", "orange", "yellow",
        "green", "blue", "violet", "grey", "white"
    };
    
    public static int Value(string[] colors)
    {
        int tens = ColorCode(colors[0]) * 10;
        int ones = ColorCode(colors[1]);
        return tens + ones;
    }

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
}
