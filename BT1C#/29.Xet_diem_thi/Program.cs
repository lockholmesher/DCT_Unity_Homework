using System;

namespace _29.Xet_diem_thi
{
    class Program
    {
        static void Main(string[] args)
        {
            double diemtoan, diemly, diemhoa, diemtb;
            do 
            {
                Console.WriteLine("Nhap vao diem toan ");
                diemtoan = double.Parse(Console.ReadLine());
            }
            while (diemtoan<0||diemtoan>10);

            do 
            {
                Console.WriteLine("Nhap vao diem ly ");
                diemly = double.Parse(Console.ReadLine());
            }
            while (diemly<0||diemly>10);
            do 
            {
                Console.WriteLine("Nhap vao diem hoa ");
                diemhoa = double.Parse(Console.ReadLine());
            }
            while (diemhoa<0||diemhoa>10);
            diemtb = (diemtoan+diemly+diemhoa)/3;
            if (diemtb>5)
            {
                Console.WriteLine ("Chuc mung ban da vuot qua ky thi");
            }
            else 
            {
                Console.WriteLine("Ban truot, can co gan hon");
            }
            Console.ReadLine();
        }
    }
}
