using System;
//OK
namespace Bai_33
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chương trình C# để nhập 3 số, và kiểm tra xem 3 số này có phải là 3 góc của tam giác không
            Console.WriteLine("Xin Moi Nhap 3 Goc Cua Tam Giac");
            Console.WriteLine("Goc 1");
            int goc1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Goc 2");
            int goc2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Goc 3");
            int goc3= Convert.ToInt32(Console.ReadLine());
            if(goc1 + goc2 + goc3 == 180){
                Console.WriteLine("3 goc tren la 3 goc cua tam giac");
            }else{
                Console.WriteLine("3 goc tren ko phai la 3 goc cua tam giac");
            }
        }
    }
}
