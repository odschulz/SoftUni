using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        char clubs = '\u2663';
        char diamonds = '\u2666';
        char hearts = '\u2665';
        char spades = '\u2660';
        for (int i = 2; i <= 14; i++)
        {
            if (i < 11)
            {
                Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}",i, clubs, diamonds, hearts, spades);
            }
            else if (i == 11)
            {
                for (int j = i; j <= 14; j++)
                {
                    switch (j)
                    {
                        case 11: Console.WriteLine("J{0} J{1} J{2} J{3}", clubs, diamonds, hearts, spades);
                            break;
                        case 12: Console.WriteLine("Q{0} Q{1} Q{2} Q{3}", clubs, diamonds, hearts, spades);
                            break;
                        case 13: Console.WriteLine("K{0} K{1} K{2} K{3}", clubs, diamonds, hearts, spades);
                            break;
                        case 14: Console.WriteLine("A{0} A{1} A{2} A{3}", clubs, diamonds, hearts, spades);
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                return;
            }
        }
    }
}
