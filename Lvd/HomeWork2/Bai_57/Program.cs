using System;

namespace Bai_57
{
    class Program
    {
        static void Main(string[] args)
        {
           //Vẽ tam giác sao cân trong C#
           Console.WriteLine("Xin Moi Nhap Chieu Cao Tam Giac: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = 0 ; i <a ; i++){
             for(int j = 0 ; j <(a-i)*2 ; j++){
                Console.Write(" ");
            } 
            for(int j = 1 ; j <= i*2+1 ; j++){
                
                Console.Write("* ", i+1 );
            }
            Console.WriteLine();
            }
        }
    }
}
