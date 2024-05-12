using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangle
    {
        private double width;
        private double height; 
        public void input()
        {
            Console.Write("nhap width = ");
            width=Convert.ToInt32(Console.ReadLine());
            int a = 0;
            while (width<=0) 
            {
                Console.WriteLine("nhap lai di >0 ");
                
                if (a == 1)
                { Console.WriteLine("nhap lai ma van sai ?? "); }
                if(a >= 2) { Console.WriteLine($"chan vay nhap tren {a} lan r van sai ??"); }
                width= Convert.ToInt32(Console.ReadLine());
                a++;
                //if (width > 0) { break; }
            }
            
            
            Console.Write("nhap height = ");
            height = Convert.ToInt32(Console.ReadLine());
            while (height <= 0)
            {
                Console.WriteLine("nhap lai di >0 ");

                if (a == 1)
                { Console.WriteLine("chi viec lam nhu tren thoi ma van sai?? "); }
                if (a >= 2) { Console.WriteLine($"chan vay nhap tren {a} lan r van sai ??"); }
                width = Convert.ToInt32(Console.ReadLine());
                a++;
                if (height > 0) { break; }
            }


        }
        public string ToString()
        {
            return $" width = {width},height = {height}";
        } 
        public double GetPerimeter()
        {
            return (width+height)*2;
        }
        public double GetArea()
        {
            return width*height;
        }
        public bool IsSameArea(Rectangle rect)
        {
            if (this.GetArea() == rect.GetArea())
            {
                Console.Write("same");
                return true;
            }
            else
            {
                Console.Write("not same");
                return false; }
        
        }


    }
}
