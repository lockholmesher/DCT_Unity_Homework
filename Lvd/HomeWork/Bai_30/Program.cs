using System;

namespace Bai_30
{
    class Program
    {
        static void Main(string[] args)
        {
            //Giải phương trình bậc hai trong C#
            Console.WriteLine("ax^2 + bx + c = 0");
            Console.WriteLine("Xin Moi Nhap a: ");
            int a  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Xin Moi Nhap b: ");
            int b  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Xin Moi Nhap c: ");
            int c  = Convert.ToInt32(Console.ReadLine());

            int delta = b*b - 4*a*c;
                if(delta<0){
                    Console.WriteLine("Phuong Trinh Vo Nghiem");
                }else if(delta == 0){

                    Console.WriteLine("Phuong Trinh Co Nghiem Kep X1 = X2 = {0}", -b/(2*a));
                }else{
                        float x1 = (float)(-b + Math.Sqrt(delta))/(2*a); 
                        float x2 =(float)(-b - Math.Sqrt(delta))/(2*a); 
                    Console.WriteLine("Phuong Trinh Co 2 Nghiem Phan Biet: X1 = {0} , X2 = {1}",x1,x2);
                }



        }

    }
}
