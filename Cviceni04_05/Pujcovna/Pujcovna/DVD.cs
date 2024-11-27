namespace Pujcovna;

public class DVD: Disk
{
    public string Reziser { get; set; }
    public bool Pristupny { get; set; }

    public DVD(string nazev, string reziser, string zanr, int cenaVypujcky, bool pristupny = true) : base(nazev, zanr,
        cenaVypujcky)
    {
        Reziser = reziser;
        Pristupny = pristupny;
    }
}