  public class DnSoPhuc
    {
        private int phanthuc;
        private int phanao;
        public DnSoPhuc ( int _phanthuc, int _phanao)
        {
            phanthuc = _phanthuc;
            phanao   = _phanao;
        }
        public string GetDnSoPhuc()
        {
            return phanthuc.ToString() + "/" + phanao.ToString();
        }
        public int GetPhanThuc()
        {
            return phanthuc;
        }
        public int GetPhanAo()
        {
            return phanao;
        }
        public static DnSoPhuc Cong(DnSoPhuc sp1,DnSoPhuc sp2)
        {
            int phanthucresult = sp1.GetPhanThuc() + sp2.GetPhanThuc();
            int phanaoresult = sp1.GetPhanAo()+sp2.GetPhanAo();
            DnSoPhuc resultcong = new DnSoPhuc(phanthucresult,phanaoresult);
        }
    }