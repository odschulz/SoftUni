using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            string lineOne = Console.ReadLine();
            string lineTwo = Console.ReadLine();
            List<int> firstList = lineOne.Split(' ').Select(Int32.Parse).ToList();
            List<int> secondList = lineTwo.Split(' ').Select(Int32.Parse).ToList();
            List<int> combinedLists = firstList.Concat(secondList).Distinct().ToList();
            combinedLists.Sort();
            //foreach (int number in combinedLists)
            //{
            //    Console.WriteLine(number);
            //}
            for (int i = 0; i < combinedLists.Count; i++)
            {
                Console.Write(combinedLists[i]);
                if (i < combinedLists.Count-1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
