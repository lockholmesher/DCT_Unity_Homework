using System;

namespace bai22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chương trình C# để kiểm tra số dương, số âm");
            int a;
            Console.WriteLine("moi ban nhap so");
            a = Convert.ToInt32(Console.ReadLine());
            if(a > 0 && a!=0){
                Console.WriteLine("so ban nhap la so duong");
            }
            else{
                Console.WriteLine("so ban nhap la so am");
            }
        }
    }
}
