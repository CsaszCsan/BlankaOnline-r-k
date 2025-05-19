namespace Óra1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Adatbazis adatbazis = new Adatbazis();
            Szamitogepalkatresz[] cuccok = adatbazis.Kereses("Proci");
            foreach (Szamitogepalkatresz s in cuccok) 
            {
                Console.WriteLine(s);
            }
        }
    }
}