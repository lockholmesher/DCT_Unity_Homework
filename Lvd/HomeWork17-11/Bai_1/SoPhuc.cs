namespace Bai_1
{
    public class SoPhuc
    {
        private int phanThuc;
        private int phanAo;

        public SoPhuc(int _phanThuc , int _phanAo){
            phanThuc = _phanThuc;
            phanAo =_phanAo;
        }
        public int GetPhanThuc(){
            return phanThuc;
        }
        public int GetPhanAo(){
            return phanAo;
        }
        public static SoPhuc CongSoPhuc(SoPhuc sp1 , SoPhuc sp2){
            int num1 = sp1.GetPhanThuc() + sp2.GetPhanThuc();
            int num2 = sp1.GetPhanAo() + sp2.GetPhanAo();
            SoPhuc tong = new SoPhuc(num1,num2);
            return tong;
        }
        public static SoPhuc TruSoPhuc(SoPhuc sp1 , SoPhuc sp2){
            int num1 = sp1.GetPhanThuc() - sp2.GetPhanThuc();
            int num2 = sp1.GetPhanAo() - sp2.GetPhanAo();
            SoPhuc tong = new SoPhuc(num1,num2);
            return tong;
        }
        public static SoPhuc NhanSoPhuc(SoPhuc sp1 , SoPhuc sp2){
            int num1 = (sp1.GetPhanThuc()*sp2.GetPhanThuc()) - (sp1.GetPhanAo()*sp2.GetPhanAo());
            int num2 = sp1.GetPhanThuc()*sp2.GetPhanAo() + (sp2.GetPhanThuc()*sp2.GetPhanAo());
            SoPhuc tong = new SoPhuc(num1,num2);
            return tong;
        }
        public string GetSoPhuc(){
            return phanThuc + " + " + phanAo+"i";
        }

    }
}