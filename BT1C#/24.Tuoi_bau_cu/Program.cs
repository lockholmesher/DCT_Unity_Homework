using System;

namespace _24.Tuoi_bau_cu
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age =0;
            Console.WriteLine("Nhap vao so tuoi");
            Age=Convert.ToInt32(Console.ReadLine());
            if (Age > 18)
            {
                Console.WriteLine(" Du tuoi bau cu");
            }
            else 
            {
                Console.WriteLine ("Chua du tuoi bau cu");
            }
            Console.ReadLine();
        }
    }
}
