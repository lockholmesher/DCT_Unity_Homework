using System;

namespace Bai_69
{
    class Program
    {
        static void Main(string[] args)
        {
             //In số theo chiều đảo ngược trong C#
             Console.WriteLine("Xin Moi Nhap SO: ");
             int so = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine(InSo(so));

        }
        static int InSo(int  num){
            string chuoi ="";
            for(int i = num ; i >0 ; i/=10){
                int ketqua= i  % 10;
                chuoi += ketqua.ToString();
            }
            int resutl = Convert.ToInt32(chuoi);
            return resutl;
        }
    }
}
