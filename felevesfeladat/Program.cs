using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace felevesfeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Jatek jatek = new Jatek();
            jatek.Jatekmegy("mentes.txt");
            //Jatek jatek1 = new Jatek("mentes.txt");
            //jatek1.Jatekmegy("mentes2.txt");
            Console.ReadLine();
        }
    }
}
