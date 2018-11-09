using System;
//OK
namespace Bai_26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chương trình C# để nhập chiều cao của một người và sau đó phân loại chiều cao của người đó
            Console.WriteLine("Nhap Chieu Cao Can Kiem Tra(cm) ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a<=150)
            {   
                Console.WriteLine("ban Qua Lun");

            }else if(a>150 && a < 165)
            {
                     Console.WriteLine("Chieu Cao Vua");
            }else if(a>=165 && a < 180)
            {

                Console.WriteLine("Chieu Cao Ly Tuong");
            }else
            {
                   Console.WriteLine("Ban Qua Cao");
            }
        
        }
    }
}
