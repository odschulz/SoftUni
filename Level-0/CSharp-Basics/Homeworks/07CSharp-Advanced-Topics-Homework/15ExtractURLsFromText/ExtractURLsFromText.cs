using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _15ExtractURLsFromText
{
    class ExtractURLsFromText
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Regex linkParser = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (Match m in linkParser.Matches(input))
                Console.WriteLine(m);
        }
    }
}