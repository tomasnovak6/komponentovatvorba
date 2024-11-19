using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HezciScitackaDelegat
{
    /* Tato varianta prikladu podobne jako HezciScitacka odstinuje implementaci aplikacni logiky od
     * prezentacni vrstvy aplikace. Narozdil od zminovaneho prikladu vsak vyuziva mechanismu delegatu
     * a vypis vysledku si jednotlive matematicke operace realizovane metodami tridy ScitackaDelegovana
     * zajistuji primo samy s vyuzitim delegata a metod, ktere jsou k nemu asociovane.
     */

    public partial class HezciScitackaForm1 : Form
    {
        public HezciScitackaForm1()
        {
            InitializeComponent();
            // v konstruktoru je nutne tride ScitackaDelegovana do jeji promenne "zobrazeni" pridat
            // konkretni instanci delegata spojenou s danou metodou, kterou ma volat;
            ScitackaDelegovana.zobrazeni += new ZobrazeniVysledku(VypisVysledek);
            ScitackaDelegovana.zobrazeni += new ZobrazeniVysledku(VypisTajnyVysledek);
            // v tomto pripade vyuzivame moznosti priradit k jednomu delegatu vice metod, ktere jsou
            // pak automaticky vsechny volany v pripade pouziti delegata
        }

        // toto je metoda, ktera vypisuje jakekoliv cislo typu decimal do TextBoxu nazvaneho "vysledek";
        // v nasem pripade ji vyuzivaji prostrednictvim delegata metody tridy ScitackaDelegovana k vypisu
        // vysledku 
        public void VypisVysledek(decimal cislo)
        {
            vysledek.Text = cislo.ToString();
        }

        // toto je obdobna metoda, ktera vypisuje hodnotu do textoveho popisku "label4";
        // pro samotnou praci aplikace neni potrebna, je zde jen na demonstraci mechanismu multicastingu
        public void VypisTajnyVysledek(decimal cislo)
        {
            label4.Text = cislo.ToString();
        }

        // jednotlive event-handlery zpracovavajici udalost kliknuti na patricne tlacitko;
        // oproti prikladu HezciScitacka obsahuji jen volani vypoctove metody s predanim patricnych 
        // parametru - "oblicej" aplikace se pak uz dale nestara o to, jak budou vysledky zobrazeny
        private void scitani_Click(object sender, EventArgs e)
        {
            ScitackaDelegovana.Secti(hodnota1.Value, hodnota2.Value);
        }

        private void odcitani_Click(object sender, EventArgs e)
        {
            ScitackaDelegovana.Odecti(hodnota1.Value, hodnota2.Value);
        }

        private void nasobeni_Click(object sender, EventArgs e)
        {
            ScitackaDelegovana.Vynasob(hodnota1.Value, hodnota2.Value);

        }

        private void deleni_Click(object sender, EventArgs e)
        {
            ScitackaDelegovana.Vydel(hodnota1.Value, hodnota2.Value);
        }

    }
}
