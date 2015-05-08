using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EnterNumbers
{
    class NumberReader
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int totalAmount = 10;

            int[] numbers = new int[totalAmount];
            for (int i = 0; i < totalAmount; i++)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("| {0} more numbers required to finish the program |", totalAmount - i);
                Console.WriteLine("--------------------------------------------------");
                try
                {
                    numbers[i] = ReadNumber(start, end);

                    if (end - (totalAmount - (i + 1)) <= numbers[i])
                    {
                        Console.Error.WriteLine(
                            "Number not accepted! Not enough possible numbers between {0} and {1} to finish the program", 
                            numbers[i], end);
                        i--;
                    }
                    else
                    {
                        start = numbers[i];
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.Error.WriteLine(ex.ParamName);
                    i--;
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine("Invalid number format! You must enter an integer!");
                    i--;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Entered numbers: " + String.Join(", ", numbers));
        }

        static int ReadNumber(int start, int end)
        {
            Console.Write("Enter a number in the range {0} < number < {1}: ", start, end);
            int number = int.Parse(Console.ReadLine());
            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException("Number not in range!");
            }
            return number;
        }
    }
}
