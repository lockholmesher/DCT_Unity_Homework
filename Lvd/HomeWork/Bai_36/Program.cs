using System;

namespace Bai_36
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chương trình C# để nhập hạng (ví dụ: A, B, C, ...) và hiển thị miêu tả tương ứng
            Console.WriteLine("Xin Moi Nhap hang: ");
            string hang = Console.ReadLine();
            switch(hang){
                case "a":
                Console.WriteLine("Xuat Sac");
                break;
                case "b":
                Console.WriteLine("Gioi");
                break;
                case "c":
                Console.WriteLine("Kha");
                break;
                case "d":
                Console.WriteLine("Trung Binh");
                break;
                case "e":
                Console.WriteLine("Yeu");
                break;
            }
        }
    }
}
