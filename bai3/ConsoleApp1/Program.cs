namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle();
            a.input();
            Console.WriteLine( a.GetPerimeter());
            Console.WriteLine(a.GetArea());
            Rectangle b = new Rectangle();
            b.input();
            Console.WriteLine(a.GetPerimeter());
            Console.WriteLine(a.GetArea());
            a.IsSameArea(b);
        }
    }
}
