using System;

namespace bai20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kiểm tra xem hai số đó có bằng nhau không trong C#");
            chanle();
        }
        static void chanle(){
            int a,b;
            Console.WriteLine("kiểm tra hai so bang nhau hay khong ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if(a==b){
                Console.WriteLine("hai so ban vua nhap bang nhau ");
            }
            else{
                Console.WriteLine("hai so ban vua nhap khac nhau ");
            }
        }
    }
}
