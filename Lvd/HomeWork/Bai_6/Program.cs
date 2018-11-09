using System;

//OK

namespace Bai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Nhap Can Tinh Tong Bao Nhieu So: ");
            int z = Convert.ToInt32(Console.ReadLine());
           for(int i = 0 ; i <z ; i++)
           {
              
              Console.WriteLine("Xin Moi Nhap So Thu {0}: ",i+1);
              sum += Convert.ToInt32(Console.ReadLine()); 

           }
           float tong = (float)sum/z;
             Console.WriteLine("Trung Binh Cong Cua {0} So Tren La: {1}", z,tong);
        }
    }
}
