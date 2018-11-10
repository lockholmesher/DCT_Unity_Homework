using System;

namespace _20.So_sanh_hai_so
{
    class Program
    {
        static void Main(string[] args)
        {
            double a =0, b=0;
            Console.Write ("So sanh hai so");
            Console.Write(" So thu nhat: ");
            a=double.Parse(Console.ReadLine());
            Console.WriteLine("So thu hai:");
            b=double.Parse(Console.ReadLine());
            if ( a == b)
            {
                Console.WriteLine ("Hai so vua nhap bang nhau");
            };
            Console.WriteLine("Hai so vua nhap khong bang nhau");
            Console.ReadLine();
        }
    }
}
