using System;
namespace Bai_2
{
    public static class KiemTraSinhVien
    {
        public static void NhapThongTinSinhVien(int n){
            SinhVien[] mangSV = new SinhVien[n];
            for(int i = 0 ; i< n ; i++){
                mangSV[i] = new SinhVien();
                Console.WriteLine("Xin Moi Nhap MaSV Thu {0}",i+1);
                mangSV[i].MaSv = Console.ReadLine();
                Console.WriteLine("Xin Moi Nhap TenSV Thu {0}",i+1);
                mangSV[i].TenSv = Console.ReadLine();
                Console.WriteLine("Xin Moi Nhap NgayThangSV Thu {0}",i+1);
                mangSV[i].NgayThangSV = Console.ReadLine();
                Console.WriteLine("Xin Moi Nhap Diem Toan SV Thu {0}",i+1);
                mangSV[i].DiemToan =Convert.ToInt32(Console.ReadLine()) ;
                Console.WriteLine("Xin Moi Nhap Diem Van SV Thu {0}",i+1);
                mangSV[i].DiemVan =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Xin Moi Nhap Diem Anh SV Thu {0}",i+1);
                mangSV[i].DiemAnh = Convert.ToInt32(Console.ReadLine()) ;
            }
            
           foreach(SinhVien item in mangSV){
               if(item.DiemTrungBinh() >= 15){
                   item.InThongTinSinhVien();
               }
           }
        
        }
        
    }
}