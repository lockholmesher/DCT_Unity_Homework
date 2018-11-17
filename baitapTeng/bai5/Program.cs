using System;

namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("in ra bang cuu chuong cua 1 so :");
            Console.WriteLine("moi ban nhap so :");
            a = Convert.ToInt32(Console.ReadLine());
            for(int i = 0 ; i <= 10 ; i++){
                Console.WriteLine(a + "*" + i + "=" + a*i);
            }
            
        }
    }
}
