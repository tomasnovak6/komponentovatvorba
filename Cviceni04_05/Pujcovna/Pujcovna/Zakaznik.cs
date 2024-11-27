namespace Pujcovna;

using System.ComponentModel;

public class Zakaznik
{
    public string Jmeno { get; set; }
    public string Prijmeni { get; set; }
    public string Adresa { get; set; }
    public int RokNarozeni { get; set; }
    
    public BindingList<Disk> Vypujcene { get; private set; } = new BindingList<Disk>();

    public Zakaznik(string jmeno, string prijmeni, string adresa, int rokNarozeni)
    {
        Jmeno = jmeno;
        Prijmeni = prijmeni;
        Adresa = adresa;
        RokNarozeni = rokNarozeni;
    }
}