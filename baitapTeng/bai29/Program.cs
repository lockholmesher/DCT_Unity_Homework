using System;

namespace bai29
{
    class Program
    {
        static void Main(string[] args)
        {
            float dToan,dLy,dHoa;
            float Sumd;
            Console.WriteLine("nhập điểm Toán, Lý, Hóa  kiểm tra xem thí sinh đó có trúng tuyển không");
            Console.WriteLine("nhập điểm Toán, Lý, Hóa  ");
            dToan = float.Parse(Console.ReadLine());
            dHoa = float.Parse(Console.ReadLine());
            dLy = float.Parse(Console.ReadLine());
            Sumd = dToan+dLy+dHoa;
            Console.WriteLine(Sumd);
        }
    }
}
