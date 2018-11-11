using System;

namespace Bai_63
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kiểm tra số hoàn hảo trong C#
            Console.WriteLine("Xin Moi Nhap  So Can Kiem Tra: ");
            int so  = Convert.ToInt32(Console.ReadLine());

            
           
              if(KiemTraSoHoanhao(so)){
                  Console.WriteLine("Hoan Hao ");
              }else{
                  Console.WriteLine("binh Thuong");
              }
            
            
            
            
        }
        static bool KiemTraSoHoanhao(int num){
               int tong = 0;
                for(int i = 1 ; i<=num/2 ; i++ )
                {
                    if(num % i ==0)
                    {
                    tong+=i;
                    }
                }
                if(tong == num)
                {
                   return true;
                }else
                {
                    return false;
                }
        }
    }
}
