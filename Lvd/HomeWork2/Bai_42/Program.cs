using System;

namespace Bai_42
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tính tổng dãy số trong C#
            Console.WriteLine("Day So Co Bao Nhieu Chu So: ");
            int lengt = Convert.ToInt32(Console.ReadLine());
            int[] mang = new int[lengt];
            for(int i = 0 ; i < lengt ; i++){
                 Console.WriteLine("Xin Moi Nhao So thu {0}" , i+1);
                mang[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Tong La {0} ",TinhTong(mang));
           
        }
        static int TinhTong(int[] mang){
            int tong = 0;
            for(int i = 0 ; i < mang.Length; i++ )
            {
                tong += mang[i];
            }
             return tong;
        }
    }
}
