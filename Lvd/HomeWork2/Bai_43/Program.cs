using System;

namespace Bai_43
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chương trình C# để hiển thị các số Hex có giá trị từ 0 - 255
            

            for(int i = 0 ; i <=255 ; i++)
            {

                    Console.WriteLine("{0} CHuyen Sang Hex La: {1}",i,ConvertHex(i));
                
               
            }
            


           
        }
      static string ConvertHex(int so)
       {
           string ketQua="";
            for(int i = so ; i >0 ; i/=16)
            {           
                int b = i%16;
                char bienTam;
                if(b >9)
                {
                    b =b+55;
                    bienTam =(char)b;
                    ketQua = bienTam+ ketQua;
                }else{
                    ketQua = b.ToString() + ketQua;
                }
            }      
        
            return ketQua;
       }
    }
}
