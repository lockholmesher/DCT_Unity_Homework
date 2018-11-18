using System;
namespace Bai_2
{
    public class SinhVien
    {
        private string maSV;
        private string tenSV;
        private string ngayThangSV;
        private int diemToan;
        private int diemVan;
        private int diemAnh;

        public string MaSv
            {
            get{return maSV;}
            set{maSV = value;}
            }
         public string TenSv
            {
            get{return tenSV;}
            set{tenSV = value;}
            }
         public string NgayThangSV
            {
            get{return ngayThangSV;}
            set{ngayThangSV = value;}
            }
        public int DiemToan{
            get{return diemToan;}
            set{diemToan = value;}
        }
          public int DiemAnh{
            get{return diemAnh;}
            set{diemAnh = value;}
        }
          public int DiemVan{
            get{return diemVan;}
            set{diemVan = value;}
        }
        public int DiemTrungBinh(){
            return diemAnh+diemToan+diemVan;
        }
        public void InThongTinSinhVien(){
            Console.WriteLine("Ten SV La: "+ tenSV);
            Console.WriteLine("Ma SV La: "+ maSV);
            Console.WriteLine("Ngay Thang SV La: "+ ngayThangSV);
            Console.WriteLine("Dien Toan SV La: "+ diemToan);
            Console.WriteLine("Dien Van SV La: "+ diemVan);
            Console.WriteLine("Dien Anh SV La: "+ diemAnh);

        }         
    }
   
}