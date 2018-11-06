using System;

namespace Bai_19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chương trình C# để chuyển đổi thập phân thành nhị phân
            Console.WriteLine("Xin Moi Nhap so Than Phan Theo Dinh Dang a/b ");
            Console.WriteLine("Xin Moi Nhap a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Xin Moi Nhap b ");
            int b = Convert.ToInt32(Console.ReadLine());
            float c = (float)a/b;
            Console.WriteLine("So Nhi Phan Cua {0}/{1} la: {2} ",a,b,c);
        }
    }
}
