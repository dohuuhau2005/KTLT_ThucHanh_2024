using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Date
    {
        private int day;
        private int month;
        private int year;
        public  Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void setDate(int day, int month, int year)
        {          
            this.day=day;
            this.month = month;
            this.year = year;   
            while (day <1||day>31) 
            {
                Console.WriteLine("nhap lai ngay di :  ");
                this.day = Convert.ToInt32(Console.ReadLine());

            }
          
            while (month < 1 || month > 12)
            {
                Console.WriteLine("nhap lai month di :  ");
                this.month = Convert.ToInt32(Console.ReadLine());

            }
            
            while (year < 1900 || year > 9999)
            {
                Console.WriteLine("nhap lai year di :  ");
                this.year = Convert.ToInt32(Console.ReadLine());

            }
        }
        public string toString()
        {
            return $"{day}/{month}/{year}";
        }
        //properties
        public int Day
        {
            get { return day; }
            set {
                while (day < 1 || day > 31)
                {
                    Console.WriteLine("nhap lai day di :  ");
                    day = Convert.ToInt32(Console.ReadLine());

                }
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                while (month<1 || month > 12)
                {
                    Console.WriteLine("nhap lai month di :  ");
                    month = Convert.ToInt32(Console.ReadLine());

                }
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                while (year < 1900 || year > 9999)
                {
                    Console.WriteLine("nhap lai year di :  ");
                    day = Convert.ToInt32(Console.ReadLine());

                }
            }
        }
    }
}
