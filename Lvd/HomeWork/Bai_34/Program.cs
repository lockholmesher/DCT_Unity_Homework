using System;
//Xem lại cách dùng switch cass
namespace Bai_34
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kiểm tra nguyên âm, phụ âm trong C#
            Console.Write("Xin Moi Nhap Chu Cai: ");
           string a = Console.ReadLine();
           
           
           if(a == "a"|| a== "e" || a== "i" || a== "0"||a=="u" )
           {
                Console.Write("{0} La Nguyen Am" , a);
           }else 
           {
                Console.Write("{0} La Phu Am",a);
           }
        }
    }
}
