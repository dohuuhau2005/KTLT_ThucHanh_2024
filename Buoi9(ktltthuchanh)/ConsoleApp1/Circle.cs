using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Circle:Shape
    {
        private double radius;
        public Circle()
        {

        }
        public  Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(string color, bool filled,double radius ) : base( color,  filled)
        {
            this.radius = radius;
        }
        public double Radius
        {
            set { 
              
                radius = value; }
            get
            {
                return this.radius;
            }
        }
        public override double getArea()
        {
            return (radius * radius)*3.14;
        }
        public override double getParameter()
        {
            return 2 * radius * 3.14;
        }
        public override string ToString()
        {
            return base.ToString() + $"Dien tich : {getArea()}      chu vi : {getParameter()}";
        }
    }
}
