using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter size of matrix (1 <= n <= 20): ");
        int n = int.Parse(Console.ReadLine());
        if (1 <= n && n <= 20)
        {
            int[,] matrix = new int[n, n];
            int direction = 1;
            int digit = 1;
            int row = 0;
            int column = 0;
            int turn = n;
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                if (direction == 1)
                {
                    for (int j = 1; j <= turn; j++)
                    {
                        matrix[row, column++] = digit++;
                    }
                    direction++;
                    turn--;
                    column--;
                }
                if (direction == 2)
                {
                    for (int j = 1; j <= turn; j++)
                    {
                        matrix[++row, column] = digit++;
                    }
                    direction++;
                }
                if (direction == 3)
                {
                    for (int j = 1; j <= turn; j++)
                    {
                        matrix[row, --column] = digit++;
                    }
                    direction++;
                    turn--;
                    row--;
                }
                if (direction == 4)
                {
                    for (int j = 1; j <= turn; j++)
                    {
                        matrix[row--, column] = digit++;
                    }
                    direction = direction - 3;
                    row++;
                    column++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (n <= 3)
                    {
                        Console.Write("{0} ", matrix[i, j]);
                    }
                    else if (n <= 9)
                    {
                        if (matrix[i, j] < 10)
                        {
                            Console.Write("{0}  ", matrix[i, j]);
                        }
                        else
                        {
                            Console.Write("{0} ", matrix[i, j]);
                        }
                    }
                    else
                    {
                        if (matrix[i, j] < 10)
                        {
                            Console.Write("{0}   ", matrix[i, j]);
                        }
                        else if (matrix[i, j] < 100)
                        {
                            Console.Write("{0}  ", matrix[i, j]);
                        }
                        else
                        {
                            Console.Write("{0} ", matrix[i, j]);
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }
}

