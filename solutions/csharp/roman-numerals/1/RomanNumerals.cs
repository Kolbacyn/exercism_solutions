using System;
using System.Collections.Generic;
using System.Text;

public static class RomanNumeralExtension
{
    private static readonly List<KeyValuePair<int, string>> digitMap = new List<KeyValuePair<int, string>>
    {
        new KeyValuePair<int, string>(1000, "M"),
        new KeyValuePair<int, string>(900, "CM"),
        new KeyValuePair<int, string>(500, "D"),
        new KeyValuePair<int, string>(400, "CD"),
        new KeyValuePair<int, string>(100, "C"),
        new KeyValuePair<int, string>(90, "XC"),
        new KeyValuePair<int, string>(50, "L"),
        new KeyValuePair<int, string>(40, "XL"),
        new KeyValuePair<int, string>(10, "X"),
        new KeyValuePair<int, string>(9, "IX"),
        new KeyValuePair<int, string>(5, "V"),
        new KeyValuePair<int, string>(4, "IV"),
        new KeyValuePair<int, string>(1, "I"),
    };

    public static string ToRoman(this int value)
    {
        if (value <= 0 || value > 3999)
            throw new ArgumentException("Input should be a positive number above zero and less than 4000.");

        var result = new StringBuilder();

        foreach (var pair in digitMap)
        {
            while (value >= pair.Key)
            {
                result.Append(pair.Value);
                value -= pair.Key;
            }
        }

        return result.ToString();
    }
}