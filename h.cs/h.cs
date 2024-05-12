namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhp so n ");
            int n = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(bai1(n));
            Console.ReadKey();

        }
        static int bai1(int n)
        {
            if (n <= 1) 
                return 1;
            else
                return n*bai1(n-1);
        }
    }
}    