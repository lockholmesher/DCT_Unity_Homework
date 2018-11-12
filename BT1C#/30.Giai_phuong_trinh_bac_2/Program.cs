using System;

namespace _30.Giai_phuong_trinh_bac_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,x;
            double delta, x1, x2;
            string ket_qua = " ";
            Console.WriteLine("Giai phuong trinh bac 2: ax2+bx+c=0");
            Console.WriteLine("Nhap vao so a: ");
            a=double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so b: ");
            b=double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so c: ");
            c=double.Parse(Console.ReadLine());
            if (a==0)
            {
                if( b==0&&c==0)
                {
                    ket_qua= "phuong trinh vo so nghiem" ;
                    Console.WriteLine("{0}", ket_qua);
                }
                if (b==0 && c!=0)
                {
                    ket_qua= "phuong trinh nghiem" ;
                    Console.WriteLine("{0}", ket_qua);
                }

                if (b!=0 && c!=0)
                {
                    ket_qua= "phuong trinh co nghiem";
                    x=-c/b;
                    Console.WriteLine("{0}, {1} ", ket_qua,x);                    
                }
            }
            delta=Math.Pow(b,2)-4*a*c;
            if(a!=0)
            {
               if (b!=0 && c!=0)
               {
                if (delta<0);
                {
                    ket_qua="Vo nghiem";
                }
                if (delta==0);
                {
                 ket_qua="Nghiem kep";
                 x=-b/2*a;
                 Console.WriteLine(" {0}, {1}", ket_qua, x);
                }
                if (delta>0);
                {
                 ket_qua = " Phuong trinh co nghiem x1, x2";
                 x1=(-b+Math.Sqrt(delta))/(2*a);
                 x2=(-b-Math.Sqrt(delta))/(2*a);  
                 Console.WriteLine("{0},{1},{2}", ket_qua, x1,x2);              
                }
               } 
            }
            Console.ReadLine();
        }
    }
}
