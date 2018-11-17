using System;

namespace bai24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CheckTuoi();
        }
        static void CheckTuoi()
        {
            int tuoi;
            Console.WriteLine("moi ban nhap tuoi");
            tuoi = Convert.ToInt32(Console.ReadLine());
            if(tuoi >= 18 )
            {
                Console.WriteLine("ban du tuoi tham gia bau cu");
            }
            else {
                Console.WriteLine("ban khong du tuoi tham gia bau cu");
            }
    }
}
