using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Caculator
    {
        public Caculator()
        {

        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public double Subtract(double a, double b)
        {

            return a - b;

        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(int a, int b)
        {
            return (a / b);
        }
        public double Divide(double a, double b)
        {
            return (a / b);
        }
        public int Min(int a, int b)
        {
            int min = a;
            if (a < b)
            {
                return min;
            }
            else
            {
                return b;
            }
        }
        public int Min(int a, int b, int c)
        {

            return Math.Min(Min(a, b), c);
        }
        public double Min(double a, double b, double c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
        public int Max(int a, int b)
        {
            int max = a;
            if (a < b)
            {
                return b;
            }
            else
            {
                return max;
            }
        }
        public int Max(int a, int b, int c)
        {

            return Math.Max(Max(a, b), c);
        }
        public double Max(double a, double b, double c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
    }
}
