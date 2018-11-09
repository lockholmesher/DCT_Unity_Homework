using System;
//OK
namespace Bai_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chương trình C# để kiểm tra số dương, số âm
            Console.WriteLine("Nhap So Can Kiem Tra ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a<0)
            {   
                Console.WriteLine("So Tren La So Am");

            }else if(a==0)
            {
                     Console.WriteLine("So Tren La 0");
            }else
            {

                Console.WriteLine("So Tren La So Duong");
            }
        }
    }
}
