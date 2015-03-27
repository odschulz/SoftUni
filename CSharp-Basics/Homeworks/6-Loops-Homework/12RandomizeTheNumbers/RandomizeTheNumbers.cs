using System;

class RandomizeTheNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Random r = new Random();
        for (int i = 0; i < n; i++) //fill the array with numbers from 1 to N in order
        {
            arr[i] = i + 1;
            Console.Write("{0} ", arr[i]);
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++) //Fisher–Yates shuffle algorithm to shuffle the numbers in the array
        {
            int j = r.Next(i, n);
            if (j != i)
            {
            arr[j] = arr[j] + arr[i]; // exchange values algorithm
            arr[i] = arr[j] - arr[i];
            arr[j] = arr[j] - arr[i];
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", arr[i]); //print each number in the array
        }
        Console.WriteLine();
    }
}

