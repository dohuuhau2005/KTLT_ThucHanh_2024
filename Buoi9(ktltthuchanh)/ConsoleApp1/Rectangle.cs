using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Rectangle:Shape
    {
        protected double width;
        protected double length;
        public Rectangle()
        {

        }
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }
        public Rectangle(  string color,  bool filled,double width, double length ) :base(color, filled) 
        {
            this.width=width;
            this.length=length;
        }
        public double Width
        {
            set {
                //Console.Write("nhap width = ");
                //this.width = Convert.ToDouble(Console.ReadLine());
                width = value; }
            get { return this.width; }
        }
        public double Length
        {
            set
            {
                //Console.Write("nhap Length = ");
                //this.length = Convert.ToDouble(Console.ReadLine());
                 length = value ;
            }
            get { return this.length; }
        
        }
        public override double getArea()
        {
            return width * length;
        }
        public override double getParameter()
        {
            return (width + length) * 2;
        }
        public  override string ToString()
        {
            return base.ToString()+$"Dien tich : {getArea()}     chu vi : {getParameter()}";
        }
    }
}
