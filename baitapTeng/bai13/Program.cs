using System;

namespace bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tìm chu vi và diện tích hình tròn trong C#");
            int bankinh;
            Console.WriteLine("moi ban nhap ban kinh");
            bankinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("chu vi hinh tron la {0}" , bankinh*bankinh*3.14f);
            Console.WriteLine("dien tich hinh tron la {0}" , bankinh*2*3.14f);

        }
    }
}
