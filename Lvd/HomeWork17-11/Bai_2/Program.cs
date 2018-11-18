using System;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xin Moi Nhap So Luong Sinh Vien Can Luu:");
            int soLuong = Convert.ToInt32(Console.ReadLine());
            KiemTraSinhVien.NhapThongTinSinhVien(soLuong);
           
            
        }
    }
}
