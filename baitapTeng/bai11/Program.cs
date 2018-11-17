using System;

namespace bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chương trình C# để kiểm tra tên đăng nhập và mật khẩu, và nếu nhập tên và mật khẩu sai quá 3 lần thì in thông báo lỗi");
            string a,b;
            int i = 0;
            string tendangnhap = "sapaloha";
            string password = "At123456";
            Console.WriteLine("nhap tean dang nhap :");
            a = Console.ReadLine();
            Console.WriteLine("nhap mat khau :");
            b = Console.ReadLine();
        if(a == tendangnhap && b == password && i < 3){
            Console.WriteLine("dang nhap thanh cong !");
            return;
        }
        else{
            Console.WriteLine("dang nhap that bai!");
             Console.WriteLine("nhap tean dang nhap :");
            a = Console.ReadLine();
            Console.WriteLine("nhap mat khau :");
            b = Console.ReadLine();
            i+=1;
        }
        }
    }
}
