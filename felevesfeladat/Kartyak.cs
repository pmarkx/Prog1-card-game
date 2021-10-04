using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace felevesfeladat
{
    enum Szin { piros,zöld,tök,makk,ures}
    enum Ertek { also = 4,felsö,kiraly,hetes,nyolcas,kilences,tizes,asz,ures}
    class Kartyak
    {
        public bool ertekese { get; set; }
        public Szin szin { get; set; }
        public Ertek ertek { get; set; }
        public Kartyak(bool ertekese,Szin szin,Ertek ertek)
        {
            this.ertekese = ertekese;
            this.szin = szin;
            this.ertek = ertek;
        }
        public Kartyak()
        {
            ertek = Ertek.ures;
            ertekese = false;
            szin = Szin.ures;
        }
    }
}
