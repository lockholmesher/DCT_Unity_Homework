using System;

namespace Bai_64
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kiem Tra So Hoan hao Trong 1 Day~ Da Cho
            Console.WriteLine("Xin Moi Nhap Day So Can Kiem Tra: ");
            Console.WriteLine("Start: ");
            int start = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("End: ");
            int end = Convert.ToInt32(Console.ReadLine());

            
            for(int j = start ; j<= end ; j++)
            {  
                if(KiemTraSoHoanhao(j)){
                     Console.WriteLine("{0} la So Hoan Hao",j);
                }
            
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
