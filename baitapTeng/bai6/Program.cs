using System;

namespace bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d;
            Console.WriteLine("tim gia tri trung binh");
            Console.WriteLine("moi ban nhap 4 so :");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            float f = (a+b+c+d)/4f;
            Console.WriteLine("trung binh cua 4 so tren la :" +f);


        }
    }
}
