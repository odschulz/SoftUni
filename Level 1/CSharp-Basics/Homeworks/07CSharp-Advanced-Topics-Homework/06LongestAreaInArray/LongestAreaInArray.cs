using System;

class LongestAreaInArray
{
    static void Main()
    {
        Console.WriteLine("Enter number of strings: ");
        int n = int.Parse(Console.ReadLine());
        string[] input = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("String {0}: ", i+1);
            input[i] = Console.ReadLine();
        }
        int sequence = 1;
        int biggestSequence = 1;
        int firstIndex = 0;
        int lastIndex = 0;
        for (int i = 0; i < input.Length-1; i++)
        {
            if (input[i] == input[i + 1])
            {
                sequence++;
                if (sequence > biggestSequence)
                {
                    biggestSequence = sequence;
                    lastIndex = i+1;
                    firstIndex = lastIndex - biggestSequence + 1;
                }
            }
            else
            {
                sequence = 1;
            }
        }
        Console.WriteLine();
        Console.WriteLine(biggestSequence);
        for (int i = firstIndex; i <= lastIndex; i++)
        {
            Console.WriteLine(input[i]);
        }
    }
}

