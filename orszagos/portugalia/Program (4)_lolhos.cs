using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LolCLI_V2
{
    public class Program
    {
       public static List<Hos> hosok = new List<Hos>();

        static void Main(string[] args)
        {
            Beolvas();
            Feladat2();
            Feladat3();
            Feladat5();
        }

        static void Beolvas()
        {
            string[] sorok = File.ReadAllLines("champions2017_V2.txt");
            
            for (int i = 1; i < sorok.Length; i++)
            {
                hosok.Add(new Hos(sorok[i]));
            }
        }

        static void Feladat2()
        {
            Console.WriteLine($"2. Feladat: Az állományban {hosok.Count} hős található");
        }

        static void Feladat3()
        {
            Console.WriteLine("3. Feladat: Kérem adja meg a hős nevét: ");
            string hosNev;
            Hos keresettHos;
            do
            {
                hosNev = Console.ReadLine();
                keresettHos = hosok.FirstOrDefault(h => h.Name == hosNev);
            } while (keresettHos == null);

            Console.WriteLine($"{keresettHos.Name} adatai: HP:{keresettHos.HP}; Kategória: {keresettHos.Category}");
        }

        static void Feladat5()
        {
            Hos maxHpHos = hosok[0];
            double maxHp = maxHpHos.HpErtek(15);

            foreach (Hos hos in hosok)
            {
                double hp = hos.HpErtek(15);
                if (hp > maxHp)
                {
                    maxHp = hp;
                    maxHpHos = hos;
                }
            }

            Console.WriteLine($"5. Feladat: 15. szinten a legnagyobb HP-vel rendelkező hős {maxHpHos.Name}; HP={maxHp}");   
        }
    }
}
