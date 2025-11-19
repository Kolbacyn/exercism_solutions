using System;
using System.Collections.Generic;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 2) return new int[0]; // no primes less than 2
        
        bool[] isPrime = new bool[limit + 1];
        for (int i = 2; i <= limit; i++)
            isPrime[i] = true;
        
        for (int i = 2; i * i <= limit; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= limit; j += i)
                    isPrime[j] = false;
            }
        }
        
        List<int> primesList = new List<int>();
        for (int i = 2; i <= limit; i++)
        {
            if (isPrime[i])
                primesList.Add(i);
        }
        
        return primesList.ToArray();
    }
}
