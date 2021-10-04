using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace felevesfeladat
{
    class Pakli
    {
        public Kartyak[] pakli = new Kartyak[32];
        public Pakli()
        {
            pakli[0] = new Kartyak(false, Szin.piros, Ertek.also);
            pakli[1] = new Kartyak(false, Szin.makk, Ertek.also);
            pakli[2] = new Kartyak(false, Szin.tök, Ertek.also);
            pakli[3] = new Kartyak(false, Szin.zöld, Ertek.also);
            pakli[4] = new Kartyak(false, Szin.piros, Ertek.felsö);
            pakli[5] = new Kartyak(false, Szin.makk, Ertek.felsö);
            pakli[6] = new Kartyak(false, Szin.tök, Ertek.felsö);
            pakli[7] = new Kartyak(false, Szin.zöld, Ertek.felsö);
            pakli[8] = new Kartyak(false, Szin.piros, Ertek.kiraly);
            pakli[9] = new Kartyak(false, Szin.makk, Ertek.kiraly);
            pakli[10] = new Kartyak(false, Szin.tök, Ertek.kiraly);
            pakli[11] = new Kartyak(false, Szin.zöld, Ertek.kiraly);
            pakli[12] = new Kartyak(false, Szin.piros, Ertek.hetes);
            pakli[13] = new Kartyak(false, Szin.makk, Ertek.hetes);
            pakli[14] = new Kartyak(false, Szin.tök, Ertek.hetes);
            pakli[15] = new Kartyak(false, Szin.zöld, Ertek.hetes);
            pakli[16] = new Kartyak(false, Szin.piros, Ertek.nyolcas);
            pakli[17] = new Kartyak(false, Szin.makk, Ertek.nyolcas);
            pakli[18] = new Kartyak(false, Szin.tök, Ertek.nyolcas);
            pakli[19] = new Kartyak(false, Szin.zöld, Ertek.nyolcas);
            pakli[20] = new Kartyak(false, Szin.piros, Ertek.kilences);
            pakli[21] = new Kartyak(false, Szin.makk, Ertek.kilences);
            pakli[22] = new Kartyak(false, Szin.tök, Ertek.kilences);
            pakli[23] = new Kartyak(false, Szin.zöld, Ertek.kilences);
            pakli[24] = new Kartyak(true, Szin.piros, Ertek.tizes);
            pakli[25] = new Kartyak(true, Szin.makk, Ertek.tizes);
            pakli[26] = new Kartyak(true, Szin.tök, Ertek.tizes);
            pakli[27] = new Kartyak(true, Szin.zöld, Ertek.tizes);
            pakli[28] = new Kartyak(true, Szin.piros, Ertek.asz);
            pakli[29] = new Kartyak(true, Szin.makk, Ertek.asz);
            pakli[30] = new Kartyak(true, Szin.tök, Ertek.asz);
            pakli[31] = new Kartyak(true, Szin.zöld, Ertek.asz);
        }
        public void Paklikeveres()
        {
            int randomszam;
            Kartyak help;
            for (int i = 0; i < pakli.Length; i++)
            {
                randomszam = Randomocska.random.Next(0, 31);
                help = pakli[randomszam];
                pakli[randomszam] = pakli[i];
                pakli[i] = help;
            }
        }
    }
}
