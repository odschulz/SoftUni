using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Animals
{
    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private Gender gender;

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("The Name parameter cannot be an empty string!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The Age parameter cannot be zero or a negative number!");
                }
                this.age = value;
            }
        }
        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public abstract void ProduceSound();

        public override string ToString()
        {
            return String.Format("Type: {0}\nName: {1}\nAge: {2}\nGender: {3}",
                this.GetType().Name, this.Name, this.Age, this.Gender);
        }

    }
}
