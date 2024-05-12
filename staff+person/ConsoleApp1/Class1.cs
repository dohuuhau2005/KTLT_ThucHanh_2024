using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        string name;
        int birthYear;
        string address;
       public Person()
        {
            
        }
       public Person(string name, int birthYear, string address)
        {
            this.name = name;
            this.birthYear = birthYear; 
            this.address = address;
        }
        public virtual void input()
        {
            Console.Write("moi nhap ten: ");
            name = Console.ReadLine();
            Console.Write("moi nhap nam sinh: ");
            birthYear = int.Parse(Console.ReadLine());
            while (birthYear > DateTime.Now.Year || birthYear < 1900)
            {
                Console.Write("moi nhap nam sinh: ");
                birthYear = int.Parse(Console.ReadLine());
            }
            Console.Write("moi nhap dia chi: ");
            address = Console.ReadLine();
        }
        public int GetAge()
        {
            return DateTime.Now.Year-birthYear;
        }
        public override string ToString()
        {
            return $"Person[Name: {name}, Age: {GetAge()}, Address: {address}]";
        }

    }
}
