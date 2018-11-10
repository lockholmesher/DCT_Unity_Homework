using System;

namespace _4.Trao_doi_gia_tri
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=0, b=0, c=0;
            Console.WriteLine("Chuong trinh tinh tong hai so");
            Console.WriteLine ("Nhap a=");
            a=double.Parse(Console.ReadLine());
            Console.WriteLine ("Nhap b=");
            b=double.Parse(Console.ReadLine());
            c=a;
            a=b;
            b=c;
            Console.WriteLine("Gia tri sau khi trao doi:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.ReadLine();

        }
    }
}
