using System;

namespace _15.Van_toc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Tim van toc");
            double quang_duong =0, thoi_gian=0, van_toc =0;
            Console.WriteLine(" Moi ban nhap quang duong (Km):  ");
            quang_duong = double.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap thoi gian (h): ");
            thoi_gian = double.Parse(Console.ReadLine());
            van_toc=quang_duong/thoi_gian;
            Console.WriteLine(" Van toc (km/h)= {0}", van_toc);
            Console.ReadLine();
        }
    }
}
