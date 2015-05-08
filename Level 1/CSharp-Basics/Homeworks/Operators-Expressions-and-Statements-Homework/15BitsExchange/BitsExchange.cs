using System;

class BitsExchange
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint mask = 7;                              // 0000 0111 (3x1)
        uint bitsCarrier1 = (mask << 3) & n;        // get the bits from first sequence
        uint bitsCarrier2 = (mask << 24) & n;       // get the bits from second sequence
        n = ~(mask << 3) & n;                       // make bits in first sequence 0
        n = ~(mask << 24) & n;                      // make bits in second sequence 0
        n = (bitsCarrier1 << 21) | n;
        n = (bitsCarrier2 >> 21) | n;
        Console.WriteLine(n);
    }
}

