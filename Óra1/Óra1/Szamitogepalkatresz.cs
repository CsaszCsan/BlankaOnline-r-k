using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Óra1
{
    public class Szamitogepalkatresz
    {
        public string Tipus { get; set; }
        public string Gyarto { get; set; }
        public int Ar { get; set; }

        public Szamitogepalkatresz(string tipus, string gyarto)
        {
            Tipus = tipus;
            Gyarto = gyarto;
            Random random = new Random();
            Ar = random.Next(20000, 60001);
        }

        public override string? ToString()
        {
            string szoveg = "Típus: "+Tipus+" Gyártó: "+Gyarto+" Ár: "+Ar;
            return szoveg;
        }
    }
}
