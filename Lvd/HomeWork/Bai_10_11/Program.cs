using System;

namespace Bai_10_11
{
    class Program
    {
        static void Main(string[] args)
        {
           // Kiểm tra tên đăng nhập và mật khẩu 3 lan trong C# 
            string id = "lvd01092011";
            string pass = "passlvd";
           Console.WriteLine("Id: lvd01092011");
           Console.WriteLine("Pass: passlvd");
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
