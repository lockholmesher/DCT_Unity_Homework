using System;

namespace Bai_59
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tìm giai thừa của một số trong C#
            Console.WriteLine("Xin Moi Nhap So Can Tim Giai Thua: ");
            int so = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Giai Thua Cua {0} la: {1}",so , TInhGiaiThua(so));
        }
        static int TInhGiaiThua(int num){
             int sum = 1;
            for(int i = 2 ; i <= num ; i++){
                sum = sum*i;
            }
             return sum;
        }
    }
}
