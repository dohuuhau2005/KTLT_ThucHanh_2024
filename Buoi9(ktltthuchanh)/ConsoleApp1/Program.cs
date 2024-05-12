namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle();
            a.Length = 10;
            a.Width = 10;
            a.getParameter();
            a.getArea();
            a.Color = "red";
            Console.WriteLine(a.ToString());
        }
    }
}
