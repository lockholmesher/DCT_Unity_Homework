using System;

namespace Bai_39
{
    class Program
    {
        static void Main(string[] args)
        {
           // Nhập số tháng bất kỳ và hiển thị số ngày của tháng đó trong C#
           Console.WriteLine("Xin Moi Nhap So Thang: ");
           int thang = Convert.ToInt32(Console.ReadLine());

           if(thang == 1 ||thang == 3 ||thang == 5 ||thang == 7||thang == 8 ||thang == 10 || thang == 12){
               Console.WriteLine("So Ngay Trong Thang {0} La :31 Ngay" , thang);
           }else if(thang == 4 ||thang == 6 || thang == 9 || thang == 11){
                Console.WriteLine("So Ngay Trong Thang {0} La :30 Ngay" , thang);
           }else if(thang == 2){
               Console.WriteLine("So Ngay Trong Thang {0} La :28 Ngay" , thang);
           }
        }
    }
}
