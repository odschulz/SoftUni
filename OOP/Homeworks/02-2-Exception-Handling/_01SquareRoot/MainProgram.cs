using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SquareRoot
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            
            try
            {
                Console.Write("Enter a positive integer: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(SqrRoot.GetSqrRoot(number));
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number! Please enter an integer!");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.ParamName);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
