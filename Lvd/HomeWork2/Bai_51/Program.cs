using System;

namespace Bai_51
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Vẽ tam giác số trong C# (I)

1
12
123
1234
12345*/ 
        for(int i = 0 ; i <5 ; i++){
            for(int j = 1 ; j <= i+1 ; j++){
                Console.Write("{0}", j);
            }
            Console.WriteLine();
        }
        }
    }
}
