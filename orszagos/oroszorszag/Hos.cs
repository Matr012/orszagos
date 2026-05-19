using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolCLI_V2
{
    public class Hos
    {
        public string Name { get; private set; }
        public string Title { get; private set; }
        public string Category { get; private set; }
        public string Blurb { get; private set; }
        public double HP { get; private set; }
        public double HPPerLevel { get; private set; }

        public Hos(string sor)
        {
            string[] adatok = sor.Split(';');
            Name = adatok[0];
            Title = adatok[1];
            Category = adatok[2];
            Blurb = adatok[3];
            HP = double.Parse(adatok[4]);
            HPPerLevel = double.Parse(adatok[5]);
        }

        public double HpErtek(int szint)
        {
            if (szint < 1 || szint > 18)
            {
                return -1;
            }
            return HP + (szint - 1) * HPPerLevel;
        }
    }
}