public static class DifferenceOfSquares
{
    public static List<int> GenerateNumbers(int number)
    {
        var numbers = new List<int>();
        for (int i = 1; i <= number; i++)
        {
            numbers.Add(i);
        }
        return numbers;
    }
    
    public static int CalculateSquareOfSum(int max)
    {
        var numbers = GenerateNumbers(max);
        int total = 0;
        foreach (var number in numbers)
        {
            total += number;
        }
        return total*total;
    }

    public static int CalculateSumOfSquares(int max)
    {
        var numbers = GenerateNumbers(max);
        int total = 0;
        foreach (var number in numbers)
        {
            total += number*number;
        }
        return total;
    }

    public static int CalculateDifferenceOfSquares(int max) =>
        CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}