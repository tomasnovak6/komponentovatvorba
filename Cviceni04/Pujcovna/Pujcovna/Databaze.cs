using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Pujcovna;

public static class Databaze
{
    public static BindingList<Zakaznik> Zakaznici { get; private set; } = new BindingList<Zakaznik>();
    public static BindingList<Disk> Sklad { get; private set; } = new BindingList<Disk>();

    static Databaze()
    {
        Zakaznici.Add(new Zakaznik("Pepa", "Novak", "Praha", 1980));
        Zakaznici.Add(new Zakaznik("Karel", "Vomáčka", "Kladno", 1990));
        Zakaznici.Add(new Zakaznik("František", "Dobrota", "Blízká Vesnice", 1995));
        
        Zakaznik z = new Zakaznik("Tomáš", "Marný", "Praha", 2002);
        Zakaznici.Add(z);
        z.Vypujcene.Add(new CD("Best of", "Ewa Farna", "pop", 25));
        
        Sklad.Add(new CD("Rosenrot", "Rammstein", "metal", 25));
        Sklad.Add(new CD("Black Ice", "AC/DC", "rock", 25));
        Sklad.Add(new CD("Plná taška", "Eva a Vašek", "psychedelický hardcore", 15));
        Sklad.Add(new DVD("50 shades of grey", "Taylor Johnson", "erotický", 30, false));
        Sklad.Add(new DVD("Fantastická zvířata a jak je najít", "David Yates", "fantasy", 25, true));
        Sklad.Add(new DVD("Rogue One: A Star Wars Story", "Gareth Edwards", "Scifi", 30, true));
    }

    public static void Vypujcit(object zO, object d0)
    {
        Zakaznik z = (Zakaznik)zO;
        Disk d = (Disk)d0;

        z.Vypujcene.Add(d);
        Sklad.Remove(d);
    }

    public static void Vratit(object z0, object d0)
    {
        Zakaznik z = (Zakaznik)z0;
        Disk d = (Disk)d0;

        Sklad.Add(d);
        z.Vypujcene.Remove(d);
    }
}