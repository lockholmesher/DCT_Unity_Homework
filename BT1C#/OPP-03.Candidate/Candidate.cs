
    public class Candidate
    {
      private string _hoten;
      private string    _ngay_thang_namsinh; 
      private double _diemToan;
      private double _diemVan;
      private double _diemAnh;
      private double _dtb;

      public Candidate()
      {
          Hoten = "";
          NgayThangNam = "";
          DiemToan = 0;
          DiemVan =0;
          DiemAnh =0;
          DiemTB =0;
      }
      public string HoTen
      {
        get {return _hoten;}
        set  {_hoten =value;}
      }
      public string NgayThangNam
      {
        get {return _ngay_thang_namsinh;}
        set  {_ngay_thang_namsinh =value;}
      }
      public int DiemToan
      {
        get {return _diemToan;}
        set  {_diemToan =value;}
      }
      public int DiemVan
      {
        get {return _diemVan;}
        set  {_diemVan =value;}
      }
      public int DiemAnh
      {
        get {return _diemAnh;}
        set  {_diemAnh =value;}
      }
      public int DiemTB
      {
        get {return Math.Round(((DiemToan+DiemVan+DiemAnh)/3),3);}
        set  {_dtb =value;}
      }
      public void InputCandidate()
          {
            Console.WriteLine ("Nhap Ho Ten:");
            HoTen = Console.ReadLine();
            Console.WriteLine ("Nhap Ngay Thang NamSinh:");
            NgayThangNam = Console.ReadLine();
            double temp;
            Console.WriteLine("Nhap diem toan:")
            temp = double.Parse(Console.ReadLine());
            if (temp>10||temp<0)
            {
                Console.WriteLine("Diem phai nam tu 0 den 10");
                Console.WriteLine("Moi nhap lai");
            }
            else DiemToan =temp;
            Console.WriteLine("Nhap diem van:")
            temp = double.Parse(Console.ReadLine());
            if (temp>10||temp<0)
            {
                Console.WriteLine("Diem phai nam tu 0 den 10");
                Console.WriteLine("Moi nhap lai");
            }
            else DiemVan =temp;

            Console.WriteLine("Nhap diem anh:")
            temp = double.Parse(Console.ReadLine());
            if (temp>10||temp<0)
            {
                Console.WriteLine("Diem phai nam tu 0 den 10");
                Console.WriteLine("Moi nhap lai");
            }
            else DiemAnh =temp;
          }
      public void OutputCandidate()
          {
           Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", HoTen, NgayThangNam, DiemToan, DiemVan,DiemAnh, DiemTB);
          }
    }