public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int total = 0;
        for (int i = 1; i < max; i++)
        {
            foreach (int multiple in multiples)
            {
                if (multiple != 0 && i % multiple == 0)
                {
                    total += i;
                    break;
                }
            }
        }
        return total;
    }
}