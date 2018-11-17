using System;

namespace bai43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hương trình C# để hiển thị các số Hex có giá trị từ 0 - 255");
            ConvertHex();

        }
        static void ConvertHex(){
            int num;
             Console.WriteLine("moi ban nhap so");
             num = Convert.ToInt32(Console.ReadLine());
           // int test = num%16 ;
            char c = (char)num;
            Console.WriteLine(c);
        }
    }
}
