using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01School
{
    class MainProgram
    {
        public static void Main(string[] args)
        {

            Person person = new Person("Ivan Ivanov", "Applying to become a teacher");

            Student student1 = new Student("Pesho Peshev", "student", "12345");
            Student student2 = new Student("Georgi Georgiev", "student", "12346");
            Discipline math = new Discipline("Math", 20, new List<Student> { student1 });
            Discipline literature = new Discipline("Literature", 20, new List<Student> { student2 });
            List<Discipline> disciplines = new List<Discipline> { math, literature };
            Teacher teacher = new Teacher("Dimitar Dimitrov", disciplines, "senior teacher");
            SchoolClass schoolClass = new SchoolClass("AABBCC", new List<Teacher> { teacher },
                new List<Student> { student1, student2 }, "A cool class");

            List<IDetailable> allDetailableObjects = new List<IDetailable>
            {
                person,
                student1,
                student2,
                teacher,
                math,
                literature,
                schoolClass
            };

            foreach (var item in allDetailableObjects)
            {
                Console.WriteLine(item.GetType().Name + ":\n" + item);
                Console.WriteLine();
            }
        }
    }
}
