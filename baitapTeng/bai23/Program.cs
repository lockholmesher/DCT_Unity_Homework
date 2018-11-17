using System;

namespace bai23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiểm tra năm nhuận trong C#");
            int nam;
            Console.WriteLine("moi ban nhap nam muon kiem tra");
            nam = Convert.ToInt32(Console.ReadLine());
            if(nam%4==0 || (nam%100==0 && nam%400==0)){
                Console.WriteLine("nam ban vua nhap la nam nhuan ");
            }
            else
                Console.WriteLine("nam ban vua nhap khong phai nam nhuan");
        }
    }
}
