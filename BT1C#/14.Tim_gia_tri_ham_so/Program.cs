using System;

namespace _14.Tim_gia_tri_ham_so
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chương trình C# để tìm giá trị cụ thể của một hàm số với dãy giá trị của biến!");
            int x, y ;
            Console.WriteLine("Ham so  y= x*x -1");
            Console.WriteLine(" Voi -2=<x<+2");
            for (x=-2 ; x<=2 ; x++)
            {
                y=x*x-1;
                Console.WriteLine(" x= {0}, y = {0}*{0}-1 = {1},", x,y );
            }
            Console.ReadLine();

        }
    }
}
