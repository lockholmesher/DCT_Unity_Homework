using System;

namespace Bai_62
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tính tổng dãy số 9 + 99 + 999 + ... trong C#
            
            
            Console.WriteLine("Xin Moi Nhap Day~ So: ");
            int tongBnSo = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Tong Cua Day So Tren La: {0}",TinhTongDaySo(tongBnSo));


        }
        static int TinhTongDaySo(int num){
            
            string a = "";
            int sum = 0;
           
            for(int i = 1 ; i <= num ; i++){
                a+="9";
                int c = Convert.ToInt32(a);
                sum+=c;

            }
            
            return sum;
        }
    }
}
