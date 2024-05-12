using ConsoleApp1;

namespace bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sv1");
            //cach 1
            Student sv1 = new Student("23dh11111", "Nguyen Van A", 2070, true, "103");
            sv1.info();
            Console.WriteLine();
            Console.WriteLine("sv2");
            //cach 2
            Student sv2 = new Student();
            sv2.setstudentID("23dh2222");
            sv2.setname("Nguyen Van B");
            sv2.setbirthyear(1800);
            sv2.setgender(false);
            sv2.setstdclass("105");
            sv2.info();
            Console.WriteLine();
            Console.WriteLine("sv3");
            //cach 3
            Student sv3 = new Student();
            sv3.input();
            Console.WriteLine();
            sv3.info();
            Console.ReadLine();
            
        }
    }
}