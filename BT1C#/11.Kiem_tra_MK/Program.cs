using System;

namespace _11.Kiem_tra_MK
{
    class Program
    {
        static void Main(string[] args)
        {
            string user, pass;
            int count =0;
            Console.WriteLine(" Sign In Program:");
            Console.WriteLine (" Value defaut Username , password ");
            do 
            {
             Console.WriteLine (" user: ");
             user= Console.ReadLine();
             Console.WriteLine (" pass: ");
             pass= Console.ReadLine();
             count ++;
            }
            while 
            ((( user!= "username")||(pass!="password"))&& (count<=3));
            if ( count==3)
            Console.WriteLine(" Username and Password Invalid");
            else Console.WriteLine(" Username and Password valid");
            Console.ReadKey();
        }
    }
}
