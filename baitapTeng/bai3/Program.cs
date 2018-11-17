using System;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("cac phep toan co ban :");
            Console.WriteLine("moi ban nhap 2 so ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" a + b = {0} , a - b = {1} , a * b = {2} , a / b = {3} " , a+b,a-b,a*b,a/b);
        }
    }
}
