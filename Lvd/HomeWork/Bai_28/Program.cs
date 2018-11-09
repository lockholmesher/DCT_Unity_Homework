using System;
//OK
namespace Bai_28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chương trình C# để nhập tọa độ (x, y) của một điểm và thông báo góc phần tư
            Console.WriteLine("Xin Moi Nhap Toa Do X va Y");
            Console.WriteLine("Xin Moi Nhap Toa Do X ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Xin Moi Nhap Toa Do  Y");
            int y = Convert.ToInt32(Console.ReadLine());

            if(x >0 && y >0){
                Console.WriteLine("Diem Tren Thuoc Phan Tu thu 1");
            }
            else if ( x >0 && y <0){
                Console.WriteLine("Diem Tren Thuoc Phan Tu thu 2");
            }
            else if ( x <0 && y <0){
                Console.WriteLine("Diem Tren Thuoc Phan Tu thu 3");
            }
            else if ( x <0 && y >0){
                Console.WriteLine("Diem Tren Thuoc Phan Tu thu 4");
            }
        }
    }
}
