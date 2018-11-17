using System;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,tong;
            Console.WriteLine("moi ban nhap 2 so ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            tong = a + b;
            Console.WriteLine("Tong cua 2 so tren la : " + tong);
        }
    }
}
