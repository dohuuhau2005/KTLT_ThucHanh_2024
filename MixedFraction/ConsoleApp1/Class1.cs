using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        //constructors
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
       
        //properties
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
        public int Numberator
        {
            get
            {
                return numberator;
            }
            set
            {
                 numberator=value;
            }
        }
        //method
        public string Output()
        {
            return $"{numberator}/{denominator}";
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
        public static Fraction operator +(Fraction a, Fraction b)
        {
            int new_numberator = a.denominator * b.numberator + a.numberator * b.denominator;
            int new_denominator = b.denominator * a.denominator;
            Fraction kq = new Fraction(new_numberator, new_denominator);
            return kq;
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            int new_numberator = a.denominator * b.numberator - a.numberator * b.denominator;
            int new_denominator = b.denominator * a.denominator;
            Fraction kq = new Fraction(new_numberator, new_denominator);
            return kq;
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            int new_numberator = a.numberator * b.numberator;
            int new_denominator = b.denominator * a.denominator;
            Fraction kq = new Fraction(new_numberator, new_denominator);
            return kq;
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            int new_numberator = a.numberator * b.denominator;
            int new_denominator = b.denominator * a.numberator;
            Fraction kq = new Fraction(new_numberator, new_denominator);
            return kq;
        }
        public static Fraction operator -(Fraction a)
        {
            int new_numberator = -1 * a.numberator;
            int new_denominator = a.denominator;
            Fraction kq = new Fraction(new_numberator, new_denominator);
            return kq;
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            if (a.numberator*b.denominator == a.denominator*b.Numberator) return true;
            else return false;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            if (a.numberator * b.denominator == a.denominator * b.Numberator) return false;
            else return true;
        }
        public static bool operator >(Fraction a, Fraction b)
        {
            if (a.numberator * b.denominator > a.denominator * b.Numberator) 
                 return true;
            else
                return false;
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            if (a.numberator * b.denominator < a.denominator * b.Numberator)
                return true;
            else
                return false;
        }
        public static bool operator >=(Fraction a, Fraction b)
        {
            if (a.numberator * b.denominator >= a.denominator * b.Numberator)
                return true;
            else
                return false;
        }
        public static bool operator <=(Fraction a, Fraction b)
        {
            if (a.numberator * b.denominator <= a.denominator * b.Numberator)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return  $"{numberator}/{denominator}";
        }
        public static Fraction Add(Fraction a, Fraction b)
        {
            int new_numberator = a.denominator * b.numberator + a.numberator * b.denominator;
            int new_denominator = b.denominator * a.denominator;
            Fraction kq = new Fraction(new_numberator, new_denominator);
            return kq;
        }
        public static Fraction Subtract(Fraction a, Fraction b)
        {
            int new_numberator = a.denominator * b.numberator - a.numberator * b.denominator;
            int new_denominator = b.denominator * a.denominator;
            Fraction kq = new Fraction(new_numberator, new_denominator);
            return kq;
        }
        public static Fraction Multiply(Fraction a, Fraction b)
        {
            int new_numberator = a.numberator * b.numberator;
            int new_denominator = b.denominator * a.denominator;
            Fraction kq = new Fraction(new_numberator, new_denominator);
            return kq;
        }
        public static Fraction Divive(Fraction a, Fraction b)
        {
            int new_numberator = a.numberator * b.denominator;
            int new_denominator = b.denominator * a.numberator;
            Fraction kq = new Fraction(new_numberator, new_denominator);
            return kq;
        }

    }
}
