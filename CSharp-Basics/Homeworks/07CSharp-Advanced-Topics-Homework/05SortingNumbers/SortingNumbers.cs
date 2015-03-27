using System;

class SortingNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);
        NumbersArray(numbers);
    }
    static void NumbersArray(int[] numbers)
    { 
            
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}

