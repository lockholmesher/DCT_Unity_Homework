using System;

namespace Bai_46
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tìm số nguyên tố C# trong day 1-100
            Console.WriteLine("Xin Moi Ban Chon Range Kiem Tra");
            Console.WriteLine("Start(>=3) : ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("End : ");
            int end = Convert.ToInt32(Console.ReadLine());

           
            Console.Write("Tu {0}-{1}  Co Cac So Nguyen To Sau La: " , start , end);
            for(int i = start ; i <=end ; i++)
            {
                
                if(KiemTra(i))
                {
                    Console.WriteLine("{0} La So Nguyen To",i);
                }
              
                
            }

        }
         static bool KiemTra(int so)
        {
             
           int count = 0;
           for(int i = 2; i <so ; i++)
           {
               if(so%i == 0){
                   count+= 1;
                   break;
               }
           }
           if(count == 0){
               return true;
           }else{
               return false;
           }
        }
        
    }
}
