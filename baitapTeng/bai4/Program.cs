using System;

namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("chuong trinh chao doi gia tri");
            Console.WriteLine("moi ban nhap 2 so a , b ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            swap(ref a,ref b);
            Console.WriteLine("sau khi swap {0} {1} " ,a,b);
        }
        static void swap(ref int a,ref int b ){
            int tg;
            tg = a;
            a = b;
            b = tg;
        }
    }
}
