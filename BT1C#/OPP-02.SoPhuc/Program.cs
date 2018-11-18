using System;

namespace OPP_02.SoPhuc
{
    class Program
    {
        static void Main(string[] args)
        {
            DnSoPhuc sp1, sp2;
            Inputsophuc (out sp1, out sp2);
            OutputSophuc (in sp1, in sp2);
        }
        static void Inputsophuc(out DnSoPhuc sp1, out DnSoPhuc sp2)
        {
            Console.WriteLine("Nhap vao phan thuc so phuc thu 1:");
            int pt1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Nhap vao phan ao so phuc thu 1:");
            int pa1 = Convert.ToInt32 (Console.ReadLine());   
            sp1 = new DnSoPhuc(pt1,pa1)  ;

            Console.WriteLine("Nhap vao phan thuc so phuc thu 2:");
            int pt2 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Nhap vao phan ao so phuc thu 1:");
            int pa2 = Convert.ToInt32 (Console.ReadLine());   
            sp2 = new DnSoPhuc(pt2,pa2)  ;
        }
        static void OutputSophuc(in DnSoPhuc sp1, in DnSoPhuc sp2)
        {
          DnSoPhuc ketquacongsp = DnSoPhuc.Cong(sp1,sp2);
          Console.WriteLine("Ket qua cong so phuc" +ketquacongsp.GetDnSoPhuc());


        }
    }
}
