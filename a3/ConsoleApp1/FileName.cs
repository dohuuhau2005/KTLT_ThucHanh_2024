using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        //attribute
        string studentId;
        string name;
        int birthYear;
        bool gender;
        string stdClass;
        public Student() { }
        public Student(string studentId, string name, int birthYear, bool gender, string stdClass)
        {
            this.studentId=studentId;
            this.name=name;
            this.birthYear=birthYear;
            int currentyear=DateTime.Now.Year;
            if (birthYear >=1990&&birthYear<=currentyear)
            {
                this.birthYear = birthYear;   
            }
            else
            {
                Console.WriteLine("nhap lai nam sinh di thg/con ngu :))");
                this.birthYear = 1990;
            }  
            this.gender = gender;   
            this. stdClass = stdClass;
            

        
        
        }
        //method
        public string getstudentID()
        {
            return studentId;
        }
        public void setstudentID(string newID)
        {
            this.studentId = newID;
        }
        public string Getname()
        {
            return name;
        }
    
    public void setgender(bool newgender)
    {
        this.gender = newgender;
    }
        public void setbirthyear(int newbirthYea)
        {
            this.birthYear = newbirthYea;
            int currentYear = DateTime.Now.Year;
            if (birthYear >= 1900 && birthYear <= currentYear)
            {
                this.birthYear = birthYear;
            }
            else
            {
                Console.WriteLine("nam sinh khong hop le!");
                this.birthYear = 1900;
            }
        }
        public void setstdclass(string newstdclass)
    {
        this.stdClass = newstdclass;
    }
    public void setname(string newname)
        { this.name = newname; }

        public void input()
        {
            Console.Write("nhap ma so sinh vien : ");
            studentId = Console.ReadLine();
            Console.Write("nhap ten : ");
            name = Console.ReadLine();     
           Console.Write("nhap nam sinh : ");
            birthYear=Convert.ToInt32(Console.ReadLine());
            int currentyear= DateTime.Now.Year;
            while (birthYear < 1900 || birthYear > currentyear)
            {
                Console.WriteLine("nam sinh khong hop le nhap lai : ");
                birthYear = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("nhap gioi tinh (true la nam va false la nu )");
            gender=bool.Parse(Console.ReadLine());
          
        }
        
        
        
        
        public void info() 
        {
            Console.WriteLine($"- ma so sinh vien : {studentId}");
            Console.WriteLine($"- Ten sinh vien : {name}");
            Console.WriteLine($"- ma so sinh vien : {birthYear}");
            if (gender=false)
            {
                Console.WriteLine("Gioi tinh : Lady");
            }
            else { Console.WriteLine("Gioi tinh : Gentle"); }

        }


    }




}
