using System;

namespace OPP_03.Candidate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so luong:");
            n=int.Parse(Console.ReadLine());
            Candidate _arrCandidate = new Candidate[n];
            for (int i=1; i<n; i++)
            {
                Console.WriteLine("Nhap thong tin thi sinh thu ", + i.ToString());
                _arrCandidate[i]=new Candidate();
                _arrCandidate[i]= In
            }

        }

    }
}
