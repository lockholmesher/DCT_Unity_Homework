using System;

namespace bai44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bang cuu chuong");
            bangcuuchuong();
        }
        static void bangcuuchuong(){
            for(int i=1;i<=10;i++){
                for(int j=1 ; j<=10;j++){
                    Console.WriteLine(i + "*" + j + "=" + i*j);
                }
                Console.WriteLine("---");
            }
        }
    }
}
