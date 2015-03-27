using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }
        public override void ProduceSound()
        {
            Console.WriteLine("The {0} {1} meows.", this.GetType().Name.ToLower(), this.Name);
        }
    }
}
