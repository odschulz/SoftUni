using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02HumanStudentAndWorker
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student("Atanas", "Atanasov", "SU100"), 
                new Student("Atanas", "Borisov", "SU101"), 
                new Student("Boris", "Borisov", "TU109"), 
                new Student("Velizar", "Velizarov", "TU108"), 
                new Student("Georgi", "Georgiev", "SU107"), 
                new Student("Petar", "Petrov", "SU106"), 
                new Student("John", "Atanasov", "TU102"), 
                new Student("Michael", "Jordan", "SU103"), 
                new Student("Diego", "Gonzalez", "TU104"), 
                new Student("John", "Rambo", "SU105")
            };

            var studentsByFacultyNumber = students.OrderBy(s => s.FacultyNumber);
            Console.WriteLine("Students ordered by faculty number:\n");
            foreach (var student in studentsByFacultyNumber)
            {
                Console.WriteLine(student + "\n");
            }
            Console.WriteLine("----------------------------------");

            var workers = new List<Worker>
            {
                new Worker("Ivan", "Ivanov", 400, 8), 
                new Worker("Georgi", "Karagyozov", 425, 8), 
                new Worker("Mincho", "Praznikov", 600, 9), 
                new Worker("Valcho", "Valchanov", 450, 8), 
                new Worker("Mitio", "Pishtova", 300, 6), 
                new Worker("Zelen", "Patlajan", 150, 4), 
                new Worker("Patron", "Gazarev", 1000, 10), 
                new Worker("Cassius", "Clay", 550, 8), 
                new Worker("Robert", "Johnson", 525, 8), 
                new Worker("Slowhand", "Clapton", 100, 2)
            };

            var workersByHourlySalary = workers.OrderByDescending(w => w.MoneyPerHour()).ThenByDescending(w => w.WeekSalary);
            Console.WriteLine("Workers sorted by hourly payment:");
            foreach (var worker in workersByHourlySalary)
            {
                Console.WriteLine(worker + "\n-> Money per hour: " + worker.MoneyPerHour() + "\n");
            }

            Console.WriteLine("----------------------------------");

            var humans = new List<Human>(students.Count + workers.Count);
            //Improves performance to define length of the list as some collegues have pointed out in the forum

            humans.AddRange(students);
            humans.AddRange(workers);
            var humansSortedByName = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);
            foreach (var human in humansSortedByName)
            {
                Console.WriteLine(human);
                if (human.GetType() == typeof(Student))
                {
                    Console.WriteLine("Occupation: Student\n");
                }
                else
                {
                    Console.WriteLine("Occupation: Worker\n");
                }

            }
        }
    }
}
