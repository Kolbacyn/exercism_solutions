using System;
using System.Collections.Generic;

public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        if (inputBase < 2) throw new ArgumentException("Input base must be >= 2");
        if (outputBase < 2) throw new ArgumentException("Output base must be >= 2");
        if (inputDigits.Length == 0) return new int[] {0};
        
        // Convert from input base to base 10 integer
        int value = 0;
        foreach (int digit in inputDigits)
        {
            if (digit < 0 || digit >= inputBase)
                throw new ArgumentException("Input digits contain invalid digits for the input base.");
            checked
            {
                value = value * inputBase + digit;
            }
        }
        
        // Convert from base 10 integer to output base digits
        if (value == 0)
            return new int[] {0};
        
        List<int> resultDigits = new List<int>();
        while (value > 0)
        {
            resultDigits.Add(value % outputBase);
            value /= outputBase;
        }
        resultDigits.Reverse();
        return resultDigits.ToArray();
    }
}
