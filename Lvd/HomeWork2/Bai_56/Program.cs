using System;

namespace Bai_56
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Xin Moi Nhap So Canh Tam Giac: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = 0 ; i <a ; i++){
             for(int j = 0 ; j <a-i ; j++){
                Console.Write(" ");
            } 
            for(int j = 1 ; j <= i+1 ; j++){
                
                Console.Write("* ", i+1 );
            }
            Console.WriteLine();
            }
        }
    }
}
