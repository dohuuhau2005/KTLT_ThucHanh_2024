using xepchong;

namespace napchong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fraction f1 = new fraction(1, 2);
            fraction f2 = new fraction(3,4);
            fraction sum2= f1+f2;
            Console.WriteLine(sum2 );
        }
    }
}
