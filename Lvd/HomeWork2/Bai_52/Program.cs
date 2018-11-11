using System;

namespace Bai_52
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Vẽ tam giác số trong C# (II)

1
22
333
4444
55555 */ 
          for(int i = 0 ; i <5 ; i++){
            for(int j = 1 ; j <= i+1 ; j++){
                Console.Write("{0}", i+1);
            }
            Console.WriteLine();
        }
        }
    }
}
