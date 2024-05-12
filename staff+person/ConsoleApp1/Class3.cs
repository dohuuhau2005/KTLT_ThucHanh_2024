using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktlr_buoi_6
{
    internal class Staff : Person
    {
        private string department;
        private double salary;
        public Staff() { }

        public Staff(string name, int birthYear, string address, string department, double salary)
            : base(name, birthYear, address)
        {
            this.department = department;
            this.salary = salary;
        }

        public new void input()
        {
            base.input();
            Console.Write("ban: ");
            department = Console.ReadLine();
            Console.Write("luong: ");
            salary = double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Staff[{base.ToString()} - Department: {department}, Salary: {salary}]";
        }
        public void UpdateSalary(double salary)
        {
            this.salary = salary;
        }

    }
}