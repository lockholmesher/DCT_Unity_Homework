using System;

namespace testphanso
{
    class Program
    {
        static void Main(string[] args)
        {
            phanso ps1,ps2;
            GetInputPhanso(out ps1 , out ps2);
            GetOutputPhanso(in ps1 , in ps2);
        }
        static void GetInputPhanso(out phanso _ps1,out phanso _ps2){
            int tuso,mauso;
            Console.WriteLine("moi ban nhap tu so 1 :");
            tuso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("moi ban nhap mau so 1 :");
            mauso = Convert.ToInt32(Console.ReadLine());
            _ps1 = new phanso(tuso,mauso);

            Console.WriteLine("moi ban nhap tu so 2 :");
            tuso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("moi ban nhap mau so 2 :");
            mauso = Convert.ToInt32(Console.ReadLine());
            _ps2 = new phanso(tuso,mauso);
        }
        static void GetOutputPhanso(in phanso _ps1, in phanso _ps2){
            phanso tru = phanso.tru(_ps1,_ps2);

            Console.WriteLine("ket qua tru cua ban la" +tru.Getphanso() );

        }
    
    }
}
