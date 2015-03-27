using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        uint start = uint.Parse(Console.ReadLine());
        uint end = uint.Parse(Console.ReadLine());
        uint p = 0;
        uint remainder;
        for (uint i = start; i <= end; i++)
        {
            remainder = i % 5;
            if (remainder == 0)
            {
                Console.Write(i);
                p++;
                if (i <= end-5)
                {
                    Console.Write(", ");
                }
            }
        }
        if (p == 0)
        {
            Console.WriteLine("-");
            Console.WriteLine("p = 0");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("p = {0}", p);
        }
    }
}

