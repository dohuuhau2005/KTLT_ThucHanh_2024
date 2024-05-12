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
            MixedFraction hs1 = new MixedFraction(1, 2, 3);
            Console.WriteLine("Hs1: " + hs1.ToString());
            Fraction k = new Fraction(8, 3);
            MixedFraction hs2 = new MixedFraction(f);
            Console.WriteLine("Hs2: " + hs2.ToString());

            MixedFraction tong = hs1 + hs2;
            Console.WriteLine("Tong: " + tong.ToString());
            MixedFraction hieu = hs1 - hs2;
            Console.WriteLine("Hieu: " + hieu.ToString());
            MixedFraction tich = hs1 * hs2;
            Console.WriteLine("Tich: " + tich.ToString());
            MixedFraction thuong = hs1 / hs2;
            Console.WriteLine("Thuong: " + thuong.ToString());

            bool bang = (hs1 == hs2);
            Console.WriteLine($"{hs1} = {hs2}: {bang}");
            bool khac = (hs1 != hs2);
            Console.WriteLine($"{hs1} != {hs2}: {khac}");
            bool lonhon = (hs1 > hs2);
            Console.WriteLine($"{hs1} > {hs2}: {lonhon}");
            bool nhohon = (hs1 < hs2);
            Console.WriteLine($"{hs1} < {hs2}: {nhohon}");
            bool lonhonbang = (hs1 >= hs2);
            Console.WriteLine($"{hs1} >= {hs2}: {lonhonbang}");
            bool nhohonbang = (hs1 <= hs2);
            Console.WriteLine($"{hs1} <= {hs2}: {nhohonbang}");


            Console.ReadKey();
        }
    }
}
