using System;

namespace Bai_66
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chương trình C# để tìm số armstrong trong một dãy số đã cho
            Console.WriteLine("Xin Moi Nhap Day So");
            Console.WriteLine("Start");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("End");
            int end = Convert.ToInt32(Console.ReadLine());

            for(int j = start ; j <= end ; j++)
            {
                 if(KiemTraSo(j)){
                      Console.WriteLine("{0} La So armstrong",j);
                 }
            }
               
        }
         static bool KiemTraSo(int num){

                int sum = 0;
            for(int i = num ; i >0 ; i /= 10)
            {
                int b = i%10;
                sum += b* b*b;
            }
            
            if(sum == num){
                return true;
            }else{
                return false;
            }
        }
    }
}
