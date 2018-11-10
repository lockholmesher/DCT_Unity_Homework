using System;

namespace _21.Kiem_tra_am_duong
{
    class Program
    {
        static void Main(string[] args)
        {
            double a =0;
            Console.WriteLine(" Chuong trinh nhap vao mot so kiem tra so am hay so duong");
            Console.WriteLine(" Nhap vao so a: ");
            a= double.Parse(Console.WriteLine());
            if ( a>0)
            {
                Console.WriteLine("So vua nhap la so duong");
            }
            else
            {
            Console.WriteLine("So vua nhap la so am");
            }
            Console.ReadLine();
        }
    }
}
