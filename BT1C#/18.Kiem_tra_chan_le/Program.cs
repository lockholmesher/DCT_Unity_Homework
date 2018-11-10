using System;

namespace _18.Kiem_tra_chan_le
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiem tra chan le");
            int s, d;
            Console.WriteLine("Nhap vao mot so bat ky:");
            s= Convert.ToInt32(Console.ReadLine());
            d= s % 2;
            if (d == 0)
             Console.WriteLine (" so {0} vua nhap la so chan", s);
            else
             Console.WriteLine("So {0} vua nhap la so le:", s);
            Console.ReadLine();
    }
}
