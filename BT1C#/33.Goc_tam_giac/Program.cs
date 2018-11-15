using System;

namespace _33.Goc_tam_giac
{
    class Program
    {
        static void Main(string[] args)
        {
            float x,y,z;
            nhap( out x, out y, out z);
            ket_qua(x,y,z);
        }
        static void nhap (out float x, out float y, out float z )
        {
            Console.WriteLine("goc X:");
            x=float.Parse(Console.ReadLine());
            Console.WriteLine("goc Y :");
            y=float.Parse(Console.ReadLine());
            Console.WriteLine("goc Z:");
            z=float.Parse(Console.ReadLine());
        }
        static void ket_qua (float x, float y, float z)
        {
         if ((x+y+z)==180)
         Console.WriteLine("La ba goc tam giac");
         else Console.WriteLine (" Khong phai la ba goc cua tam giac");
          Console.ReadLine();
        }
    }
}
