using System;

class ExtractBit3
{
    static void Main()
    { 
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        int nRightP = n >> p;
        int bit = nRightP & 1;
        Console.WriteLine(bit);
    }
}

