using System;

namespace Bai_58
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vẽ hình kim cương bằng cách dấu sao trong C#
            Console.WriteLine("Xin Moi Nhap Chieu Cao Kim Cuong: ");
            int chieCao = Convert.ToInt32(Console.ReadLine());
            for(int i = 0 ; i < chieCao ; i++){
                for(int j = 0 ; j < chieCao - i ; j++){
                    Console.Write(" ");
                }
                 for(int j = 1 ; j <= i+1  ; j++){
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for(int i = 0 ; i <chieCao-1 ; i ++ ){
                for(int j = 1 ; j <= i+2 ; j++){
                    Console.Write(" ");
                }
                for(int j = 0 ; j < chieCao-1 - i ; j++){
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}
