using System;

//switch case của em để làm gì

namespace Bai_5
{
    class Program
    {
        static void Main(string[] args)
        {
           //Chương trình C# để một số từ Input Stream chuẩn và in bảng nhân của số đó
           Console.Write("Xin Moi Nhap So Bang Nhan: ");
           int bangNhan = Convert.ToInt32(Console.ReadLine());
           switch(bangNhan)
           {
               case 1: 
               for(int i = 0 ; i < 11; i++)
               {
                   Console.WriteLine("{0} X {1} = {2}", bangNhan , i , bangNhan*i);
               }
               break;
               case 2: 
               for(int i = 0 ; i < 11; i++)
               {
                   Console.WriteLine("{0} X {1} = {2}", bangNhan , i , bangNhan*i);
               }
               break;
               case 3: 
               for(int i = 0 ; i < 11; i++)
               {
                   Console.WriteLine("{0} X {1} = {2}", bangNhan , i , bangNhan*i);
               }
               break;
               case 4: 
               for(int i = 0 ; i < 11; i++)
               {
                   Console.WriteLine("{0} X {1} = {2}", bangNhan , i , bangNhan*i);
               }
               break;
               case 5: 
               for(int i = 0 ; i < 11; i++)
               {
                   Console.WriteLine("{0} X {1} = {2}", bangNhan , i , bangNhan*i);
               }
               break;
               case 6: 
               for(int i = 0 ; i < 11; i++)
               {
                   Console.WriteLine("{0} X {1} = {2}", bangNhan , i , bangNhan*i);
               }
               break;
               case 7: 
               for(int i = 0 ; i < 11; i++)
               {
                   Console.WriteLine("{0} X {1} = {2}", bangNhan , i , bangNhan*i);
               }
               break;
               case 8: 
               for(int i = 0 ; i < 11; i++)
               {
                   Console.WriteLine("{0} X {1} = {2}", bangNhan , i , bangNhan*i);
               }
               break;
               case 9: 
               for(int i = 0 ; i < 11; i++)
               {
                   Console.WriteLine("{0} X {1} = {2}", bangNhan , i , bangNhan*i);
               }
               break;
           }
        }
    }
}
