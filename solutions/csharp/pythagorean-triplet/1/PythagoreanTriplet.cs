public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        var triplets = new List<(int a, int b, int c)>();
        for (int a = 1; a < sum + 1; a++)
        {
            for (int b = a + 1; b < sum + 1; b++)
            {
                int cSquare = a*a + b*b;
                double c = Math.Sqrt(cSquare);
                if (a + b + c == sum)
                {
                    triplets.Add((a, b, (int)c));
                }
            }
        }
        return triplets;
    }
}