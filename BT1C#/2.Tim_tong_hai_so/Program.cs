using System;

namespace _2.Tim_tong_hai_so
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=0, b=0, tong=0;
            Console.WriteLine("Chuong trinh tinh tong hai so");
            Console.WriteLine ("Nhap a=");
            a=double.Parse(Console.ReadLine());
            Console.WriteLine ("Nhap b=");
            b=double.Parse(Console.ReadLine());
            tong=a+b;
            Console.WriteLine("Tong a va b la: {0}", tong);
            Console.ReadLine();

        }
    }
}
