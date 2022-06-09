using System;

public static class LogAnalysis
{
    public static string SubstringAfter(this string message, string delimiter)
    {
        int initialIndex = message.LastIndexOf(delimiter) + delimiter.Length;
        return message.Substring(initialIndex);
    }

    public static string SubstringBetween(this string message, string delimiterOne, string delimiterTwo)
    {
        int initialIndex = message.LastIndexOf(delimiterOne) + delimiterOne.Length;
        int length = message.IndexOf(delimiterTwo) - initialIndex;
        return message.Substring(initialIndex, length);
    }

    public static string Message(this string log)
    {
        return log.SubstringAfter("]: ");
    }

    public static string LogLevel(this string log)
    {
        return log.SubstringBetween("[", "]: ");
    }
}