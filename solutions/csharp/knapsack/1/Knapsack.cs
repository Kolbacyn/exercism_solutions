using System;
using System.Collections.Generic;

public static class Knapsack
{
    public static int MaximumValue(int maximumWeight, (int weight, int value)[] items)
    {
        int n = items.Length;
        int[,] dp = new int[n + 1, maximumWeight + 1];

        for (int i = 1; i <= n; i++)
        {
            int w = items[i - 1].weight;
            int v = items[i - 1].value;

            for (int weight = 0; weight <= maximumWeight; weight++)
            {
                if (w <= weight)
                {
                    dp[i, weight] = Math.Max(dp[i - 1, weight], dp[i - 1, weight - w] + v);
                }
                else
                {
                    dp[i, weight] = dp[i - 1, weight];
                }
            }
        }
        return dp[n, maximumWeight];
    }
}
