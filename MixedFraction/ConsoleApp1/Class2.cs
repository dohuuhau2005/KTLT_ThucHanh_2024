using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class math
    {
        public static int Euclid(int numerator, int denominator)
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
                return Euclid(denominator, numerator % denominator);
            }
        }

    }
}
