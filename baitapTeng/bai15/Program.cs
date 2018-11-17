using System;

namespace bai15
{
    class Program
    {
        static void Main(string[] args)
        {
            int s,t;
            float ms,kmh,mileh;
            Console.WriteLine("Tìm vận tốc (m/s, km/h, mile/h) với quãng đường và thời gian nhập từ bàn phím trong C#");
            Console.WriteLine("moi ban nhap quang duong / m");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("moi ban nhap thoi gian / s ");
            t = Convert.ToInt32(Console.ReadLine());
            ms = (s/t)*1f;
            kmh =(s*1000)/(t*3600)*1f;
            mileh = ((s*1000*1.60934)/(t*3600))*1f;
            Console.WriteLine("van toc voi quang duong va thoi gian tren la" + ms + "m/s" + kmh + "km/h" + mileh + "mile/h" );
            
        }
    }
}
