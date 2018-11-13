using System;

namespace _32.Tam_giac
{
    class Program
    {
        static void Main(string[] args)
        {
            float x,y,z;
            nhap( out x, out y, out z);
            ket_qua(x,y,z);
        }
        static void nhap(out float x, out float y, out float z)
        {
            Console.WriteLine("Nhap canh X:");
            x=float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh Y:");
            y=float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh Z:");
            z=float.Parse(Console.ReadLine());
        }
        static void ket_qua (float x, float y, float z)
        {
            if (x+y<=z|| x+z <=y|| z+y<=x|| x<=0||y<=0||z<=0)
            Console.WriteLine(" Khong phai 3 canh cua tam giac");
            else

            {
                if (x==y&&x==z&&z==y)
                Console.WriteLine("Tam giac deu");
                else
                {
                    if (x==y||x==z||y==x)
                    Console.WriteLine(" Tam giac can");
                    else
                    Console.WriteLine("Tam giac thuong");
                }
            }
           Console.ReadLine();
        }

    } 

    
    
      

}
