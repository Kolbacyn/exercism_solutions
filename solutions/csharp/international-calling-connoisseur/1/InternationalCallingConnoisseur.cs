using System;
using System.Collections.Generic;


public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary() =>
        new Dictionary<int, string>();

    public static Dictionary<int, string> GetExistingDictionary()
    {
        var prePopulated = new Dictionary<int, string>
        {
            {1, "United States of America"},
            {55, "Brazil"},
            {91, "India"}
        };
        return prePopulated;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var newDictionary = GetEmptyDictionary();
        newDictionary[countryCode] = countryName;
        return newDictionary;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary[countryCode] = countryName;
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.TryGetValue(countryCode, out string value))
            return value;
        else
            return string.Empty;
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.TryGetValue(countryCode, out string value))
            return true;
        return false;
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (existingDictionary.TryGetValue(countryCode, out string value))
            existingDictionary[countryCode] = countryName;
        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        bool removed = existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        string longestValue = string.Empty;
        int maxLength = 0;

        foreach (var value in existingDictionary.Values)
        {
            if (value.Length > maxLength)
            {
                maxLength = value.Length;
                longestValue = value;
            }
        }
        return longestValue;
    }
}