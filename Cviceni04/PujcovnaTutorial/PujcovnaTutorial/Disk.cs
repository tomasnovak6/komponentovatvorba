using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PujcovnaTutorial
{
    [Serializable()]
    public abstract class Disk
    {
        public string Nazev { get; set; }
        public string Zanr { get; set; }
        public int CenaVypujcky { get; set; }

        public Disk(string nazev, string zanr, int cenaVypujcky)
        {
            Nazev = nazev;
            Zanr = zanr;
            CenaVypujcky = cenaVypujcky;
        }

    }

    [Serializable()]
    public class CD: Disk
    {
        public string Interpret { get; set; }

        public CD(string nazev, string interpret, string zanr, int cenaVypujcky) : base(nazev, zanr, cenaVypujcky)
        {
            Interpret = Interpret;
        }
    }

    [Serializable()]
    public class Dvd: Disk
    {
        public string Reziser { get; set; }
        public bool Pristupny { get; set; }

        public Dvd(string nazev, string reziser, string zanr, int cenaVypujcky, bool pristupny = true) : base(nazev, zanr, cenaVypujcky)
        {
            Reziser = reziser;
            Pristupny = pristupny;
        }
    }

}
