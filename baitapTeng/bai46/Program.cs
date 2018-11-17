using System;

namespace bai46
{
    class Program
    {
        static void Main(string[] args)
        {
            int _length;
            int[] _list;
            Console.WriteLine("Tìm số nguyên tố trong C#");
            Console.WriteLine("moi ban nhap so luong so");
            _length = Convert.ToInt32(Console.ReadLine());
            _list = new int[_length];
            for(int i=0 ; i < _length ; i++){
                Console.WriteLine("moi ban nhap so :");
                _list[i] = Convert.ToInt32(Console.ReadLine());
                  Checknguyento(_list[i],_length);
            }
          
        }
        static int Checknguyento(int _listv,int _lengthv){
             int n =0;
             for(int i1=0 ; i1 < _lengthv;i1 ++){
                for(int i2 = 1 ; i2 < _listv[i1] ; i2++){
                    if((_listv[i1] % i2) == 0){
                    n++;     
                    }
                }
                if(n==2){
                    Console.WriteLine("so ban vua nhap la so nguyen to" +n);
                }
                else{
                    Console.WriteLine("so ban vua nhap khong la so nguyen to" +n);
                }
             }
             return n;
                
        }
    }
}
