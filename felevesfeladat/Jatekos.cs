using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace felevesfeladat
{
    class Jatekos
    {
        public Kartyak[] kartyak = new Kartyak[8];
        private int help = 0;
        public Jatekos()
        {

        }
        public Jatekos(Kartyak[] betoltotkartyak)
        {
            kartyak = betoltotkartyak;
        }
        public void Osztas(Pakli pakli, ref int szamlalo)
        {
            for (int i = 0; i < 4; i++)
            {
                kartyak[help] = pakli.pakli[szamlalo];
                help++;
                szamlalo++;
            }
        }
        public Kartyak Kartyakirak(Kartyak lentlevokartya,ref Kartyak legelsokartya)
        {
            ;
            Kartyak ures =new Kartyak();
            Kartyak kartya;
            for (int i = 0; i < kartyak.Length; i++)
            {
                if (lentlevokartya.ertek == Ertek.asz || lentlevokartya.ertek == Ertek.tizes)
                {
                    if (kartyak[i].ertek != Ertek.ures && legelsokartya.ertek == kartyak[i].ertek)
                    {
                        kartya = kartyak[i];
                        kartyak[i] = ures;
                        return kartya;
                    }
                    else if (kartyak[i].ertek != Ertek.ures)
                    {
                        kartya = kartyak[i];
                        kartyak[i] = ures;
                        return kartya;
                    }
                }
                else
                {
                    if (kartyak[i].ertek != Ertek.ures)
                    {
                        kartya = kartyak[i];
                        kartyak[i] = ures;
                        return kartya;
                    }
                }
            }
            return ures;
        }

    }
}
