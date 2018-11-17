using System;

namespace bai18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiểm tra chẵn lẻ trong C#");
            int num;
            Console.WriteLine("moi ban nhap so");
            num = Convert.ToInt32(Console.ReadLine());
            if(num%2==0){
                Console.WriteLine("ban vua nhap so chan");
            }
            else{
                Console.WriteLine("ban vua nhap so le");
            }
        }
    }
}
