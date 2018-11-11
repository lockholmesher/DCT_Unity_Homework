using System;

namespace Bai_68
{
    class Program
    {
        static void Main(string[] args)
        {
            //In dãy Fibonacci trong C#
        Console.WriteLine("Xin Moi Day~ Fibonacci Co Bao Nhieu So: ");
        int so = Convert.ToInt32(Console.ReadLine());

        int[] mangFibonacci = new int[so];
        mangFibonacci[0] = 10;
        ChuyenThanhFibonacci(mangFibonacci);
        
          foreach(int mang in mangFibonacci){
              Console.WriteLine(mang);
          }
             
        }
        static void ChuyenThanhFibonacci( int[] mang){
            
            mang[0] = 0 ; mang[1] = 1;

            int lenght = mang.Length;
           for(int i = 2 ; i <lenght ; i++){
               mang[i] = mang[i-1] + mang[i-2];
           } 
            
        }
         
    }
}
