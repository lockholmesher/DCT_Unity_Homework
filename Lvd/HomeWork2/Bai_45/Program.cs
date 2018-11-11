using System;

namespace Bai_45
{
    class Program
    {
        static void Main(string[] args)
        {
           //Kiểm tra số nguyên tố trong C#
           Console.WriteLine("Xin Moi Nhap So Can Kiem Tra: ");
           int a = Convert.ToInt32(Console.ReadLine());
           if( KiemTra(a)){
               Console.WriteLine("So Tren La So Nguyen To");
           }else{
               Console.WriteLine("So Tren La So Binh Thuong");
           }
          
        }
        static bool KiemTra(int so)
        {
             
           int count = 0;
           for(int i = 2; i <so ; i++)
           {
               if(so%i == 0){
                   count+= 1;
                   break;
               }
           }
           if(count == 0){
               return true;
           }else{
               return false;
           }
        }
    }
}
