using System;

class LongSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1001; i++)
        {
            Console.Write(i * (Math.Pow(-1, i)) + ", ");
        }
    }
}

