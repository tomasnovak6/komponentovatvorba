using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HezciScitackaDelegat
{

    /* Trida ScitackaDelegovana implementuje hlavni aplikacni logiku. Realizuje jednotlive operace, ktere
     * od nasi jednoduche kalkulacky chceme a pro svou cinnost vyuziva mechanismus delegatu.
     * 
     * V teto podobe jednotlive metody berou jako parametry hodnoty ciselneho typu decimal, provedou
     * patricnou operaci, ale jeji vysledek nevraci. Misto toho primo provedou zpracovani vysledku
     * pomoci volani metod asociovanych delegatu.
     *  
     * Trida je staticka, protoze od ni nepotrebujeme vytvaret zadne instance a realizuje nam jen
     * nejakou spolecnou skupinu metod, ktere vyuzivame (podobne jako treba tridy Console, Convert atp.).
     */ 

    // nejprve je nutne definovat jak bude delegat vypadat:
    // tento lze vyuzit pro vsechny metody, ktere berou jako vstup cislo typu decimal a nevraci nic (void)
    public delegate void ZobrazeniVysledku(decimal cislo);

    public static class ScitackaDelegovana
    {
        // * instance delegata bude soucasti nasi tridy jako tridni promenna
        // * trida je staticka, proto i tato promenna bude staticka
        // * pri definici je primo jeji hodnota nastavena na null - neni prirazena zadna metoda
        public static ZobrazeniVysledku zobrazeni = null;

        // jednotlive metody realizuji konkretni matematicke operace
        public static void Secti(decimal a, decimal b)
        {
            // vysledek operace ulozime do docasne promenne "pomocna"
            decimal pomocna = a + b;
            // zde si nejprve overujeme, zda je jiz nasi delegatove promenne prirazena nejaka metoda
            // - pokud neni, nic neprovadime (byla by vyvolana vyjimka a program by vyhodil chybu)
            // - pokud je, pak ji pres delegata zavolame (jako parametr je delegatu predana hodnota 
            //   vysledku operace ulozena v pomocne promenne)
            if (zobrazeni != null) zobrazeni(pomocna);
        }

        public static void Odecti(decimal a, decimal b)
        {
            decimal pomocna = a - b;
            if (zobrazeni != null) zobrazeni(pomocna);
        }

        public static void Vynasob(decimal a, decimal b)
        {
            decimal pomocna = a * b;
            if (zobrazeni != null) zobrazeni(pomocna);
        }

        public static void Vydel(decimal a, decimal b)
        {
            decimal pomocna = a / b;
            if (zobrazeni != null) zobrazeni(pomocna);
        }

    }
}
