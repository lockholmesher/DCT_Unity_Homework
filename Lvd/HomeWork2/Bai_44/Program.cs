using System;

namespace Bai_44
{
    class Program
    {
        static void Main(string[] args)
        {
            // In bảng cửu chương trong C#
            for(int i = 1 ; i < 10 ; i++){
                Console.WriteLine("Bang {0}", i);
                for(int j = 1 ; j < 10 ; j++){
                    Console.WriteLine("{0} X {1} = {2}", i , j , i*j);
                }

            }
        }
        
    }
}
