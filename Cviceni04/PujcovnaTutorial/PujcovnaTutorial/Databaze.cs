using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PujcovnaTutorial
{
    public static class Databaze
    {
        public static BindingList<Zakaznik> Zakaznici { get; private set; } = new BindingList<Zakaznik>();
        public static BindingList<Disk> Sklad { get; private set; } = new BindingList<Disk>();

        static Databaze()
        {
            //Zakaznici.Add(new Zakaznik("Pepa", "Novák", "Praha", 1980));
            //Zakaznici.Add(new Zakaznik("Karel", "Vomáčka", "Kladno", 1990));
            //Zakaznici.Add(new Zakaznik("František", "Dobrota", "Blízká Vesnice", 1995));
            //Zakaznik z = new Zakaznik("Tomáš", "Marný", "Praha", 2002);
            //Zakaznici.Add(z);
            //z.Vypujcene.Add(new CD("Best of", "Ewa Farna", "pop", 25));

            //Sklad.Add(new CD("Rosenrot", "Rammstein", "metal", 25));
            //Sklad.Add(new CD("Black Ice", "AC/DC", "rock", 25));
            //Sklad.Add(new CD("Plná taška", "Eva a Vašek", "psychedelický hardcore", 15));

            //Sklad.Add(new Dvd("50 shades of grey", "Taylor Johnson", "erotický", 30, false));
            //Sklad.Add(new Dvd("Fantastická zvířata a jak je najít", "David Yates", "fantasy", 25, true));
            //Sklad.Add(new Dvd("Rogue One: A Star Wars Story", "Gareth Edwards", "Scifi", 30, true));

            Deserializuj();
        }

        public static void Vypujcit(int indZ, int indS)
        {
            Zakaznici[indZ].Vypujcene.Add(Sklad[indS]);
            Sklad.RemoveAt(indS);
        }

        public static void Vratit(int indZ, int indP)
        {
            Sklad.Add(Zakaznici[indZ].Vypujcene[indP]);
            Zakaznici[indZ].Vypujcene.RemoveAt(indP);
        }

        public static void Vypujcit(object zO, object dO)
        {
            Zakaznik z = (Zakaznik)zO;
            Disk d = (Disk)dO;

            z.Vypujcene.Add(d);
            Sklad.Remove(d);
        }

        public static void Vratit(object zO, object dO)
        {
            Zakaznik z = (Zakaznik)zO;
            Disk d = (Disk)dO;

            Sklad.Add(d);
            z.Vypujcene.Remove(d);
        }
        
        public static void Serializuj()
        {
            //using (Stream s = File.Open("zakaznici.bin", FileMode.Create))
            //{
            //    BinaryFormatter b = new BinaryFormatter();
            //    b.Serialize(s, Zakaznici);
            //}
            //using (Stream s = File.Open("sklad.bin", FileMode.Create))
            //{
            //    BinaryFormatter b = new BinaryFormatter();
            //    b.Serialize(s, Sklad);
            //}

            Serializuj<Zakaznik>(Zakaznici, "zakaznici.bin");
            Serializuj<Disk>(Sklad, "sklad.bin");
        }

        public static void Serializuj<T>(BindingList<T> list, string soubor)
        {
            using (Stream s = File.Open(soubor, FileMode.Create))
            {
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, list);
            }
        }

        public static void Deserializuj()
        {
            //using (Stream s = File.Open("zakaznici.bin", FileMode.Open))
            //{
            //    BinaryFormatter b = new BinaryFormatter();
            //    Zakaznici = (BindingList<Zakaznik>)b.Deserialize(s);
            //}
            //using (Stream s = File.Open("sklad.bin", FileMode.Open))
            //{
            //    BinaryFormatter b = new BinaryFormatter();
            //    Sklad = (BindingList<Disk>)b.Deserialize(s);
            //}

            Zakaznici = Deserializuj<Zakaznik>("zakaznici.bin");
            Sklad = Deserializuj<Disk>("sklad.bin");
        }

        public static BindingList<T> Deserializuj<T>(string soubor)
        {
            using (Stream s = File.Open(soubor, FileMode.Open))
            {
                BinaryFormatter b = new BinaryFormatter();
                return (BindingList<T>)b.Deserialize(s);
            }
        }
    }
}
