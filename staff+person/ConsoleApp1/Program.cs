using ktlr_buoi_6;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person();
            a.input();
            a.ToString();
            Student b = new Student();
            b.input();
            b.ToString();
            Staff c = new Staff();
            c.input();
            c.ToString();
            Console.ReadKey();
        }
    }
}
