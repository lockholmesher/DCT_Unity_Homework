using System;

namespace Bai_70
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kiểm tra số nguyen to đối xứng (số Palindrome) trong C#
            Console.WriteLine("Xin Moi Nhap So Can Kiem Tra");
            int so = Convert.ToInt32(Console.ReadLine());

            if(KiemTraSoDoiXung(so) && KiemTraSoNguyenTo(so)){
                Console.WriteLine("So Tren La So nguyen to Palindrome");
            }else{
                Console.WriteLine("So Tren Khong Phai La So nguyen to Palindrome");
            }

        }
        static bool KiemTraSoDoiXung(int num){
            string arry ="";
            for(int i = num ; i>0 ; i/=10){
                int bienTam = i % 10;
                arry += bienTam.ToString();
            }
            int resu = Convert.ToInt32(arry);
            if(resu == num){
                return true;
            }
                return false;
            
        }
         static bool KiemTraSoNguyenTo(int so)
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
