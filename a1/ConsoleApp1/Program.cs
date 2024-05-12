namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            int t=tong(x,y);
            Console.WriteLine(t);
            Console.Write("nhap so n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            bai5(n);
        }
        static int tong(int x, int y)
        {
            return x + y;
        }
        static void hoandoi(ref int x, ref int y)
        {
            int a = x;
            x = y;
            y = a;
        }
        static void bai3(double x, double y)
        {
            Console.WriteLine("tong = "+(x+y));
            Console.WriteLine("tru = " + (x - y));
            Console.WriteLine("nhan = " + (x * y));
            double k = x / y;
            Console.WriteLine("chia = " + k);
        }
        static void bai4(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (i % 2 ==0)
                {
                    int r = i * i;
                    Console.WriteLine(r);
                }
            }
        }
        static void bai5(int n)
        {
            int i;
            int s = 0;
            for (i = 1; i <= n; i++)
            {
                s = s + i;
                while (s >= n)
                {
                    s = s - i;
                }
            }
            Console.WriteLine(s);
        }
        static void bai6(int n)
        {
            int s = 0;
            while (n>0)
            {
                int k = n % 10;
                 s = k + s;
                n = n / 10;
            }
            Console.WriteLine(s);
        }
        static void bai7 (double n)
        {
            double i = 1; double s = 0;
            for(; i <= n; i++)
            {
                s= s + i;
           
            }
            double t = s / n;
        Console.Write("tong = "+s);
        Console.Write("trung binh cong = "+t);
        }
        static void bai8 (int n)
        {   int s = 0;
            int[] a = new int[n];
            int i = 0;
            int max = 0;
            while (n>0)
            {
                int r = n % 10;
                a[i]= r;
                n = n / 10;
                i++;
            }
            for (int j =1; j < a.Length; j++)
            {
                 max = a[0];
                if (max > a[j])
                    max = a[j];
            }
    Console.WriteLine(max);
        }
    }
}
