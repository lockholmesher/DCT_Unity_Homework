using System;

namespace _16.Dien_tic_the_tich_hinh_cau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Dien tich va the tich hinh cau");
            double radius=0, area =0, volume =0, pi = 3.14 ;
            Console.WriteLine(" Nhap ban kinh:");
            radius = double.Parse(Console.ReadLine());
            area=4*pi*radius*radius;
            volume=4*pi*radius*radius*radius/3;
            Console.WriteLine("Dien tich hinh cau la: {0}", area);
            Console.WriteLine("The tich hinh cau la: {0}", volume);
            Console.ReadLine();
        }
    }
}
