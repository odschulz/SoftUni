using System;

class Calculate
{
    static void Main()
    {
        //Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        int factorial=1;
        double sum = 0;
        double s;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += factorial / Math.Pow(x, i);
        }
        s = 1 + sum;
        Console.WriteLine("{0:0.00000}", s);
    }
}

