using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class math
    {
         public  static int GCD(int numerator, int denominator)
        {
            if (denominator > numerator)
            {
                int temp = numerator;
                numerator = denominator;
                denominator = temp;
            }
            if (denominator == 0)
            {
                return numerator;
            }
            else
            {
                return GCD(denominator, numerator % denominator);
            }
        }
    
    }
}
