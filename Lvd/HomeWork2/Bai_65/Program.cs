using System;

namespace Bai_65
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kiểm tra số armstrong trong C#
            Console.WriteLine("Xin Moi Nhap So Da Cho");
            int so = Convert.ToInt32(Console.ReadLine());
            if(KiemTraSo(so)){
                 Console.WriteLine("So armstrong");
            }else{
                 Console.WriteLine("Khong phai");
            }
        }
        static bool KiemTraSo(int num){

                int sum = 0;
            for(int i = num ; i >0 ; i /= 10)
            {
                int b = i%10;
                sum += b* b*b;
            }
            
            if(sum == num){
                return true;
            }else{
                return false;
            }
        }
    }
}
