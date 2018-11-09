using System;
//Lập trình cần sự chính xác nên dùng Math.Pi thay cho 3.14
namespace Bai_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tìm chu vi và diện tích hình tròn trong C#
            Console.WriteLine("Xin Moi Nhap Ban Kinh Hinh Tron: ");
            int r = Convert.ToInt32(Console.ReadLine());
            double chuVi = (double)2*r*3.14;
            double dienTich = (double)r*r*3.14;

            Console.WriteLine("Chu VI La : {0} ",chuVi);
            Console.WriteLine("Dien Tich La : {0} ",dienTich);

        }
    }
}
