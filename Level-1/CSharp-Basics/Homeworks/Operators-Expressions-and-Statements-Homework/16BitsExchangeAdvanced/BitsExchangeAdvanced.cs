using System;

class BitsExchangeAdvanced
{
    static void Main()
    {
        try
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            uint mask = 1;
            int loopP = p;

            if ((p + k - 1 > 31) | (q + k - 1) > 31)
            {
                Console.WriteLine("Out of range");
            }
            else if (Math.Min(p, q) + k - 1 >= Math.Max(p, q))
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                for (int i = p; i <= loopP + k - 1; i++)
                {
                    uint carrierQ = ((mask << q) & n) >> q; // this carries the bits from Q sequence
                    uint carrierP = ((mask << p) & n) >> p; // this carries the bits from P sequence
                    n = ~(mask << p) & n;                   // makes bit p to 0
                    n = ~(mask << q) & n;                   // makes bit q to 0
                    n = (carrierQ << p) | n;                // value of q goes to p
                    n = (carrierP << q) | n;                // value of p goes to q
                    p++;
                    q++;
                }
                Console.WriteLine(n);
            }
        }
        catch(Exception cannotFit)
        {
            Console.WriteLine("Out of range");
        }
    }
}

