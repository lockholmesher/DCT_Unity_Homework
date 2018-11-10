using System;

namespace _7.Chuyen_doi_do_C_sang_do_K
{
    class Program
    {
        static void Main(string[] args)
        {
            double c=0,k=0;
            Console.WriteLine("Chuong trinh doi do C sang do K: ");
            Console.WriteLine(" Moi ban nhap vao doi C:");
            c = double.Parse(Console.ReadLine());
            k=c+273.15;
            Console.WriteLine("Do K sau khi doi  la: {0}", k);
            Console.ReadLine();
        }
    }
}
