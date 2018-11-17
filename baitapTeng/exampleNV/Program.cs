using System;

namespace exampleNV
{
    class Program
    {
        struct NhanVien{
            public string tennhanvien;
            public string namsinh;
        }
        static void Main(string[] args)
        {
            int soluongnhanvien;
            string name;
            string age;
            Console.WriteLine("nhap so luong nhan vien");
            soluongnhanvien = Convert.ToInt32(Console.ReadLine());
            NhanVien[] data = new NhanVien[soluongnhanvien];
            for(int i = 0 ; i < soluongnhanvien ; i++){
                Console.WriteLine("moi ban nhap ten nhan vien {0}" ,i);
                name = Convert.ToString(Console.ReadLine()); 
                data[i].tennhanvien = name;
                Console.WriteLine("moi ban nhap tuoi nhan vien {0}" ,i);
                age = Convert.ToString(Console.ReadLine()); 
                data[i].namsinh = age;
                /*  Console.WriteLine("moi ban nhap tuoi nhan vien {0}" ,i);
                age[i] = Convert.ToString(Console.ReadLine()); 
                NhanVien.namsinh[i] = age[i];
                */

            }
            for(int j = 0 ; j < soluongnhanvien ; j ++){
            Console.WriteLine(data[j].tennhanvien);
            Console.WriteLine(data[j].namsinh);
            }
            
        }
    }
}
