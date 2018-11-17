using System;

namespace bai28
{
    class Program
    {
        static void Main(string[] args)
        {
            int x , y;
            Console.WriteLine("Chương trình C# để nhập tọa độ (x, y) của một điểm và thông báo góc phần tư");
            Console.WriteLine("moi ban nhap x , y");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Thongbao(x,y);
        }
        static int Thongbao(int x1 ,int y1){
            if(x1>0){
                if(y1>0){
                    Console.WriteLine("toa do ban nhap thuoc goc phan tu thu 1");
                }
                else{
                    Console.WriteLine("toa do ban nhap thuoc goc phan tu thu 2");
                }
            }
            if(x1 <0){
                if(y1>0){
                    Console.WriteLine("toa do ban nhap thuoc goc phan tu thu 4");
                }
                else{
                    Console.WriteLine("toa do ban nhap thuoc goc phan tu thu 3");
                }
            }
            return x1;
             }
        }
    }
