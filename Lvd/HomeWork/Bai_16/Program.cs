using System;

namespace Bai_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tìm diện tích và thể tích hình cầu trong C#
            Console.Write("Xin Moi Nhap Ban Kinh Hinh Cau: ");
            int r = Convert.ToInt32(Console.ReadLine());
            double v = (double) 4/3*3.14*r*r*r;
            double s = (double)4*3.14*r*r;
             Console.WriteLine("Dien Tich Hinh Cau: {0}", s);
             Console.WriteLine("The Tich Hinh Cau: {0}", v);
        }
    }
}
