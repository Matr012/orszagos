using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hegyekCLI13B
{
    public class Hegyek
    {
        public string Nev { get; private set; }
        public string Hegyseg { get; private set; }
        public int Magassag { get; private set; }

        public Hegyek(string sor)
        {
            string[] adatok = sor.Split(';');
            Nev = adatok[0];
            Hegyseg = adatok[1];
            Magassag = int.Parse(adatok[2]);
        }
    }
}
