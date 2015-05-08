using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal integer: ");
        string input = Console.ReadLine().ToUpper();
        long n = 0;
        for (int i = 0; i < input.Length; i++)
        {
            //Console.WriteLine(input[i]);
            switch (input[i])
            {
                case 'A':
                    n += 10 * (long)Math.Pow(16, input.Length - i - 1);  //i at position zero is from the left, thats why its not 16^i
                    break;                                               //instead its ^the index at the most left position
                case 'B':
                    n += 11 * (long)Math.Pow(16, input.Length - i - 1);
                    break;
                case 'C':
                    n += 12 * (long)Math.Pow(16, input.Length - i - 1);
                    break;
                case 'D':
                    n += 13 * (long)Math.Pow(16, input.Length - i - 1);
                    break;
                case 'E':
                    n += 14 * (long)Math.Pow(16, input.Length - i - 1);
                    break;
                case 'F':
                    n += 15 * (long)Math.Pow(16, input.Length - i - 1);
                    break;
                default:
                    n += (long) char.GetNumericValue(input[i]) * (long)Math.Pow(16, input.Length - i - 1);
                    break;
            }
        }
        Console.WriteLine(n);
    }
}

