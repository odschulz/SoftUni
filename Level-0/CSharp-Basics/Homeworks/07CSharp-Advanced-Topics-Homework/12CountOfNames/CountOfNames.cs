using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12CountOfNames
{
    class CountOfNames
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> output = input.Split(' ').ToList();
            output.Sort();
            int count = 1;
            for (int i = 0; i < output.Count - 1; i++)
            {
                if (output[i + 1] == output[i])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", output[i], count);
                    count = 1;
                }
                if (i == output.Count - 2)
                {
                    Console.WriteLine("{0} -> {1}", output[i + 1], count);
                }
            }
        }
    }
}
