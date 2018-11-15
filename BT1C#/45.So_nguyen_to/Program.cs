using System;

namespace _45.So_nguyen_to
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Chuong trinh nhap vao mot so kiem tra ");
            int num;
            int counter =0;
            Console.WriteLine("Nhap vao so nguyen bat ky");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=num;i++)
             if(num%i==0)
             counter++;
             if (counter ==2) 
             Console.WriteLine(" So vua nhap la so nguyen to");
             else
             Console.WriteLine(" So vua nhap la hop so");
             Console.ReadLine();
        }
    }
}
