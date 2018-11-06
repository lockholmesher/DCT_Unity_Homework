using System;

namespace Bai_17
{
    class Program
    {
        static void Main(string[] args)
        {
           //Chương trình C# để kiểm tra một chữ cái thường nhập từ bàn phím là nguyên âm, chữ số hay ký tự khác
           Console.Write("Xin Moi Nhap Chu Cai: ");
           string a = Console.ReadLine();
           
           
           if(a == "a"|| a== "e" || a== "i" || a== "0"||a=="u"|| a=="y" )
           {
                Console.Write("{0} La Nguyen Am" , a);
           }else if(Convert.ToInt32(a) >=0 ||Convert.ToInt32(a) <0  )
           {
                Console.Write("{0} La Chu So",a);
           }else{
               Console.Write("{0} La Ky Tu Khac",a);
           }

        }
    }
}
