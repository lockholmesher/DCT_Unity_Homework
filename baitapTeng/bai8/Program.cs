using System;

namespace bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            string a,b,c;
            Console.WriteLine("Nhập 3 chữ cái và hiển thị theo chiều ngược lại trong C#.");
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            Console.WriteLine("ban vua nhap {0} , {1} , {2} , nguoc lai la {2} , {1}, {0}" ,a,b,c);
        }
    }
}
