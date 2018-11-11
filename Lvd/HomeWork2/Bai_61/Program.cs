using System;

namespace Bai_61
{
    class Program
    {
        static void Main(string[] args)
        {
           //Chương trình C# để tính tổng dãy số: 1/1 + 1/2 + 1/3 + 1/4 + ...
           Console.WriteLine("Xin Moi Nhap Day So:");
           int so = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Tong Cua Day So Tren La: {0}" , TinhTongDaySo(so));
        }
        static float TinhTongDaySo(int num){
            float tong = 0 ;
           for(int i = 1 ; i <= num ; i++){
               tong = tong + (float)1/(i);
           }
           return tong;
        }
    }
}
