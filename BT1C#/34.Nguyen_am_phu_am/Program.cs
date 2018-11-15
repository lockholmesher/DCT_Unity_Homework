using System;

namespace _34.Nguyen_am_phu_am
{
    class Program
    {
        static void Main(string[] args)
        {
            char kt;
            Console.WriteLine("Kiem tra nguyen am va phu am");
            Console.WriteLine(" Nhap ky tu bat ky");
            kt=Convert.ToChar(Console.ReadLine().ToLower());
            switch(kt)
            {
                case 'u':
                Console.WriteLine(" Chu cai vua nhap la nguyen am");
                break;
                case 'e':
                Console.WriteLine(" Chu cai vua nhap la nguyen am");
                break;
                case 'o':
                Console.WriteLine(" Chu cai vua nhap la nguyen am");
                break;
                case 'a':
                Console.WriteLine(" Chu cai vua nhap la nguyen am");
                break;
                case 'i':
                Console.WriteLine(" Chu cai vua nhap la nguyen am");
                break;
                default:
                Console.WriteLine("Chu so vua nhap la phu am");
                break;
            }
            Console.ReadLine();
        }
    }
}
