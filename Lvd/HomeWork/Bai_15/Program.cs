using System;

namespace Bai_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tìm vận tốc (m/s, km/h, mile/h) với quãng đường và thời gian nhập từ bàn phím trong C#
            Console.WriteLine("Quang Duong (km): ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thoi Gian (h): ");
            int t = Convert.ToInt32(Console.ReadLine());
            float a = (float)(s*1000)/(t*3600);
            float b = (float)(s)/(t);
            float c = (float)(s/1.609)/(t);
            Console.WriteLine(" Van Toc m/s: {0}", a);
            Console.WriteLine(" Van Toc km/h: {0}",b);
            Console.WriteLine(" Van Toc mile/h: {0}",c);


        }
    }
}
