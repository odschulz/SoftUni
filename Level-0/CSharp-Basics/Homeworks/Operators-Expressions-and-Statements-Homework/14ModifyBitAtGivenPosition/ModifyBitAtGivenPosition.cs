using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());
        int v;
        do
        {
            Console.Write("Enter bit value (1 or 0): ");
            v = int.Parse(Console.ReadLine());
        } while ((v < 0) | (v > 1));
        if (v == 1)
        {
            n = n | (1 << p);
            Console.WriteLine(n);
        }
        else
        {
            n = n & ~(1 << p);
            Console.WriteLine(n);
        }
    }
}
