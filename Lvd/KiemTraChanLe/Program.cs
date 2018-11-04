using System;

namespace KiemTraChanLe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so can kiem tra: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a%2;
            if(b==0)
            {
                Console.WriteLine("So Chan");
            }else{
                Console.WriteLine("Le");
            }
        }
    }
}
