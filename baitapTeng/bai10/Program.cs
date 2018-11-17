using System;

namespace bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiểm tra tên đăng nhập và mật khẩu trong C#");
            string a,b;
            string tendangnhap = "sapaloha";
            string password = "At123456";
            Console.WriteLine("nhap tean dang nhap :");
            a = Console.ReadLine();
            Console.WriteLine("nhap mat khau :");
            b = Console.ReadLine();

        if(a == tendangnhap && b == password){
            Console.WriteLine("dang nhap thanh cong !");
        }
        else{
            Console.WriteLine("dang nhap that bai!");
        }

        }
    }
}