using System;
//OK
namespace Bai_25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chương trình C# để nhập một số m, kiểm tra xem số đó là lớn hơn, nhỏ hơn hoặc bằng 0 và in ra giá trị tương ứng của một số n là 1, -1 hoặc 0
            Console.WriteLine("Nhap So Can Kiem Tra ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a<0)
            {   
                Console.WriteLine("So Tren La So Am n = -1");

            }else if(a==0)
            {
                     Console.WriteLine("So Tren La n = 0");
            }else
            {

                Console.WriteLine("So Tren La So Duong n >0 ");
            }
        }
    }
}
