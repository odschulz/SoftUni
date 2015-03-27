using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CompanyHierarchy
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            Employee randomEmployee = new Employee("John", "Doe", "AB123", 1500, Department.Sales);

            SalesEmployee salesEmployee = new SalesEmployee("Prodavach", "Prodavalnikov", "IC555", 2000);
            salesEmployee.AddSale(new Sale("Some Product", new DateTime(2015, 1, 30), 150));

            Manager manager = new Manager("Shev", "Nachalnikov", "AA111", 3000,
                Department.Sales, new List<IEmployee> { randomEmployee, salesEmployee });

            Developer developer = new Developer("Plague", "The Hacker", "LK799", 2500,
                new List<IProject>
                {
                    new Project("First Project", DateTime.Today, "Some details about the project", ProjectState.Open),
                    new Project("Second Project", DateTime.Now, "A second project that is less important", ProjectState.Open)
                });

            Customer customer = new Customer("Kupovach", "Balamurov", "PO889", 1000);

            var employeesList = new List<IEmployee>() 
            {
                randomEmployee, 
                salesEmployee, 
                manager, 
                developer
            };

            foreach (var employee in employeesList)
            {
                Console.WriteLine(employee.GetType().Name + ":\n" + employee + "\n");
            }

        }
    }
}
