using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace felevesfeladat
{
    class Jatek
    {
        Jatekos Jatekos1 = new Jatekos();
        Jatekos Jatekos2 = new Jatekos();
        Jatekos Jatekos3 = new Jatekos();
        elojatekos Jatekos4 = new elojatekos();
        public Pakli pakli = new Pakli();
        private int szamlalo = 0;
        public bool nyertevalaki = false;
        public Kartyak lenlevokartya;
        public Kartyak legelsokartya;
        int csapatA = 0;
        int csapatB = 0;
        int ertekeslapokszama = 0;
        public Jatek()
        {
            pakli.Paklikeveres();
            legelsokartya = Kartyakirak();
            Jatekos1.Osztas(pakli, ref szamlalo);
            Jatekos2.Osztas(pakli, ref szamlalo);
            Jatekos3.Osztas(pakli, ref szamlalo);
            Jatekos4.Osztas(pakli, ref szamlalo);
            Jatekos1.Osztas(pakli, ref szamlalo);
            Jatekos2.Osztas(pakli, ref szamlalo);
            Jatekos3.Osztas(pakli, ref szamlalo);
            Jatekos4.Osztas2(pakli, ref szamlalo);
        }
        public Jatek(string filenev)
        {
            legelsokartya = new Kartyak();
            lenlevokartya = new Kartyak();
            string[] help;
            int szamlalo = 0;
            StreamReader streamReader1 = new StreamReader(filenev);
            while (!streamReader1.EndOfStream)
            {
                streamReader1.ReadLine();
                szamlalo++;
            }
            help = new string[szamlalo];
            streamReader1.Close();
            StreamReader streamReader = new StreamReader(filenev);
            while (!streamReader.EndOfStream)
            {
                for (int i = 0; i < help.Length; i++)
                {
                    help[i] = streamReader.ReadLine();
                }
            }
            streamReader.Close();
            ;
            string[] temp;
            temp = help[0].Split('#');
            legelsokartya.ertek = (Ertek)Enum.Parse(typeof(Ertek), temp[0]);
            legelsokartya.szin = (Szin)Enum.Parse(typeof(Szin), temp[1]);
            legelsokartya.ertekese = bool.Parse(temp[2]);
            temp = help[1].Split('#');
            lenlevokartya.ertek = (Ertek)Enum.Parse(typeof(Ertek), temp[0]);
            lenlevokartya.szin = (Szin)Enum.Parse(typeof(Szin), temp[1]);
            lenlevokartya.ertekese = bool.Parse(temp[2]);
            csapatA = int.Parse(help[2]);
            csapatB= int.Parse(help[3]);
            ertekeslapokszama= int.Parse(help[4]);
            szamlalo = 5;
            Kartyak[] betoltotkartyak = new Kartyak[8];
            for (int i = 0; i < betoltotkartyak.Length; i++)
            {
                betoltotkartyak[i] = new Kartyak();
                temp = help[szamlalo].Split('#');
                szamlalo++;
                betoltotkartyak[i].ertek = (Ertek)Enum.Parse(typeof(Ertek), temp[0]);
                betoltotkartyak[i].szin = (Szin)Enum.Parse(typeof(Szin), temp[1]);
                betoltotkartyak[i].ertekese = bool.Parse(temp[2]);
            }
            Jatekos1 = new Jatekos(betoltotkartyak);
            betoltotkartyak = new Kartyak[8];
            for (int i = 0; i < betoltotkartyak.Length; i++)
            {
                betoltotkartyak[i] = new Kartyak();
                temp = help[szamlalo].Split('#');
                szamlalo++;
                betoltotkartyak[i].ertek = (Ertek)Enum.Parse(typeof(Ertek), temp[0]);
                betoltotkartyak[i].szin = (Szin)Enum.Parse(typeof(Szin), temp[1]);
                betoltotkartyak[i].ertekese = bool.Parse(temp[2]);
            }
            Jatekos2 = new Jatekos(betoltotkartyak);
            betoltotkartyak = new Kartyak[8];
            for (int i = 0; i < betoltotkartyak.Length; i++)
            {
                betoltotkartyak[i] = new Kartyak();
                temp = help[szamlalo].Split('#');
                szamlalo++;
                betoltotkartyak[i].ertek = (Ertek)Enum.Parse(typeof(Ertek), temp[0]);
                betoltotkartyak[i].szin = (Szin)Enum.Parse(typeof(Szin), temp[1]);
                betoltotkartyak[i].ertekese = bool.Parse(temp[2]);
            }
            Jatekos3 = new Jatekos(betoltotkartyak);
            Kartyak[] betoltotkartyak2 = new Kartyak[7];
            for (int i = 0; i < betoltotkartyak2.Length; i++)
            {
                betoltotkartyak2[i] = new Kartyak();
                temp = help[szamlalo].Split('#');
                szamlalo++;
                betoltotkartyak2[i].ertek = (Ertek)Enum.Parse(typeof(Ertek), temp[0]);
                betoltotkartyak2[i].szin = (Szin)Enum.Parse(typeof(Szin), temp[1]);
                betoltotkartyak2[i].ertekese = bool.Parse(temp[2]);
            }
            Jatekos4 = new elojatekos(betoltotkartyak2);
            Console.WriteLine("A legelső kártya az a " + legelsokartya.ertek + " értékű és " + legelsokartya.szin + " színű kártya");
            Console.WriteLine("Ki raktad a " + lenlevokartya.ertek + " értékű és " + lenlevokartya.szin + " színű kártya");

        }
        public Kartyak Kartyakirak()
        {
            Console.WriteLine("Ki lett rakva a "+pakli.pakli[0].ertek +" értékű és "+ pakli.pakli[0].szin+" színű kártya");
            if (pakli.pakli[0].ertek==Ertek.felsö)
            {
                pakli.Paklikeveres();
                Console.WriteLine("Ujra lett osztva");
                return Kartyakirak();
            }
            else
            {
                szamlalo++;
                return pakli.pakli[0];
            }

        }
        public void Jatekmegy(string mentesneve)
        {
            ;
            while (nyertevalaki == false)
            {
                if (lenlevokartya==null)
                {
                    lenlevokartya = legelsokartya;
                }

                Console.WriteLine();
                lenlevokartya = Jatekos4.Lapoklistazasaeskartyarakas(ref nyertevalaki);
                Console.WriteLine();
                if (lenlevokartya.ertekese == true)
                {
                    ertekeslapokszama++;
                    Console.WriteLine(ertekeslapokszama);
                }
                if (lenlevokartya.ertek==legelsokartya.ertek)
                {
                    csapatA += ertekeslapokszama;
                    Console.WriteLine("A csapat ütött");
                    legelsokartya = lenlevokartya;
                    ertekeslapokszama = 0;
                    if (csapatA >= 3)
                    {
                        nyertevalaki = true;
                        Console.WriteLine("A csapat nyert");
                        Console.WriteLine("Játék vége!");
                    }
                }
                Console.WriteLine("Ki raktad a " + lenlevokartya.ertek + " értékű és " + lenlevokartya.szin + " színű kártya");
                Console.WriteLine("A legelső kártya az a " + legelsokartya.ertek + " értékű és " + legelsokartya.szin + " színű kártya");

                Console.WriteLine();

                lenlevokartya = Jatekos1.Kartyakirak(lenlevokartya,ref legelsokartya);
                if (lenlevokartya.ertekese == true)
                {
                    ertekeslapokszama++;
                    Console.WriteLine(ertekeslapokszama);
                }
                if (lenlevokartya.ertek == legelsokartya.ertek)
                {
                    csapatA += ertekeslapokszama;
                    Console.WriteLine("A csapat ütött");
                    legelsokartya = lenlevokartya;
                    ertekeslapokszama = 0;
                    if (csapatA >= 3)
                    {
                        nyertevalaki = true;
                        Console.WriteLine("A csapat nyert");
                        Console.WriteLine("Játék vége!");
                    }
                }
                Console.WriteLine("Jatékos 1 ki rakta a " + lenlevokartya.ertek + " értékű és " + lenlevokartya.szin + " színű kártya");
                Console.WriteLine("A legelső kártya az a " + legelsokartya.ertek + " értékű és " + legelsokartya.szin + " színű kártya");

                Console.WriteLine();
                
                lenlevokartya = Jatekos2.Kartyakirak(lenlevokartya, ref legelsokartya);
                if (lenlevokartya.ertekese == true)
                {
                    ertekeslapokszama++;
                    Console.WriteLine(ertekeslapokszama);
                }
                if (lenlevokartya.ertek == legelsokartya.ertek)
                {
                    csapatB += ertekeslapokszama;
                    Console.WriteLine("B csapat ütött");
                    legelsokartya = lenlevokartya;
                    ertekeslapokszama = 0;
                    if (csapatB >= 3)
                    {
                        nyertevalaki = true;
                        Console.WriteLine("B csapat nyert");
                        Console.WriteLine("Játék vége!");
                    }
                }
                Console.WriteLine("Jatékos 2 ki rakta a " + lenlevokartya.ertek + " értékű és " + lenlevokartya.szin + " színű kártya");
                Console.WriteLine("A legelső kártya az a " + legelsokartya.ertek + " értékű és " + legelsokartya.szin + " színű kártya");

                Console.WriteLine();


                lenlevokartya = Jatekos3.Kartyakirak(lenlevokartya, ref legelsokartya);
                if (lenlevokartya.ertekese == true)
                {
                    ertekeslapokszama++;
                    Console.WriteLine(ertekeslapokszama);
                }
                if (lenlevokartya.ertek == legelsokartya.ertek)
                {
                    csapatB += ertekeslapokszama;
                    Console.WriteLine("B csapat ütött");
                    legelsokartya = lenlevokartya;
                    ertekeslapokszama = 0;
                    if (csapatB >= 3)
                    {
                        nyertevalaki = true;
                        Console.WriteLine("B csapat nyert");
                        Console.WriteLine("Játék vége!");
                    }
                }
                Console.WriteLine("Jatékos 3 ki rakta a " + lenlevokartya.ertek + " értékű és " + lenlevokartya.szin + " színű kártya");
                Console.WriteLine("A legelső kártya az a " + legelsokartya.ertek + " értékű és " + legelsokartya.szin + " színű kártya");

                Console.WriteLine();
                Console.WriteLine("A csapat pontja " + csapatA + " B csapat pontja " + csapatB);


                StreamWriter streamWriter = new StreamWriter(mentesneve);
                streamWriter.WriteLine(legelsokartya.ertek + "#" + legelsokartya.szin + "#" + legelsokartya.ertekese);
                streamWriter.WriteLine(lenlevokartya.ertek + "#" + lenlevokartya.szin + "#" + lenlevokartya.ertekese);
                streamWriter.WriteLine(csapatA);
                streamWriter.WriteLine(csapatB);
                streamWriter.WriteLine(ertekeslapokszama);
                for (int i = 0; i < Jatekos1.kartyak.Length; i++)
                {
                    streamWriter.WriteLine(Jatekos1.kartyak[i].ertek+"#"+ Jatekos1.kartyak[i].szin+"#"+ Jatekos1.kartyak[i].ertekese);
                }
                for (int i = 0; i < Jatekos2.kartyak.Length; i++)
                {
                    streamWriter.WriteLine(Jatekos2.kartyak[i].ertek + "#" + Jatekos2.kartyak[i].szin + "#" + Jatekos2.kartyak[i].ertekese);
                }
                for (int i = 0; i < Jatekos3.kartyak.Length; i++)
                {
                    streamWriter.WriteLine(Jatekos3.kartyak[i].ertek + "#" + Jatekos3.kartyak[i].szin + "#" + Jatekos3.kartyak[i].ertekese);
                }
                for (int i = 0; i < Jatekos4.kartyak.Length; i++)
                {
                    streamWriter.WriteLine(Jatekos4.kartyak[i].ertek + "#" + Jatekos4.kartyak[i].szin + "#" + Jatekos4.kartyak[i].ertekese);
                }
                streamWriter.Close();



                
            }
        }
    }
}
