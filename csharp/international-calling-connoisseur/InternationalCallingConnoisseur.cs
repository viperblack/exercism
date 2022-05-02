using System;
using System.Collections.Generic;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        var empty = new Dictionary<int, string>();
        return empty;
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        var codes = new Dictionary<int, string>{
            {1, "United States of America"},
            {55,  "Brazil"},
            {91, "India"}
        };
        return codes;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var newOnly = GetEmptyDictionary();
        newOnly.Add(countryCode, countryName);
        return newOnly;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        string countryName;
        if (existingDictionary.TryGetValue(countryCode, out countryName))
        {
            return countryName;
        }
        else
        {
            return string.Empty;
        }
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary[countryCode] = countryName;
            return existingDictionary;
        }
        else
        {
            return existingDictionary;
        }

    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;

    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        string longest = string.Empty;
        foreach (var item in existingDictionary)
        {
            if (item.Value.Length > longest.Length)
            {
                longest = item.Value;
            }
        }
        return longest;
    }
}