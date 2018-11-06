using System;

namespace Bai_9
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  Chương trình C# để vẽ tam giác số
                        4 4 4 4 4
                        4 4 4 4
                        4 4 4
                        4 4
                        4 */ 
            
            for(int i = 0 ; i<5 ; i++)
            {
                for(int j = 0 ; j < 5-i ; j++ )
                {
                    Console.Write("4 ");
                }
                Console.WriteLine();
            }
        }
    }
}
