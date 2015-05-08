using System;

class FourDigitNumber
{
    static void Main()
    {
        int n;
        do
        {
            Console.WriteLine("Enter a four digit number (cannot start with 0): ");
            n = int.Parse(Console.ReadLine());

        } while ((n.ToString().Length > 4) || ((n / 1000 == 0)));
        int a = n / 1000;
        int b = (n / 100) % 10;
        int c = (n / 10) % 10;
        int d = n % 10;

        Console.WriteLine("Sum of digits= " + (a + b + c + d));
        Console.WriteLine("Reversed: " + d + c + b + a);
        Console.WriteLine("last digit in front: " + d + a + b + c);
        Console.WriteLine("Second and third digits exchanged: " + a + c + b + d);
    }
}

