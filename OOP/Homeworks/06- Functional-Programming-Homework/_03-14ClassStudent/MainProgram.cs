using System;
using System.Collections.Generic;
using System.Linq;

public class MainProgram
{
    public static void Main()
    {
        var students = new List<Student>()
        {
            new Student(
            "Pesho", "Ivanov", 22, "000114", "0888111112", 
            "pesho@abv.bg", new List<int> { 6, 5, 4 }, 1, GroupName.GrandesCojones),
            new Student(
            "Ivan", "Peshev", 20, "000214", "0888111113", 
            "ivan@mente.com", new List<int> { 3, 3, 3 }, 2, GroupName.FeistyMarmots),
            new Student(
            "Georgi", "Dimitrov", 30, "000314", "0256552587", 
            "georgi@mente.com", new List<int> { 2, 3, 2 }, 3, GroupName.BolivianMermaids),
            new Student(
            "Marina", "Petrova", 25, "000414", "0888111115", 
            "marina@abv.bg", new List<int> { 5, 3, 5 }, 4, GroupName.NakedCommandos),
            new Student(
            "Petya", "Marinova", 25, "000113", "+359222266544", 
            "petya@mente.com", new List<int> { 5, 6, 5 }, 1, GroupName.GrandesCojones),
            new Student(
            "Gergana", "Ilieva", 32, "000213", "0888111116", 
            "gergana@gmail.com", new List<int> { 5, 6, 2 }, 2, GroupName.FeistyMarmots),
            new Student(
            "Dimitar", "Dimitrov", 17, "000313", "+359 2 2545 55 55", 
            "mitko@gmail.com", new List<int> { 6, 6, 6 }, 3, GroupName.NakedCommandos),
            new Student(
            "Hristo", "Paskalev", 30, "000413", "0888111118", 
            "hristo@mente.com", new List<int> { 5, 4, 5 }, 4, GroupName.BolivianMermaids)
        };

        Console.WriteLine("------------------------------4------------------------------\n");

        /* Problem 4. Students by Group
         * Print all students from group number 2. Use a LINQ query. Order the students by FirstName. */
        var groupTwoStudents = from student in students
                               where student.GroupNumber == 2
                               orderby student.FirstName
                               select student;
        Console.WriteLine("Students from group 2: \n");
        foreach (var student in groupTwoStudents)
        {
            Console.WriteLine(
                "Name: " + student.FirstName + " " + student.LastName + "; Group Number: " + student.GroupNumber + ";");
        }

        Console.WriteLine("\n------------------------------5------------------------------\n");
        
        /* Problem 5. Students by First and Last Name 
         * Print all students whose first name is before their last name alphabetically. 
         * Use a LINQ query. */
        var firstBeforeLastNameStudents = from student in students
                                          where student.FirstName.CompareTo(student.LastName) < 0
                                          select student;

        Console.WriteLine("Students with first before last Name: \n");
        foreach (var student in firstBeforeLastNameStudents)
        {
            Console.WriteLine("Name: " + student.FirstName + " " + student.LastName);
        }

        Console.WriteLine("\n------------------------------6------------------------------\n");

        /* Problem 6. Students by Age 
         * Write a LINQ query that finds the first name and last name of all students 
         * with age between 18 and 24. The query should return only the first name, last name and age */
        var studentsBetween18And24 = from st in students
                                     where (st.Age > 17 && st.Age < 25)
                                     select (new { FirstName = st.FirstName, LastName = st.LastName, Age = st.Age });

        Console.WriteLine("Students between age of 18 and 24: \n");
        foreach (var student in studentsBetween18And24)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("\n------------------------------7------------------------------\n");

        /* Problem 7. Sort Students 
         * Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students 
         * by first name and last name in descending order. Rewrite the same with LINQ query syntax. */
        Console.WriteLine("Students sorted by first name and last name with extension methods:\n");

        students.
            OrderByDescending(s => s.FirstName).
            ThenByDescending(s => s.LastName).
            ToList().ForEach(s => Console.WriteLine(s.FirstName + " " + s.LastName));

        Console.WriteLine("\nStudents sorted by first name and last name with LINQ query syntax:\n");

        var studentsInDescending = from s in students
                                   orderby s.FirstName descending, s.LastName descending
                                   select s;

        foreach (var student in studentsInDescending)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }

        Console.WriteLine("\n------------------------------8------------------------------\n");

        /* Problem 8. Filter Students by Email Domain
         * Print all students that have email @abv.bg. Use LINQ. */
        var studentsByEmailDomain = from s in students
                                    where s.Email.EndsWith("abv.bg")
                                    select s;

        Console.WriteLine("Students with email @abv.bg");
        foreach (var s in studentsByEmailDomain)
        {
            Console.WriteLine("Name: " + s.FirstName + " " + s.LastName + "; Email: " + s.Email + ";");
        }

        Console.WriteLine("\n------------------------------9------------------------------\n");

        /* Problem 9. Filter Students by Phone 
         * Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). Use LINQ. */
        var studentsByPhoneInSofia = from s in students
                                     where (
                                        s.Phone.StartsWith("02") || 
                                        s.Phone.StartsWith("+3592") || 
                                        s.Phone.StartsWith("+359 2"))
                                     select s;

