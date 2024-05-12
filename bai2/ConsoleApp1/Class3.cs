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

    }
}
