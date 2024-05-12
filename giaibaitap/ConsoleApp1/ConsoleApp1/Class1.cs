using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Fraction
    {
        private int numberator;
        private int denominator;
        public Fraction() 
        { 
            numberator = 0;
            denominator = 1;
        
        }
        public Fraction(int numberator,int denominator)
        {
            this.numberator = numberator;
            if (denominator == 0)
            {
                Console.WriteLine("ko hop le nhap lai di");
                this.denominator = 1;
            }
            else
            { this.denominator = denominator; }
        }
        public Fraction(int numberator)
        {
            this.denominator = 1;
            this .numberator = numberator;
        }
        public string Output()
        {          
            return $"{numberator}/{denominator}";
        }
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set {
                if (value == 0)
                {
                    Console.WriteLine("ko hop le nhap lai di");
                    value = 1;
                }
                else
                { denominator = value; }
            }
        
        }
        public void simlyfi()
        {
            int gcd = math.Euclid(numberator, denominator);
            this.numberator = numberator / gcd;
            this.denominator = denominator / gcd;
        }
        public void input()
        {
            Console.Write("nhap tu = ");
            numberator=Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap mau = ");
            denominator = Convert.ToInt32(Console.ReadLine());
        }
        public void add(Fraction a)
        {
            this.numberator = a.denominator * this.numberator + a.numberator * this.denominator;
            this.denominator= this.denominator*a.denominator;
            simlyfi();
        }
        public void subtract(Fraction a)
        {
            this.numberator = a.denominator * this.numberator - a.numberator * this.denominator;
            this.denominator = this.denominator * a.denominator;
            simlyfi();  
        }
        public void Multiply(Fraction a)
        {
            this.numberator =a.numberator*this.numberator;
            this.denominator = a.denominator*this.denominator;
            simlyfi() ;
        }
        public void Divide(Fraction a)
        {
            this.numberator = a.numberator * this.denominator;
            this.denominator = a.denominator * this.numberator;
            simlyfi();
        }

    }
}