        Console.WriteLine("Students with phones in Sofia:\n");
        foreach (var s in studentsByPhoneInSofia)
        {
            Console.WriteLine("Name: " + s.FirstName + " " + s.LastName + "; Phone: " + s.Phone + ";");
        }

        Console.WriteLine("\n------------------------------10-----------------------------\n");

        /* Problem 10. Excellent Students 
         * Print all students that have at least one mark Excellent (6). 
         * Using LINQ first select them into a new anonymous class that holds { FullName + Marks}. */
        var excellentStudents = from s in students
                                where s.Marks.Contains(6)
                                select (
                                    new { FullName = s.FirstName + " " + s.LastName, Marks = s.Marks });
        Console.WriteLine("Students that have at least one mark Excellent (6):\n");
        foreach (var s in excellentStudents)
        {
            Console.WriteLine("Name: " + s.FullName + "; Marks: " + string.Join(", ", s.Marks));
        }

        Console.WriteLine("\n------------------------------11-----------------------------\n");

        /* Problem 11. Weak Students 
         * Write a similar program to the previous one to extract the students with exactly two marks "2". 
         * Use extension methods. */
        var weakStudents = students.Where(s => s.Marks.Where(m => m == 2).Count() == 2);
        Console.WriteLine("Students with exactly two marks \"2\":\n");
        foreach (var s in weakStudents)
        {
            Console.WriteLine(
                "Name: " + s.FirstName + " " + s.LastName +  "; Marks: " + string.Join(", ", s.Marks));
        }

        Console.WriteLine("\n------------------------------12-----------------------------\n");

        /* Problem 12. Students Enrolled in 2014 
         * Extract and print the Marks of the students that enrolled in 2014 
         * (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber). */
        var students2014 = students.Where(s => s.FacultyNumber.ToString().Substring(4, 2) == "14");
        Console.WriteLine("Students that enrolled in 2014:\n");
        foreach (var s in students2014)
        {
            Console.WriteLine("Name: " + s.FirstName + " " + s.LastName + "; Faculty Number: " + s.FacultyNumber);
        }

        Console.WriteLine("\n------------------------------13*----------------------------\n");

        /* Problem 13.* Students by Groups 
         * Add a GroupName property to Student. 
         * Write a program that extracts all students grouped by GroupName and then prints them on the console. 
         * Print all group names along with the students in each group. Use the "group by into" LINQ operator. */
        var studentsByGroupName = from s in students
                                  group (s.FirstName + " " + s.LastName) by s.GroupName into g
                                  select new { GroupName = g.Key, StudentNames = string.Join(", ", g) };
        Console.WriteLine("Extracted students grouped by GroupName:\n");
        foreach (var group in studentsByGroupName)
        {
            Console.WriteLine("Group Name: " + group.GroupName + ":\n" + "Students: " + group.StudentNames + "\n");
        }

        Console.WriteLine("\n------------------------------14*----------------------------\n");

        /* Students Joined to Specialties 
         * Create a class StudentSpecialty that holds specialty name and faculty number. 
         * Create a list of student specialties, where each specialty 
         * corresponds to a certain student (via the faculty number). 
         * Print all student names alphabetically along with their faculty number and specialty name. 
         * Use the "join" LINQ operator. */
        var specialties = new List<StudentSpecialty>() 
        { 
        new StudentSpecialty("Web Developer", "000114"),
        new StudentSpecialty("Web Developer", "000214"),
        new StudentSpecialty("Web Developer", "000314"),
        new StudentSpecialty("PHP Developer", "000113"),
        new StudentSpecialty("PHP Developer", "000213"),
        new StudentSpecialty("PHP Developer", "000413"),
        new StudentSpecialty("PHP Developer", "000414"),
        new StudentSpecialty("QA Engineer", "000214"),
        new StudentSpecialty("QA Engineer", "000313"),
        new StudentSpecialty("QA Engineer", "000413")
        };

        var studentsWithSpecialties = from st in students
                                      join sp in specialties on st.FacultyNumber equals sp.FacultyNumber
                                      orderby st.FirstName, st.LastName, sp.SpecialtyName
                                      select new 
                                      { 
                                          FullName = st.FirstName + " " + st.LastName, 
                                          st.FacultyNumber, 
                                          sp.SpecialtyName 
                                      };

        Console.WriteLine("-".PadRight(56, '-'));
        Console.WriteLine("| " + "Joined Students with Specialties".PadBoth(52) + " |");
        Console.WriteLine("-".PadRight(56, '-'));
        Console.WriteLine("| " + "Name".PadBoth(20) + " | " + "FacNum" + " | " + "Specialty".PadBoth(20) + " |");
        Console.WriteLine("-".PadRight(56, '-'));
        foreach (var s in studentsWithSpecialties)
        {
            Console.Write("| " + s.FullName.PadRight(20));
            Console.Write(" | " + s.FacultyNumber);
            Console.Write(" | " + s.SpecialtyName.PadRight(20));
            Console.Write(" |\n");
        }

        Console.WriteLine("-".PadRight(56, '-') + "\n");
    }
}
