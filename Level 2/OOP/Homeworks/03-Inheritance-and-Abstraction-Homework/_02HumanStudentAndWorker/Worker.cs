using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02HumanStudentAndWorker
{
    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                ValidationMethods.CheckIfZeroOrNegative("Week Salary", value);
                this.weekSalary = value;
            }
        }
        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                ValidationMethods.CheckIfZeroOrNegative("Work Hours Per Day", value);
                this.workHoursPerDay = value;
            }
        }
        public double MoneyPerHour()
        {
            return Math.Round((this.WeekSalary / 5 / this.WorkHoursPerDay), 2);
        }

        public override string ToString()
        {
            return base.ToString() + "\nWeekly Salary: " + this.WeekSalary + "\nWork Hours Per Day: " + this.WorkHoursPerDay;
        }
    }
}
