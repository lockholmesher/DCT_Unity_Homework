using System;

namespace Bai_40
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết một chương trình C# hiển thị một menu có các lựa chọn để tính diện tích các hình tròn, hình chữ nhật, hình tam giác tương ứng với dữ liệu đã nhập.
            Console.WriteLine("Xin Moi Chon Hinh Can Tinh Dien Tich");
            Console.WriteLine("1: Hinh Chon");
            Console.WriteLine("2: Hinh Chu Nhat");
            Console.WriteLine("3: Hinh Tam Giac");
            int chonHinh = Convert.ToInt32(Console.ReadLine());
            switch(chonHinh){
                case 1:
                    Console.WriteLine("Xin Moi Nhap Ban Kinh Hinh Tron");
                    int banKinh = Convert.ToInt32(Console.ReadLine());
                        float s = (float) 3.14 * banKinh*banKinh;
                        Console.WriteLine("Dien Tich Hinh Tron Tren La: {0}", s);
                break;
                case 2:
                Console.WriteLine("Xin Moi Chieu Dai Hinh Chu Nhat");
                    int chieuDai = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Xin Moi Chieu Rong Hinh Chu Nhat");
                    int chieuRong = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Dien Tich Hinh Chu Nhat Tren La: {0}", chieuDai*chieuRong);
                break;
                case 3:
                Console.WriteLine("Xin Moi Chieu Cao Tam Giac");
                    int chieuCao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Xin Moi Do Dai Canh Day' Hinh Tam Giac");
                    int canhDay = Convert.ToInt32(Console.ReadLine());
                    float sTamGiac = (float)(chieuCao*canhDay)/2;
                     Console.WriteLine("Dien Tich Hinh Tam Giac Tren La: {0}", sTamGiac);
                break;
                default:
                Console.WriteLine("ban Da Chon Sai. Xin Moi Chon Lai");
                break;
            }
        }
    }
}
