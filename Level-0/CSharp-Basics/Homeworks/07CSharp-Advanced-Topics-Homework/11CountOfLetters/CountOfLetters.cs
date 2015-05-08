using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11CountOfLetters
{
    class CountOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> letters = input.ToList();
            letters.RemoveAll(item => item == ' ');
            letters.Sort();
            int count = 1;
            for (int i = 0; i < letters.Count-1; i++)
            {
                if (letters[i+1] == letters[i])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", letters[i], count);
                    count = 1;
                }
                if (i == letters.Count - 2)
                {
                    Console.WriteLine("{0} -> {1}", letters[i+1], count);
                }
            }
        }
    }
}
