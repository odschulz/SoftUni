using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Animals
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
                new Frog("Minka", 2, Gender.Female),
                new Frog("Mincho", 4, Gender.Male),
                new Dog("Ringo - Kucheto Ubiec", 5, Gender.Male),
                new Dog("Spaska", 7, Gender.Female),
                new Cat("Jasmina", 3, Gender.Female),
                new Cat("Chocho", 4, Gender.Male),
                new Kitten("Kitty", 1),
                new Tomcat("Pier", 3)
            };

            foreach (var animal in animals)
            {
                animal.ProduceSound();
            }

            Console.WriteLine();

            //Linq

            var averageAges =
                from animal in animals
                group animal.Age by animal.GetType() into animalGroup
                select new { AnymalType = animalGroup.Key.Name, AverageAge = animalGroup.Average() };


            foreach (var group in averageAges)
            {
                Console.WriteLine("The average age of animals of type {0} is: {1}.",
                    group.AnymalType, group.AverageAge);
            }


            Console.WriteLine(averageAges);

        }
    }
}
