using System.Net.NetworkInformation;

namespace hegyekCLI13B
{
    public class Program
    {
        public static List<Hegyek> hegysegek = new List<Hegyek>();

        public static bool taralamaz(string kerSzo, string hegycsucs, string hegysegneve)
        {
            if(hegycsucs.Contains(kerSzo) || hegysegneve.Contains(kerSzo))
                return true;
            else return false;
        }
        static void Main(string[] args)
        {
         
            Beolvas();
            Feladat8();
            Feladat11();
        }

        private static void Feladat11()
        {
            Console.WriteLine("Kérem a keresett szót:");
            string keresett = Console.ReadLine();
            Console.WriteLine("......");

            foreach(var item in hegysegek)
            {
                if(taralamaz(keresett, item.Hegyseg, item.Nev))
                    {
                        Console.WriteLine(item.Nev);
                    }

            }
            
        }

        private static void Feladat8()
        {
            foreach (var item in hegysegek)
            {
                if(item.Magassag>950)
                {
                    Console.WriteLine($"{item.Nev} {item.Hegyseg} {item.Magassag}");
                }
            }
        }

        public static void Beolvas()
        {
            string[] adatok = File.ReadAllLines("hegyek.csv").Skip(1).ToArray();
            foreach (var item in adatok)
            {
                hegysegek.Add(new Hegyek(item));
            }
        }
    }
}
