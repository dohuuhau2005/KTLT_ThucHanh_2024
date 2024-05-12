namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fraction a = new Fraction(2,4);
            //a.simlyfi();
            //Console.WriteLine(a.Output());
            //Fraction a1 = new Fraction();
            //a1.input();
            //Console.WriteLine(a1.Output());
            //a.add(a1);
            //Console.WriteLine(a.Output());
            Fraction f = new Fraction();
            f.Denominator=0;
            Console.WriteLine(f.Denominator);
            Console.ReadKey();
        }
    }
}
