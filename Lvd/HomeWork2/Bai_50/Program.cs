using System;

namespace Bai_50
{
    class Program
    {
        static void Main(string[] args)
        {
           /*   Vẽ tam giác sao trong C#

*
**
***
****
*****/

    for(int i = 0 ; i < 5 ; i++){
        for(int j = 0 ; j <i+1 ; j++){
             Console.Write("*");
        }

        Console.WriteLine();
    }
        }
    }
}
