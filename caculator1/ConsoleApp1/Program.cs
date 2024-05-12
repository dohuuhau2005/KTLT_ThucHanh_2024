namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Caculator a = new Caculator();
            Console.WriteLine(a.Add(1,2));
            Console.WriteLine(a.Add(1.4,4.5));
            Console.WriteLine(a.Subtract(4,5));
            Console.WriteLine(a.Subtract(5.6,7.8));
            Console.WriteLine(a.Multiply(9,4));
            Console.WriteLine(a.Multiply(9.3,4.6));
            Console.WriteLine(a.Divide(9,3));
            Console.WriteLine(a.Divide(9.5, 3.6));
            Console.WriteLine(a.Min(4,6));
            Console.WriteLine(a.Min(4.7, 6.7,7.8));
            Console.WriteLine(a.Min(4, 6, 8));
            Console.WriteLine(a.Max(4, 6));
            Console.WriteLine(a.Max(4.7, 6.7, 7.8));
            Console.WriteLine(a.Max(4, 6, 8));


        }
    }
}
