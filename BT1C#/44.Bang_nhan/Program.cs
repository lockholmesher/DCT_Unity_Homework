using System;

namespace _44.Bang_nhan
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Chuong trinh in bang cuu chuong");
            num1 = 2;
            do
            {
             num2=1;
             do
             {
                 Console.WriteLine ("{0}x{1}={2}", num1,num2, num1*num2);
                 num2++;
             }
             while(num2<10);
            }
            while(num1<=9);
            Console.Key();

        }
    }
}
