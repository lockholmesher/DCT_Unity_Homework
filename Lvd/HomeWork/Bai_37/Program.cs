using System;
//OK
namespace Bai_37
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chương trình C# để nhập một số và hiển thị ngày trong tuần tương ứng
            Console.WriteLine("Xin Moi Nhap So :");
            string so = Console.ReadLine();
            switch(so){
                case "2" :
                Console.WriteLine("Thu 2");
                break;
                case "3" :
                Console.WriteLine("Thu 3");
                break;
                case "4" :
                Console.WriteLine("Thu 4");
                break;
                case "5" :
                Console.WriteLine("Thu 5");
                break;
                case "6" :
                Console.WriteLine("Thu 6");
                break;
                case "7" :
                Console.WriteLine("Thu 7");
                break;
                case "8" :
                Console.WriteLine("Chu Nhat");
                break;
                default: Console.WriteLine("Xin Moi Nhap Lai");
                break;
                
            }
        }
    }
}
