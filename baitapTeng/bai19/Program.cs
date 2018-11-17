using System;

namespace bai19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chương trình C# để chuyển đổi thập phân thành nhị phân");
            ConvertNhiphan();
        }
        static void ConvertNhiphan(){
            int numS,numD;
            Console.WriteLine("moi ban nhap so");
            numS = Convert.ToInt32(Console.ReadLine());
            while(numS>0)
            {
            numS = numS/2;
            numD = numS%2;
            Console.WriteLine(numD);
            }
        }
    }
}
