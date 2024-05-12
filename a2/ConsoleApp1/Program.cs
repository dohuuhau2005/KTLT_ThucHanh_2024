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
            Console.WriteLine(bai3(a,n));
            Console.ReadKey();

        }
        static int bai1(int n)
        {
            if (n <= 1) 
                return 1;
            else
                return n*bai1(n-1);
        }
        static int bai2(int a , int n)
        {
            if (n == 0)
                return 1;
            else if (n % 2 == 0)
                return bai2(a, n / 2) * bai2(a, n / 2);
            else
                return a * bai2(a, (n - 1) / 2) * bai2(a, (n - 1) / 2);
        }
        static int bai3(int m , int n)
        {
            if (n==0)
                return m;
             else
                return bai3(n, m % n);                          
        }
        static string bai4(int n)
        {
            if (n == 0)
                return "0";
           else if (n == 1)
                return "0";
            else
            {
                int phandu = n % 2;
                int phannguyen=n/ 2;    
                return bai4(phannguyen) + phandu.ToString();
            }
            
        }
        static int bai5(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return bai5(n - 1) + bai5(n - 2);
        }
    }
}
