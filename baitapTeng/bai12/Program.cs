using System;

namespace bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chương trình C# để nhập hai số và nhập một phép toán");
            int a,b;
            char pheptoan;
            Console.WriteLine("moi ban nhap 2 so a , b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("moi ban chon phep toan");
            pheptoan = Convert.ToChar(Console.ReadLine());
            switch(pheptoan){
                case '+' :
                    Console.WriteLine("a + b = {0}" , a+b);
                    break;
                case '-' :
                    Console.WriteLine("a - b = {0}" , a-b);
                    break;
                case '*' :
                    Console.WriteLine("a * {0}" , a*b);
                    break;
                case '/' :
                    Console.WriteLine("a / b = {0}" , a/b); 
                    break;         
            }
        }
    }
}
