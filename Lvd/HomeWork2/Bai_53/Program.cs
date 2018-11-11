using System;

namespace Bai_53
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Vẽ tam giác số trong C# (III)

1
2 3
4 5 6
7 8 9 10 */
        int coung = 0;
         for(int i = 0 ; i <4 ; i++){
            for(int j = 1 ; j <= i+1 ; j++){
                coung +=1;
                Console.Write("{0} ", coung);
            }
            Console.WriteLine();
        }
        }
    }
}
