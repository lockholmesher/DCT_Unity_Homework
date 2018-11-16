using System;

namespace WhileProject
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0;i<255;i++)
            {
                Console.WriteLine(ConvertHex(i));
            }
            Console.WriteLine(Sum(4,5));
            int Sum(int a,int b)
            {
                return a+b;
            }
        }
        
         static string ConvertHex(int Deci)
         {
            string s = "";
            
            do
            {
                int Du = Deci%16;
                Deci = Deci/16;
                if (Du < 10)
                s= Du.ToString()+s;
                else
                s=(char)(Du+55)+s;
            }
            while (Deci > 0);
             return s;
         }
    }
}
