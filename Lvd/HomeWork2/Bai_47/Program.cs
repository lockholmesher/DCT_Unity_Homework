using System;

namespace Bai_47
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chương trình C# để in bảng nhân của một số bất kỳ
            Console.WriteLine("XIn Moi Nhap So Bang(1-9): ");
            int so = Convert.ToInt32(Console.ReadLine());
            InBangNhan(so);
           
        }
        static void InBangNhan(int so)
        {
             for(int i = 1 ; i<10 ; i++)
            {
                Console.WriteLine("{0} X {1} = {2}" , so , i , so*i);
            }
        }
    }
}
