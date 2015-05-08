using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09RemoveNames
{
    class RemoveNames
    {
        static void Main(string[] args)
        {
            string[] lineOne = Console.ReadLine().Split(' ');
            List<string> listOne = lineOne.ToList<string>();
            string[] lineTwo = Console.ReadLine().Split(' ');
            List<string> listTwo = lineTwo.ToList<string>();
            for (int i = 0; i < listTwo.Count; i++)
            {
                for (int j = 0; j < listOne.Count; j++)
                {
                    if (listOne[j] == listTwo[i])
                    {
                        listOne.RemoveAt(j);
                        j--;
                    }
                }
            }
            for (int i = 0; i < listOne.Count; i++)
            {
                Console.Write(listOne[i]);
                if (i < listOne.Count-1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
