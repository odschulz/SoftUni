using System;
using System.Collections.Generic;
using System.Linq;

class LongestWordInAText
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ', ',', ':', ';', '.', '!', '"', '\'' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> words = input.ToList<string>();
        string result = string.Empty;
        for (int i = 0; i < words.Count-1; i++)
        {
            if (words[i].Length >= result.Length)
            {
                result = words[i];
            }
        }
        Console.WriteLine(result);
    }
}

