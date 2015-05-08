using System;
using System.Collections.Generic;
using System.Linq;

public class MainProgram
{
    public static void Main()
    {
        List<string> animals = new List<string>() { "dog", "cat", "cow", "duck" };
        string[] suffixes = new string[] { "og", "w", "g" };
        int[] numbers = new int[] { 1, 2, 3 };

        Console.WriteLine(string.Join(", ", animals.WhereNot(an => an.Equals("cow"))));

        Console.WriteLine(string.Join(", ", numbers.Repeat(2)));

        Console.WriteLine(string.Join(", ", animals.WhereEndsWith(suffixes)));
    }
}