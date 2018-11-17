using System;

namespace bai45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiểm tra số nguyên tố trong C#");
            int i;
            i = Convert.ToInt32(Console.ReadLine());
            Checki(i);
        }
        static int Checki(int i1){
            int n =0;
            for(int j = 1 ; j <= i1 ; j++){
                if((i1 % j) == 0){
                    n++;     
                }
                }
                if(n==2){
                    Console.WriteLine("so ban vua nhap la so nguyen to" +n);
                }
                else{
                    Console.WriteLine("so ban vua nhap khong phai so nguyen to");
                }
                
            /* 
                */
            return i1;
        }
    }
}
