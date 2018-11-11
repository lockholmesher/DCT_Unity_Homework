using System;

namespace Bai_55
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Vẽ tam giác số trong C# (V)
      1
     2 2
    3 3 3
   4 4 4 4 */
            
         for(int i = 0 ; i <4 ; i++){
             for(int j = 0 ; j <5-i ; j++){
                Console.Write(" ");
            } 
            for(int j = 1 ; j <= i+1 ; j++){
                
                Console.Write("{0} ", i+1 );
            }
            Console.WriteLine();
        }
        }
    }
}
