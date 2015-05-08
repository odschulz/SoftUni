using System;
using System.Collections.Generic;
using System.Text;

public static class StringBuilderExtensions
{
    public static string Substring(this StringBuilder input, int startIndex, int length)
    {
        if ((startIndex + length) > input.Length)
        {
            throw new ArgumentOutOfRangeException("Start Index and Length must refer to a location within the string.");
        }

        return input.ToString().Substring(startIndex, length);
    }

    public static StringBuilder RemoveText(this StringBuilder input, string text)
    {
        int startIndex = 0;
        int endIndex = 0;
        while (input.ToString().ToLower().IndexOf(text.ToLower()) > -1)
        {
            startIndex = input.ToString().ToLower().IndexOf(text.ToLower());
            endIndex = text.Length;
            input.Remove(startIndex, endIndex);
        }

        return input;
    }

    public static StringBuilder AppendAll<T>(this StringBuilder input, IEnumerable<T> items)
    {
        foreach (var item in items)
        {
            input.Append(item.ToString());
        }

        return input;
    }
}