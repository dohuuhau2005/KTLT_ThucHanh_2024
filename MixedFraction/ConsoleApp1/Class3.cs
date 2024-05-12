using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MixedFraction : Fraction
    {
        public MixedFraction(int wholePart, int numerator, int denominator)
        {
           Denominator = denominator;
            Numberator = wholePart * denominator + numerator;
        }
        public MixedFraction(Fraction f)
        {
            int new_Num=f.Numberator%f.Denominator;
            int whole = f.Numberator/f.Denominator;
        }
        public override string ToString()
        {
            int whole = Numberator / Denominator;
            int new_num = this.Numberator % Denominator;
            return $"{whole} [{new_num}/{Denominator}]";
        }
        public static MixedFraction operator +(MixedFraction a, MixedFraction b)
        {
            int new_numberator = a.Denominator * b.Numberator + a.Numberator * b.Denominator;
            int new_denominator = b.Denominator * a.Numberator;
            
            Fraction kq = new Fraction(new_numberator, new_denominator);
            return new MixedFraction(kq);
        }
        public static MixedFraction operator -(MixedFraction a, MixedFraction b)
        {
            int new_numberator = a.Denominator * b.Numberator - a.Numberator * b.Denominator;
            int new_denominator = b.Denominator * a.Denominator;
            Fraction kq = new Fraction(new_numberator, new_denominator);
            return new MixedFraction(kq);
        }
        public static MixedFraction operator *(MixedFraction a, MixedFraction b)
        {
            int new_numberator = a.Numberator * b.Denominator;
            int new_denominator = b.Denominator * a.Denominator;
            Fraction kq = new Fraction(new_numberator, new_denominator);
            return new MixedFraction(kq);
        }
        public static MixedFraction operator /(MixedFraction a, MixedFraction b)
        {
            int new_numberator = a.Numberator * b.Denominator;
            int new_denominator = b.Denominator * a.Numberator;
            Fraction kq = new Fraction(new_numberator, new_denominator);
            return new MixedFraction(kq);
        }
        public static MixedFraction operator -(MixedFraction a)
        {
            int new_numberator = -1 * a.Numberator;
            int new_denominator = a.Denominator;
            Fraction kq = new Fraction(new_numberator, new_denominator);
            return new MixedFraction(kq);
        }
        public static bool operator ==(MixedFraction a, MixedFraction b)
        {
            if (a.Numberator * b.Denominator == a.Denominator * b.Numberator) return true;
            else return false;
        }
        public static bool operator !=(MixedFraction a, MixedFraction b)
        {
            if (a.Numberator * b.Denominator == a.Denominator * b.Numberator) return false;
            else return true;
        }
        public static bool operator >(MixedFraction a, MixedFraction b)
        {
            if (a.Numberator * b.Denominator > a.Denominator * b.Numberator)
                return true;
            else
                return false;
        }
        public static bool operator <(MixedFraction a, MixedFraction b)
        {
            if (a.Numberator * b.Denominator < a.Denominator * b.Numberator)
                return true;
            else
                return false;
        }
        public static bool operator >=(MixedFraction a, MixedFraction b)
        {
            if (a.Numberator * b.Denominator >= a.Denominator * b.Numberator)
                return true;
            else
                return false;
        }
        public static bool operator <=(MixedFraction a, MixedFraction b)
        {
            if (a.Numberator * b.Denominator <= a.Denominator * b.Numberator)
                return true;
            else
                return false;
        }
    }
}
