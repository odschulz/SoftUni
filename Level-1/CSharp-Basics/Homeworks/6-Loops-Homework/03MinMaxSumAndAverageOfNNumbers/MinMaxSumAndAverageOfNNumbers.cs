using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        double avg;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            int input = int.Parse(Console.ReadLine());
            sum += input;
            if (input < min)
            {
                min = input;
            }
            if (input > max)
            {
                max = input;
            }
        }
        avg = (double) sum / n;
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:0.00}", avg);
    }
}
