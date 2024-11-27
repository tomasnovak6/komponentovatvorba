namespace Pujcovna;

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