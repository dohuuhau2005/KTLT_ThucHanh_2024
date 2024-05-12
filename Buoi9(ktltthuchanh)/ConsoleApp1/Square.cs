using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Square:Rectangle
    {
        double side;
        public Square()
        {

        }
        public Square(double side)
        {
            this.side = side;
        }
        public Square(double side,string color,bool filled) : base(color, filled,side,side)
        {
            
        }
        public double Side
        {
            set
            {
              
               side = value;
            }
            get { return this.side; }
        }
        public override double getArea()
        {
            return Side * Side;
        }
        public override double getParameter()
        {
            return (Side+Side)*2;
        }
    }
}
