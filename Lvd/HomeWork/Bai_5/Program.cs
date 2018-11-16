using System;

//switch case của em để làm gì

namespace Bai_5
{
    class Program
    {
        static void Main(string[] args)
        {
           //Chương trình C# để một số từ Input Stream chuẩn và in bảng nhân của số đó
           Console.Write("Xin Moi Nhap So Bang Nhan: ");
           int bangNhan = Convert.ToInt32(Console.ReadLine());
           for(int i = 0 ; i < 11; i++)
               {
                   Console.WriteLine("{0} X {1} = {2}", bangNhan , i , bangNhan*i);
               }
 
        }
    }
}
