using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        string[,] matrix = new string[r, c];
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                matrix[i, j] = "" + (char)('a' + i) + (char)('a' + i + j) + (char)('a' + i);
            }
        }
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(matrix[i, j]);
                if (j < c - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

