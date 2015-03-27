using System;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //©
        Console.Write("To create a triangle, enter a divisible by 3 integer: ");
//        int amountSymbols = int.Parse(Console.ReadLine());
		int amountSymbols = 21;
		Console.WriteLine ();

        char symbol = '\u00A9';                 //enter desired symbol to form triangle
        char externalSpaces = '\u0020';         //enter desired symbol surrounding triangle
        int rows = (amountSymbols + 3) / 3;     //possible to enter amount of desired rows of triangle

        for (int i = rows - 1; i >= 1; i--)
        {
            Console.Write(new string(externalSpaces, i));
            Console.Write(symbol);
            int internalSpaces = ((rows * 2) - 1) - ((i * 2) + 2);

            if (i == (rows - 1))
            {
                Console.WriteLine(new string(externalSpaces, i));
            }
            else
            {
                Console.Write(new string(externalSpaces, internalSpaces));
                Console.Write(symbol);
                Console.WriteLine(new string(externalSpaces, i));
            }
        }
        for (int j = 1; j <= rows; j++)
        {
            Console.Write(symbol);
            if (j < rows)
            Console.Write(externalSpaces);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}