using System;

namespace Bai_67
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vẽ tam giác Pascal trong C#
            /*
1        
1 1 
1 2 1
1 3 3 1
1 4 6 4 1 */
        Console.WriteLine("Xin Moi Nhap Chieu Cao PasCal");
        int h = Convert.ToInt32(Console.ReadLine());

          for(int i = 1 ; i<=h ; i++)
          {
              for(int x = 1 ; x<=h-i ; x++)
              {
                  Console.Write(" ");
              }
              for(int j = 1 ; j <= i ; j++)
              {
                  Console.Write("{0} ",ToHop(j-1,i-1));
              }
              Console.WriteLine();
          }

        



         int GiaiThua(int n)
            {
                int giaithua = 1;
                for (int i = 2; i <= n; i++)
                giaithua = giaithua*i;
                return giaithua;
            }
        int ToHop(int k, int n)
            {
            return GiaiThua(n) / ( GiaiThua(n - k) * (GiaiThua(k)));
            }
        }
    }
}

