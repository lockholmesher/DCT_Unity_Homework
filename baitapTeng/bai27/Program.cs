using System;

namespace bai27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tìm số lớn nhất trong C#");
            
            Solonnhat();
        }
        static void Solonnhat(){
            int Max;
            Console.WriteLine("moi ban nhap so luong so");
            int i;
            i = Convert.ToInt32(Console.ReadLine());
            int[] dayso = new int[i];
            Console.WriteLine("moi ban cac  so");
            for (int j=0 ; j <i ; j++){
            dayso[j] = Convert.ToInt32(Console.ReadLine());
            }
                Max = dayso[0];
            for(int k = 1; k < i ; k++){
                if(Max < dayso[k]){
                    Max = dayso[k];
                }
                Console.WriteLine("so lon nhat la  " +Max);
            }

            
        }
    }
}
