using System;
using System.Collections.Generic;
using System.Text;

public static class RnaTranscription
{
    private static readonly Dictionary<char, string> conversionToRNA = new Dictionary<char, string>
    {
        ['G'] = "C",
        ['C'] = "G",
        ['T'] = "A",
        ['A'] = "U"
    };
    
    public static string ToRna(string strand)
    {
        var result = new StringBuilder();
        foreach (char letter in strand)
        {
            result.Append(conversionToRNA[letter]);
        }
        return result.ToString();
    }
}