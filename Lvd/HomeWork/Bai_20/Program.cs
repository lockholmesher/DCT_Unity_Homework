using System;

namespace Bai_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhập hai số và kiểm tra xem hai số đó có bằng nhau không trong C# 
            Console.WriteLine("Xin Moi Nhap so thu 1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Xin Moi Nhap so thu 2");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a==b)
            {
                Console.WriteLine("2 So Bang Nhau");
            }else if(a>b)
            {
                Console.WriteLine("{0} > {1}", a,b);
            }else
            {
                Console.WriteLine("{0} < {1}", a,b);
            }
        }
    }
}
