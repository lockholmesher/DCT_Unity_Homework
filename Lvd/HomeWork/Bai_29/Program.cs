using System;

namespace Bai_29
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chương trình C# để nhập điểm thi ba môn Toán, Lý, Hóa của một thí sinh, kiểm tra xem thí sinh đó có trúng tuyển không
            Console.WriteLine("Diem Trung Tuyen Tong 3 Mon La 15 ");

            Console.WriteLine("Xin Moi Nhap Diem Toan: ");
            int dToan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Xin Moi Nhap Diem Ly: ");
            int dLy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Xin Moi Nhap Diem Hoa: ");
            int dHoa = Convert.ToInt32(Console.ReadLine());
            int tog = dHoa + dToan+ dLy;
            if(dToan <2 || dLy <2 ||dHoa <2){
                Console.WriteLine("Ban Da Truot Vi Co Mon Bi Diem Liet");
            }else if (tog <15){
                Console.WriteLine("Ban Da Truot Vi Tong 3 Mon Khong Du 15 DIem");
            }else{
                Console.WriteLine("Chuc Mung Ban Da Trung Tuyen");
            }


        }
    }
}
