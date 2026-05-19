using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetCLI_13B.Modells
{
    public class cellovo
    {
        public string Nev { get; private set; }
        public int elsoloves { get; private set; }
        public int masidikloves { get; private set; }
        public int harmadikloves { get; private set; }
        public int negyedikloves { get; private set; }

        public cellovo(string sor) 
        {
            string[] temp = sor.Split(';');
            Nev=temp[0];
            elsoloves = int.Parse(temp[1]);
            masidikloves = int.Parse(temp[2]);
            harmadikloves = int.Parse(temp[3]);
            negyedikloves = int.Parse(temp[4]);
        }

        public int Osszeg()
        {
            return elsoloves+masidikloves+harmadikloves+negyedikloves;
        }

        public double Atlag()
        {
            return Osszeg() / 4.0;
        }
    }
}
