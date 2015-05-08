using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class MainProgram
    {
        public static void Main()
        {
            Payment consulting = new Payment("Consulting Services", 1000);
            Payment legal = new Payment("Legal Services", 5000);

            Customer pesho = new Customer("Pesho", "M.", "Peshev", "0123456789", new List<Payment> { consulting });
            Customer maria = new Customer("Maria", "G.", "Tsaneva", "9876543210", new List<Payment> { legal });

            Console.WriteLine(pesho);
            Console.WriteLine(maria);
            Console.WriteLine("Is Pesho equal to Maria: " + (pesho == maria));
            Console.WriteLine("Is Pesho NOT equal to Maria: " + (pesho != maria));
            
            Customer clonedPesho = (Customer)pesho.Clone();
            
            clonedPesho.FirstName = "Petar";
            Console.WriteLine("\nCloned Pesho and changed first name of clone:\n" + clonedPesho);
            Console.WriteLine("\nOriginal Pesho:\n" + pesho);

            Console.WriteLine("CompareTo() with Pesho and Cloned Pesho: " + pesho.CompareTo(clonedPesho));
            Console.WriteLine("Reference equals between Pesho and cloned Pesho: "  
                + Object.ReferenceEquals(pesho, clonedPesho));
            
        }
    }
