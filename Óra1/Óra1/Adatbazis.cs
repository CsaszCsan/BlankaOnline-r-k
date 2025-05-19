using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Óra1
{
    public class Adatbazis
    {
        List<Szamitogepalkatresz> alkatreszek;

        public Adatbazis()
        {
            alkatreszek = new List<Szamitogepalkatresz>();

            alkatreszek.Add(new Szamitogepalkatresz("Alaplap", "Asus"));
            alkatreszek.Add(new Szamitogepalkatresz("Proci", "Intel"));
            alkatreszek.Add(new Szamitogepalkatresz("Proci", "AMD"));
            alkatreszek.Add(new Szamitogepalkatresz("Alaplap", "Asrock"));

        }

        public Szamitogepalkatresz[] Kereses(string Tipus)
        {
            List<Szamitogepalkatresz> eredmenylista = new List<Szamitogepalkatresz>();
            foreach (Szamitogepalkatresz alkatresz in alkatreszek) 
            {
                if(alkatresz.Tipus == Tipus) 
                {
                    eredmenylista.Add(alkatresz);
                }
            }
            return eredmenylista.ToArray();
        }
    }
}
