using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace felevesfeladat
{
    class elojatekos
    {
        public Kartyak[] kartyak = new Kartyak[7];
        private int help = 0;
        public elojatekos()
        {

        }
        public elojatekos(Kartyak[] betoltotkartyak)
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
        public void Osztas2(Pakli pakli, ref int szamlalo)
        {
            for (int i = 0; i < 3; i++)
            {
                kartyak[help] = pakli.pakli[szamlalo];
                help++;
                szamlalo++;
            }
        }
        public Kartyak Lapoklistazasaeskartyarakas(ref bool felad)
        {
            Kartyak kartya;
            Kartyak ures = new Kartyak();
            for (int i = 0; i < kartyak.Length; i++)
            {
                Console.WriteLine(i+". lapod: "+kartyak[i].szin+" színe és a száma "+ kartyak[i].ertek);
            }
            Console.WriteLine("Válasz egy lapnak a számát kerlek vagy feladhatod ha beírod hogy felad");

            string input = Console.ReadLine();
            if (input=="felad")
            {
                felad = true;
                return ures;
            }
            else
            {
                kartya= kartyak[int.Parse(input)];
                kartyak[int.Parse(input)] = ures;
                return kartya;
            }
        }
    }
}
