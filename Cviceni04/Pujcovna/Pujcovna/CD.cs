namespace Pujcovna;

public class CD: Disk
{
    public string Interpret { get; set; }

    public CD(string nazev, string interpret, string zanr, int cenaVypujcky): base(nazev, zanr, cenaVypujcky)
    {
        Interpret = interpret;
    }
}