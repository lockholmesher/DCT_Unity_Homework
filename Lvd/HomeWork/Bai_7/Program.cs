using System;

//OK

namespace Bai_7
{
    class Program
    {
        static void Main(string[] args)
        {
           //Chuyển đổi độ C thành độ K và độ F trong C#
           Console.Write("Xin Moi Nhap Do C: ");
           int C = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Do K la: {0} ", C + 273.15);
           Console.WriteLine("Do F la: {0} ", (C *1.8)+32);
        }
    }
}
