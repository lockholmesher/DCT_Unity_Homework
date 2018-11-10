using System;

namespace _42.Tinh_tong
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i, tong=0;
            Console.WriteLine(" So chu chu so cua day:");
            n=int.Parse(Console.ReadLine());
            int[] arrNum= new int[n];
            for (i=0;i<n;i++)
            {
             Console.WriteLine(" nhap vao phan tu thu {0}", i);
             arrNum[i] = Convert.ToInt32(Console.ReadLine());
             tong = tong + arrNum[i];
             // Console.WriteLine(" tong cua day {0}", tong);
            }
            Console.WriteLine(" tong cua day {0}", tong); 
            Console.ReadLine();
        }
    }
}
