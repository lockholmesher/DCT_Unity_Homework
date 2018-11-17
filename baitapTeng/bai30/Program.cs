using System;

namespace bai30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Giaipt();
        }
        static void Giaipt(){
            int a,b,c;
            Console.WriteLine("moi ban nhap a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("moi ban nhap b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("moi ban nhap b");
            c = Convert.ToInt32(Console.ReadLine());
           /* d = b*b - 4*a*c;
            x1 = (-b + Math.Sqrt(d)/2*a);
            x2 = (-b + Math.Sqrt(d)/2*a);
            if(d==0){
                 Console.WriteLine("phuong trinh co nghiem kep x1 = x2 = {0}" , -b / 2*a );
            }
            else if(d>0){
                Console.WriteLine("phuong trinh co nghiem kep x1 {0}" , x1);
                Console.WriteLine("phuong trinh co nghiem kep x1 {0}" , x2);
            }
                else{
                    Console.WriteLine("phuong trinh vo nghiem");
                }

                */
        }
        static int tinhnghiem(int _a , int _b , int _c ){
            int d;
            double x1,x2;
            d = _b*_b - 4*_a*_c;
            _x1 = (-_b + Math.Sqrt(d)/2*_a);
            _x2 = (_b + Math.Sqrt(d)/2*_a);

        }
    }
}
