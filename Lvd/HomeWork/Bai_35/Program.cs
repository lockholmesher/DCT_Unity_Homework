using System;

namespace Bai_35
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chương trình C# để kiểm tra lợi nhuận hoặc thua lỗ
            Console.WriteLine("Xin Moi Nhap Chi: ");
            int chi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Xin Moi Nhap Thu: ");
            int thu = Convert.ToInt32(Console.ReadLine());
            if(thu > chi){
                Console.WriteLine("Loi Nhuan Duoc {0}", thu - chi);
            }else if( thu == chi){
                Console.WriteLine("kinh Doanh Hoa");
            }else{
                Console.WriteLine("Bi Lo {0}", chi - thu);
            }
        }
    }
}
