using System;

namespace KiemTraMatKhau
{
    class Program
    {
        static void Main(string[] args)
        {
            string id = "lvd01092011";
            string pass = "passlvd";
           
            for(int i = 0 ; i <3 ; i++)
            {
            Console.WriteLine("Id: ");
            string a = Console.ReadLine();
            Console.WriteLine("Pass: ");
            string b = Console.ReadLine();
                if(a == id && b==pass)
                {
                    Console.Write("DangNhapThanhCong");
                    break;
                }else{
                    
                    
                    if(i == 2){
                        Console.Write("Ban Dang Nha Sai Qua nhieu lan ");
                    }else{
                        
                        Console.Write("DangNhapThatbai");
                        Console.WriteLine("Ban Con {0} Lan Nhap",3-i-1);
                    }
                }
            }
        }
    }
}
