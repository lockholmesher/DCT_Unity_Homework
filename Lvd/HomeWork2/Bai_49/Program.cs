using System;

namespace Bai_49
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hiển thị và tính tổng các số chẵn trong C#
            Console.WriteLine("Xin Moi Nhap Day~ Co 10 so: ");

             int[] mang = new int[10];
             for(int i =0 ; i< mang.Length; i++){
                Console.WriteLine("So Thu {0}: " , i+1);
                mang[i] = Convert.ToInt32(Console.ReadLine());
             }
                 
              

          Console.WriteLine("TOng Cac Phan Tu Chan Trong Mang Tren La {0}",TinhTong(mang));
        }
        static int TinhTong(int[] mang){
              int sum = 0;
            for(int i = 0 ; i <mang.Length ; i++){
               
                if(mang[i]%2 ==0){
                    sum += mang[i];
                }
            }
            
            
            return sum;
        }
    }
}
