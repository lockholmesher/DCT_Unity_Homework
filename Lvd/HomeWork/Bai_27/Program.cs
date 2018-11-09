using System;
//OK
namespace Bai_27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tìm số lớn nhất trong C#
            Console.WriteLine("Xin Moi Nhap So Luong  So Can Kiem Tra");
            int soLuong= Convert.ToInt32(Console.ReadLine());
            int[] mang = new int[soLuong];
            int sll =0 ;
            for(int i = 0 ; i < mang.Length ; i++ )
            {
                Console.WriteLine("Xin Moi Nhap So Thu {0} : ", i+1);
                mang[i] = Convert.ToInt32(Console.ReadLine());
                
                if(sll < mang[i]){
                    sll = mang[i];
                }
            }
           
                 Console.WriteLine("So Lon Nhat La {0}", sll);

            
        }
    }
}
