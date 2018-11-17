using System;

namespace bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            float numC;
            Console.WriteLine("Chuyển đổi độ C thành độ K và độ F trong C#");
            Console.WriteLine("moi ban nhap so do C: ");
            numC = Convert.ToInt32(Console.ReadLine());
            float numf = (float)(numC * 1,8)+ 32f;
            Console.WriteLine("ban vua nhap " + numC + "do C , tinh ra la :" +numf  + "dof" );
        }
    }
}
