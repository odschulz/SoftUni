using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter p: ");
        int p = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        int bit = nRightP & 1;
        bool bitValue = bit == 1;
        Console.WriteLine(bitValue);
    }
}

