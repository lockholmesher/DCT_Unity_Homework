using System;

namespace _13.Area_Per
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh tinh chu vi va dien tich hinh trong");
            Double radius=0, area =0, per =0, pi =3.14;
            Console.WriteLine ("Nhap vap ban kinh radius = ");
            radius = double.Parse(Console.ReadLine());
            area = radius*radius*pi;
            per  = 2*pi*radius;
            Console.WriteLine (" Dien tich {0}", area);
            Console.WriteLine (" Chu vi {0}", per);
            Console.ReadLine();
        }
    }
}
