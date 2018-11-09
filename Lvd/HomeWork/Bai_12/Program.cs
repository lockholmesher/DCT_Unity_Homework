using System;
//Chưa ổn lắm về cách viết Code
namespace Bai_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chương trình C# để nhập hai số và nhập một phép toán. Tương ứng với phép toán đã nhập bạn thực hiện phép tính trên hai số và in kết quả ra màn hình
            Console.Write("Xin Moi Nhap So Thu 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Xin Moi Nhap So Thu 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Xin Moi Nhap Phep Tinh: ");
            string c = Console.ReadLine();
            switch(c)
            {
                case "/": 
                float d = (float)a/b;
                Console.WriteLine("Ket Qua Phep Tinh: {0} {1} {2} = {3}", a,c,b,d);
                break;
                 case "*":
                 Console.WriteLine("Ket Qua Phep Tinh: {0} {1} {2} = {3}", a,c,b,a*b);
                break;
                 case "+":
                  Console.WriteLine("Ket Qua Phep Tinh: {0} {1} {2} = {3}", a,c,b,a+b);
                break;
                 case "-":
                  Console.WriteLine("Ket Qua Phep Tinh: {0} {1} {2} = {3}", a,c,b,a-b);
                break;
                default:
                break;
            }
            
            

        }
    }
}
