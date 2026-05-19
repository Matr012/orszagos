using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvVegiArakCLI_13B_Diak
{
    public class Arak
    {
        public Arak(string kod, string megnevezes, int december, int januar)
        {
            Kod = kod;
            Megnevezes = megnevezes;
            December = december;
            Januar = januar;
        }

        public string Kod { get; private set; }
        public string Megnevezes { get; private set; }
        public int December { get; private set; }
        public int Januar { get; private set; }

        public Arak(string sor)
        {
            string[] adat = sor.Split("\t");
            Kod = adat[0];
            Megnevezes = adat[1].Split(",")[0];
            December = int.Parse(adat[2]);
            Januar = int.Parse(adat[3]);
        }
        public int Valtozas()
        {
            return Januar - December;
        }
    }
}
