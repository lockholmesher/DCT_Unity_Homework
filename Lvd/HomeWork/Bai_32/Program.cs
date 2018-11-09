using System;

namespace Bai_32
{
    class Program
    {
        static void Main(string[] args)
        {
           //Kiểm tra tam giác đều, cân, lệch trong C#
           Console.WriteLine("Xin Moi Nhap Canh a: ");
           int a = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Xin Moi Nhap Canh b: ");
           int b = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Xin Moi Nhap Canh c: ");
           int c = Convert.ToInt32(Console.ReadLine());
           if(a== b || a==c  || c==b){

                if(a== b && a==c && c==b){
                    Console.WriteLine("Tam Giac Tren La Tam GIac Can");
               }else{
              
                   Console.WriteLine("Tam Giac Tren La Tam GIac Deu");
               }
           }
           else {
               Console.WriteLine("Tam Giac Tren La Tam GIac Lech");
           }
        }
    }
}
