using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13AverageLoadTimeCalculator
{
    class AverageLoadTimeCalculator
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            Dictionary<string, int> count = new Dictionary<string, int>();
            while (input != string.Empty)
            {
                string[] inputArray = input.Split(' ');
                string webLink = inputArray[2];
                double loadTime = Convert.ToDouble(inputArray[3]);
                if (!dictionary.ContainsKey(webLink))
                {
                    dictionary[webLink] = loadTime;
                    count[webLink] = 1;
                }
                else
                {
                    dictionary[webLink] += loadTime;
                    count[webLink]++;
                }
                input = Console.ReadLine();
            }
            foreach (string webLink in dictionary.Keys)
            {
                Console.WriteLine("{0} -> {1}", webLink, dictionary[webLink]/count[webLink]);
            }
        }
    }
}
