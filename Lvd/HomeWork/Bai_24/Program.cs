using System;
//OK
namespace Bai_24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chương trình C# để nhập tuổi của một người, kiểm tra và thông báo xem người đó có đủ độ tuổi bầu cử không.
            Console.WriteLine("Xin Moi Nhap So Tuoi ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a >=18)
            {
                Console.WriteLine("Nguoi Do Du tuoi Bau Cu");
            }else
            {
                Console.WriteLine("Nguoi Do Khong tuoi Bau Cu");
            }
        }
    }
}
