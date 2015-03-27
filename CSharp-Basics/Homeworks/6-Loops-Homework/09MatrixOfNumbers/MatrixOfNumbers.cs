using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter n (1 <= n <= 20): ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (1 <= n && n <= 20)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n + i - 1; j++)
                {
                    if (n <= 5)  //in order to have the right spacing for one- and two-digit numbers
                    {
                        Console.Write("{0} ", j);
                    }
                    else
                    {
                        if (j < 10)
                        {
                            Console.Write("{0}  ", j);
                        }
                        else
                        {
                            Console.Write("{0} ", j);
                        }
                        
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Wrong input.");
        }
    }
}

