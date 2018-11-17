using System;
    public class phanso
    {
        private int tuso;
        private int mauso;

        public phanso(int tuso1, int mauso1){
            tuso = tuso1;
            mauso = mauso1;
        }
        public int Gettuso(){
            return tuso;
        }
        public int Getmauso(){
            return mauso;
        }
        public string Getphanso(){
            return  tuso.ToString() + " / " + mauso.ToString(); 
        }
        public static phanso tru(phanso ps1 , phanso ps2){
            int mausochung =  ps1.Getmauso() * ps2.Getmauso();
            int tusoresult = (ps1.Gettuso() * ps2.Getmauso()) - ((ps2.Gettuso())*ps1.Getmauso());
            phanso psresult = new phanso(tusoresult,mausochung);
            return psresult;

        }


    }
