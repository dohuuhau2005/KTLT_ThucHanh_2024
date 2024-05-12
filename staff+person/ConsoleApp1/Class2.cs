using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student:Person
    {
        string program;
        int year; 
        public Student()
        {

        }
        public Student(string name, int birthYear, string address, string program, int year): base ( name, birthYear,  address)
        {
            this.program = program;
            this.year = year;
        }
        public override void input()
        {
            base.input();
            Console.Write("nhap chuong trinh hoc");
            program = Console.ReadLine();
            Console.Write("nhap nam hoc = ");
            year =Convert.ToInt32(Console.ReadLine());
            while (year<1980||year >DateTime.Now.Year)
            {
                Console.Write("nhap lai nam hoc = ");
                year=Convert.ToInt32(Console.ReadLine());
            }
        }
        public override string ToString()
        {
            return $"Student[{base.ToString()}, Program: {program}, Year: {year}]";
        }
        public void changeprogram()
        {
            Console.Write("nhap chuong trinh hoc");
            program = Console.ReadLine();
        }


    }
}
        
