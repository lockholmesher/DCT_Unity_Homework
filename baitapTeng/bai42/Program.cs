using System;

namespace bai42
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int tong = 0;
            Console.WriteLine("Tính tổng dãy số trong C#");
             Console.WriteLine("nhap so luong so muon tinh tong");
             i = Convert.ToInt32(Console.ReadLine());
             int[] dayso = new int[i];
             for(int j=0;j<i;j++){
                Console.WriteLine("nhap cac so");
                dayso[j] = Convert.ToInt32(Console.ReadLine());
                tong = tong+dayso[j];
             }
             Console.WriteLine("tong cac so ban vua nhap la " +tong);
        }
    }
}
