using System;

namespace Bai_41
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết một chương trình C# hiển thị một menu có các lựa chọn để thực hiện các phép toán cơ bản của hai số a, b
            Console.WriteLine("Xin Moi Nhap So a: ");
            int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Xin Moi Nhap So b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Xin Moi Chon Phep Tinh: ");
            Console.WriteLine("1: Cong ");
            Console.WriteLine("2: Tru ");
            Console.WriteLine("3: Nhan ");
            Console.WriteLine("4: Chia ");
            int phepTinh = Convert.ToInt32(Console.ReadLine());

            switch(phepTinh){
                case 1 :
                Console.WriteLine("Tong Cua 2 So Tren La : {0}", a+b);
                break;
                case 2 :
                Console.WriteLine("Hieu Cua 2 So Tren La : {0}", a-b);
                break;
                case 3 :
                Console.WriteLine("Tich Cua 2 So Tren La : {0}", a*b);
                break;
                case 4 :
                float thuong = (float) a/b;
                Console.WriteLine("Thuong Cua 2 So Tren La : {0}", thuong);
                break;
                default:
                Console.WriteLine("Ban Chon Khong Dung. Xin Moi Chon Lai");
                break;
            }
            
            

        }
    }
}
