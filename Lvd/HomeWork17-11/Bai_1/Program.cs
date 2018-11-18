using System;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SoPhuc _sp1;
            SoPhuc _sp2;
            NhapSoPhuc(out _sp1,out _sp2);
            InKetQua(_sp1,_sp2);
        }
        static void NhapSoPhuc(out SoPhuc sp1 , out SoPhuc sp2){
            int a,b;
            Console.WriteLine("Xin Moi Nhap Phan Thuc So Phuc 1: ");
             a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Xin Moi Nhap Phan Ao So Phuc 1: ");
             b = Convert.ToInt32(Console.ReadLine());
             sp1 = new SoPhuc(a,b);
             Console.WriteLine("Xin Moi Nhap Phan Thuc So Phuc 2: ");
             a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Xin Moi Nhap Phan Ao So Phuc 2: ");
             b = Convert.ToInt32(Console.ReadLine());
             sp2 = new SoPhuc(a,b);
        }
        static void InKetQua(SoPhuc sp1 , SoPhuc sp2){
            SoPhuc ketqua = SoPhuc.CongSoPhuc(sp1,sp2);
            Console.WriteLine("Ket Qua Phep Cong :" + ketqua.GetSoPhuc());
            ketqua = SoPhuc.TruSoPhuc(sp1,sp2);
            Console.WriteLine("Ket Qua Phep Tru :" + ketqua.GetSoPhuc());
            ketqua = SoPhuc.NhanSoPhuc(sp1,sp2);
            Console.WriteLine("Ket Qua Phep Nhan :" + ketqua.GetSoPhuc());

        }
    }
}
