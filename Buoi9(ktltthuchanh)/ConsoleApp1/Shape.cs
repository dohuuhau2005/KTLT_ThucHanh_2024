using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal abstract class Shape
    {
        private string color;
        private bool filled;
        public Shape()
        {

        }
        public Shape( string color, bool filled)
        {
            this.color = color; this.filled = filled;
        }
        public string Color
        {
            set
            {
                //string color = Console.ReadLine();
                color = value;
            }
            get
            {
                return color;
            }
        }
        public bool Filled
        {
            set
            {

            }
            get
            {
                return filled;
            }
        }
        public abstract double getArea();//phuong thuc truu tuong

        public abstract double getParameter();
       
        public override string ToString()
        {
            return $"color:{color}     filled : {filled}";
        }
    }
}
