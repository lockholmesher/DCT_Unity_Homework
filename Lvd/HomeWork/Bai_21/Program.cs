using System;
//OK
namespace Bai_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kiem Tra Chan Le
            
             Console.WriteLine("Xin Moi Nhap So Can Kiem Tra: ");
          string a = Console.ReadLine();
          
                if(Convert.ToInt32(a)%2 ==0)
                {
              Console.WriteLine("{0} La So Chan",a);
                }else
                    {
              Console.WriteLine("{0} La So Le",a);
                    }
           

        }
    }
}
