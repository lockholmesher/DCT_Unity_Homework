using System;

namespace bai17
{
    class Program
    {
        static void Main(string[] args)
        {
            char kitu;
            Console.WriteLine("kiểm tra một chữ cái thường nhập từ bàn phím là nguyên âm, chữ số hay ký tự khác");
            kitu = Convert.ToChar(Console.ReadLine());
            switch(kitu){
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("so ban nhap la chu nguyen am");
                    break;


            }
        }
    }
}
