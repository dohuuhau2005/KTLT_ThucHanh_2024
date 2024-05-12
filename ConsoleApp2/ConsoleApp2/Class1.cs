using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xepchong
{
    internal class fraction
    {
        int numberator;
        int denominator;
        public fraction(int numberator, int denominator)
        {
            int g=math.GCD(this.numberator, numberator);    
            this.numberator = numberator/g;
            this.denominator = denominator/g;
        }
        //operator overloading
        public static fraction operator + (fraction a, fraction b)
        {
            int n = a.numberator + b.denominator + a.denominator * b.numberator;
            int d = a.denominator *b .numberator;
            return new fraction(n, d);
        }
    
    
    }
}
