
using celloveszetCLI_13B.Modells;

namespace celloveszetCLI_13B
{
    public class Program
    {
        public static List<cellovo> cellovok=new List<cellovo>();
        static void Main(string[] args)
        {
            Beolvas();
            Feladat9();
            Feladat10();
            Feladat11();
        }

        private static void Feladat11()
        {
            Console.WriteLine("11. feladat");
            cellovo legjobb = cellovok.MinBy(c => c.Atlag());
            Console.WriteLine($"{legjobb.Nev} {(int)legjobb.Atlag()}");
        }

        private static void Feladat10()
        {
            Console.WriteLine("10. feladat");
            cellovo legjobb = cellovok.MaxBy(c => c.Osszeg());
            Console.WriteLine($"{legjobb.Nev} {legjobb.elsoloves} {legjobb.masidikloves} {legjobb.harmadikloves} {legjobb.negyedikloves}");
        }

        private static void Feladat9()
        {
            Console.WriteLine("9. feladat");
            foreach (var item in cellovok)
            {
                Console.WriteLine($"\t{item.Nev} {legnagyobb(item.elsoloves,item.masidikloves,item.harmadikloves,item.negyedikloves)}");
            }
        }

        public static void Beolvas()
        {
            StreamReader sr = new StreamReader(@"Resources\lovesek.csv");
            while (!sr.EndOfStream)
            {
                cellovok.Add(new cellovo(sr.ReadLine()));
            }
            sr.Close();
        }

        public static int legnagyobb(int elso, int masodik, int harmadik, int negyedik)
        {
            //List<int> lovesek = new()
            //{
            //    elso, masodik, harmadik, negyedik
            //};
            //List<int> lovesek=new List<int>();
            //lovesek.Add(elso);
            //lovesek.Add(masodik);

            int[] lovesek = {elso,  masodik, harmadik, negyedik};

            return lovesek.Max();
        }
    }
}
