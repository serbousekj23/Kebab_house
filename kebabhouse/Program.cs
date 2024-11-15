namespace kebabhouse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prikazy: ");
            Console.WriteLine("malý kebab = 1, střední kebab = 2, velký kebab = 3, kebab bez masa = 4");
            Console.WriteLine("DoplnMaso");
            Console.WriteLine("--------------------------------------");

            List<sklad> veci = new List<sklad>()
            {
                new sklad(100)
            };

            skladnik Skladnik = new skladnik();
            Skladnik.DisplayMaso(veci);

            List<kebab> kebaby = new List<kebab>();
            {
                kebaby.Add(new kebab("malý kebab"));
                kebaby.Add(new kebab("střední kebab"));
                kebaby.Add(new kebab("velký kebab"));
                kebaby.Add(new kebab("kebab bez masa"));
            };

            sef Sef = new sef();

            foreach (var keb in kebaby)
            {
                int PocetMasa = Sef.PocetMasaKebabu(keb);
                if (PocetMasa > 0)
                {
                    Console.WriteLine($"{keb.Nazev}: kebab potrebuje {PocetMasa} masa");
                }
                else
                {
                    Console.WriteLine($"{keb.Nazev}: kebab je bez masa");
                }
            }


            

            

            
        
            
        }
    }
}
