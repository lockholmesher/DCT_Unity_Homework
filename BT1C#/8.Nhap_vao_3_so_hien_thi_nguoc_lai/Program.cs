using System;

namespace _8.Nhap_vao_3_so_hien_thi_nguoc_lai
{
    class Program
    {
        static void Main(string[] args)
        {
           char cc1,cc2,cc3;
           Console.WriteLine(" Chuong trinh nhap vao 3 chu cai hien thi thu tu nguoc lai");
           Console.WriteLine("Nhap cc1 =");
           cc1=char.Parse(Console.ReadLine());
           Console.WriteLine("Nhap cc2 =");
           cc2=char.Parse(Console.ReadLine());
           Console.WriteLine("Nhap cc3 =");
           cc3=char.Parse(Console.ReadLine());
           string s = cc3.ToString()+cc2.ToString()+cc1.ToString();
           Console.WriteLine("{0}", s);
           Console.ReadLine();
        }
    }
}
