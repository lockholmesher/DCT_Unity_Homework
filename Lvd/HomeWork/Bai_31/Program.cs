using System;
//OK
namespace Bai_31
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chương trình C# để nhập nhiệt độ và in ra thông báo tương ứng

            Console.WriteLine("Xin Moi Nhap Nhiet Do: ");
            int nhietDo = Convert.ToInt32(Console.ReadLine());

            if(nhietDo <= 0 ){
                Console.WriteLine("Thoi Tiet Dong Bang ");
            }else if(nhietDo >0 && nhietDo <= 10){
                Console.WriteLine("Thoi Rat Lanh");
            }else if(nhietDo >10 && nhietDo <= 20){
                Console.WriteLine("Thoi Lanh");
            }else if(nhietDo >20 && nhietDo <= 30){
                Console.WriteLine("Thoi Tiet Tuyet Voi");
            }else if(nhietDo >30 && nhietDo <= 40){
                Console.WriteLine("Thoi Tiet nong");
            }else {
                Console.WriteLine("Thoi Tiet Rat nong");
            }
        }
    }
}
