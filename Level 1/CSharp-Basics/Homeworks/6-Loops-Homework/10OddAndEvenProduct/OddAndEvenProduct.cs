using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Enter numbers separated by a space: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int odds = 1;
        int evens = 1;
        for (int i = 1; i <= numbers.Length; i++)
        {
            if (i % 2 != 0)
            {
                odds *= Convert.ToInt32(numbers[i-1]);
            }
            else
            {
                evens *= Convert.ToInt32(numbers[i-1]);
            }
        }
        Console.WriteLine();
        if (odds == evens)
        {
            Console.WriteLine("yes\nproduct = {0}", odds);
        }
        else
        {
            Console.WriteLine("no\nodd_nproduct = {0}\neven_product = {1}", odds, evens);
        }
        Console.WriteLine(odds);
        Console.WriteLine(evens);
    }
}

