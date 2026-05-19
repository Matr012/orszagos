




namespace EvVegiArakCLI_13B_Diak
{
    public class Program
    {
        public static List<Arak> arak = new List<Arak>();
        static void Main(string[] args)
        {
            Beolvasas();
            Feladat1();
            Feladat3();
            Feladat5();
            Feladat6();
            
        }

        private static void Feladat6()
        {
            var olcsobb = arak.Where(x => x.Valtozas() < 0);
            using (StreamWriter sw = new StreamWriter("Olcsobbak.txt")) 
            {
                foreach (var item in olcsobb) 
                {
                    sw.WriteLine($"{item.Kod};{item.Megnevezes};{ Math.Abs(item.Valtozas())}");
                }
                sw.Close();

            } 
            
        }

        private static void Feladat5()
        {
            Console.WriteLine("5.feladat");
            int index = 0;
            for (int i = 0; i < arak.Count; i++)
            {
                if (arak[i].Valtozas() > arak[index].Valtozas())
                {
                    index = i;
                }
            }
            Console.WriteLine($"A legnagyobb mértékben a {arak[index].Megnevezes} emelkedett, {arak[index].Valtozas()} Ft-tal.");

            Arak legtobb=arak.MaxBy(x => x.Valtozas());

            Console.WriteLine($"A legnagyobb mértékben a {legtobb.Megnevezes} emelkedett, {legtobb.Valtozas()} Ft-tal.");
        }

        private static void Feladat3()
        {
            Console.Write("Kérem adja meg a termék kódját! ");
            string kod = Console.ReadLine();

            Arak? keresett = arak.FirstOrDefault(a => a.Kod == kod);

            if (keresett != null)
            {
                Console.WriteLine($"Termék neve: {keresett.Megnevezes}, átlagára 2024-ben: {((keresett.Januar + keresett.December) / 2.0):f2} Ft");
            }
            else
            {
                Console.WriteLine("Nincs ilyen termék a listában :(");
            }
        }

        private static void Feladat1()
        {
            Console.WriteLine($"Az állományban {arak.Count} db termék található.");
        }

        public static void Beolvasas()
        {
            StreamReader sr = new StreamReader("Arak2024.txt");
            sr.ReadLine();
            while(!sr.EndOfStream)
            {
                arak.Add(new Arak(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}
