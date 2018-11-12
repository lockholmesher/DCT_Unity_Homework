using System;

namespace _28.Goc_Phan_Tu
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,y;
            Console.WriteLine(" Xac_dinh_goc_phan_tu");
            Console.WriteLine("Xin moi nhap hoanh do do: ");
            x= double.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap tung do: ");
            y= double.Parse(Console.ReadLine());
            Console.WriteLine ("Toa do cua A =({0},{1})",x,y);
            if (x>0&&y>0)
            {
                Console.WriteLine(" Diem A thuoc goc phan tu thu I");
            }
              if (x>0&&y<0)
            {
                Console.WriteLine(" Diem A thuoc goc phan tu thu II");
            }       
                if (x<0&&y<0)
            {
                Console.WriteLine(" Diem A thuoc goc phan tu thu III");
            }
              if (x<0&&y>0)
            {
                Console.WriteLine(" Diem A thuoc goc phan tu thu IV");
            }     
            Console.ReadLine();
        }
    }
}
