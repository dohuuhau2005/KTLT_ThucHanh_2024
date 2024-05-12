using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so nguyen n ");
            int n = Convert.ToInt32(Console.ReadLine());
            //int[] a = new int[n];
            Console.Write("nhap so nguyen m ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] b = new int[n, m];
            input2(b);

            cau5(b);
        }
        static void input2(int[,] b)
        {
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"b[{i},{j}] = ");
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static void input(int[] a)

        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void cau1(int[] a)
        {
            Console.Write("nhap so x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            int vitri = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    vitri = i;
                    break;

                }
            }
            Console.Write("vi tri la = " + vitri);
        }
        static void cau2(int[] a)
        {
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    dem++;
                }

            }
            Console.Write("so phan tu la = " + dem);
        }
        static void cau3(int[,] b)
        {
            Console.Write("k = ");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k >= b.GetLength(0))
            {
                Console.WriteLine("invalid k ");
            }
            for (int i = 0; i < b.GetLength(1); i++)
            {
                Console.Write(" " + b[k, i]);
            }
        }
        static void cau4(int[,] b)
        {
            int dem = 0;
            int tongcotk = 0;
            int tongchan = 0;
            Console.Write("nhap k = ");
            int k = Convert.ToInt32(Console.ReadLine());
            double tong = 0;
            double r;
            for (int i = 0; i < b.GetLength(0); i++)
            {
                tongcotk += b[i, k];
                for (int j = 0; j < b.GetLength(1); j++)
                {



                    tong += b[i, j];
                    if (b[i, j] % 2 == 0)
                    {
                        tongchan += b[i, j];
                    }
                    dem++;
                }
            }
            r = tong / dem;
            Console.WriteLine("tong cac phan tu tren cot k = " + tongcotk);
            Console.WriteLine("tong cac phan tu = " + tong);
            Console.WriteLine("tong so phan tu chan = " + tongchan);
            Console.WriteLine("gia tri trung binh =  " + r);


        }
        static void cau5(int[,] b)
        {
            for (int i = 0; i < b.GetLength(0); i++)
            {

                {
                    Console.Write(" " + b[i, i]);
                }
            }

        }
    }
}

