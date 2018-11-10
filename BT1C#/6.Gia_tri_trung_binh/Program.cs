using System;

namespace _6.Gia_tri_trung_binh
{
    class Program
    {
        static void Main(string[] args)
        {
          int a=0,b=0,c=0,d=0, e =0;
          Console.WriteLine("Chuong trinh tinh gia tri trung binh bon so: ");
          Console.WriteLine("Nhap vao a :");
          a= Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Nhap vao b :");
          b= Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Nhap vao c :");
          c= Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Nhap vao d :");
          d= Convert.ToInt32(Console.ReadLine());
          e=(a+b+c+d)/4;
          Console.WriteLine("Gia tri trung binh bon so la: {0}", e);
          Console.ReadLine();
        }
    }
}
