using System;

namespace Bai_38
{
    class Program
    {
        static void Main(string[] args)
        {
           //Nhập một số bất kỳ và hiển thị số bằng chữ tương ứng trong C#
           Console.WriteLine("Xin Moi Nhap So s");
           string so = Console.ReadLine();
           switch(so){
               case 1 : 
               Console.WriteLine("Mot");
               break;
               case 2 : 
               Console.WriteLine("Hai");
               break;
               case 3 : 
               Console.WriteLine("Ba");
               break;
               case 4 : 
               Console.WriteLine("Bon");
               break;
               case 5 : 
               Console.WriteLine("Nam");
               break;
               case 6 : 
               Console.WriteLine("Sau");
               break;
               case 7 : 
               Console.WriteLine("Bay");
               break;
               case 8 : 
               Console.WriteLine("Tam");
               break;
               case 9 : 
               Console.WriteLine("Chin");
               break;
               default: Console.WriteLineO("Ban Da Nhap Sai Xin Moi Nhap Lai");
               break;
           }
        }
    }
}
