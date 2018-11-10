using System;

namespace _9.Ve_tam_giac_so
{
    class Program
    {
        static void Main(string[] args)
        {
          int a=0, i =0, j=0;
          Console.WriteLine("Chuong trinh ve tam giac so a hang: ");
          Console.WriteLine("Nhap vao hang a :");
          a= Convert.ToInt32(Console.ReadLine());
          for(i =0; i<a; i++)
          {
             for (j=0; j<a; j++)
             {
                if (j>= (a-i))
                {
                Console.Write(" ");
                }
                else
                {
                Console.Write("{0}", a);
                }
             } 
              
              Console.Write("\n");
          }
        //    for( i=0;i<a; i++)
        //    {
        //       for (j=0; j<a; j++)
        //       Console.WriteLine("{0}",a);
        //    }
            // Console.ReadKey();
        }
    }
}
