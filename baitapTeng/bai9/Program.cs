using System;

namespace bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            int chieudai;
            Console.WriteLine("Chương trình C# để vẽ tam giác số");
            Console.WriteLine("moi ban nhap chieu dai");
            chieudai = Convert.ToInt32(Console.ReadLine());
            for(int i=chieudai ; i >=1 ; i--)
            {
                for(int j = 0 ; j <= i ; j++){
                Console.Write(j + "");
                }
                Console.WriteLine();
            }
        }
    }
}
