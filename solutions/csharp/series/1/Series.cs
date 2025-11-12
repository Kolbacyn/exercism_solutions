public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength > numbers.Length)
        {
            throw new ArgumentException("Slice length should be less or equal length of numbers");
        }
        if (sliceLength <= 0)
        {
            throw new ArgumentException("Slice length should be a positive integer above zero");
        }
        string[] slices = new string[numbers.Length - sliceLength + 1];
        for (int i = 0; i <= numbers.Length - sliceLength; i++)
        {
            slices[i] = numbers.Substring(i, sliceLength);
        }
        return slices;
    }
}