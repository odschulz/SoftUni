using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a binary integer: ");
        string input = Console.ReadLine();
        long n = 0;
        for (int i = 0; i < input.Length; i++)
		{
            if (input[input.Length - i - 1] == '1')
            {
                n += (long)Math.Pow(2, i);
            }
		}
        Console.WriteLine(n);
    }
}

