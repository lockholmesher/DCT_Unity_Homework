using System;

namespace _48.Tong_so_le
{
    class Program
    {
        static void Main(string[] args)
        {
         int n;
         do
         {
          Console.WriteLine ("Nhap n =")
          n=int.Parse(Console.ReadLine());
         } while (n>=100||n<=0);
         int [] a = new int [100]
         for ( int i=0; i<n; i++)
         {
             Console.WriteLine( " Nhap a[{0}]", i);
             a[i]=int.Parse(Console.ReadLine().ToString());
         }
         Console.ReadLine();
         Console.WriteLine("Day so vua nhap:");
         for(int i=0;i<n;i++)
         {
             Console.Write("{0}")
         }
        }
    }
}
