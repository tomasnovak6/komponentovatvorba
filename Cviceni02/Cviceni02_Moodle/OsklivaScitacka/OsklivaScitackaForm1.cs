using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OsklivaScitacka
{
    /* Oskliva verze naseho prikladu. Demonstruje, ze funkcniho programu lze dosahnout jen s vyuzitim
     * event-handleru jednotlivych udalosti (v nasem pripade se jedna o udalost kliknuti na tlacitko).
     * 
     * Veskera aplikacni logika je realizovana jen v techto metodach, dalsi rozsireni aplikace je velmi
     * komplikovane a pokud by stejne algoritmy mely byt vyuzity i na jinem miste aplikace, bylo  by
     * nutne je psat znovu.
     * 
     * Resenim odstranujicim vyse zminene nedostatky je vyuziti samostatne tridy, ktera implementuje
     * aplikacni logiku - viz priklady HezciScitacka a HezciScitackaDelegat.
     */


    public partial class OsklivaScitackaForm1 : Form
    {
        public OsklivaScitackaForm1()
        {
            InitializeComponent();
        }

        /* jednotlive event-handlery realizujici matematicke operace:
         * 
         * - vsimnete si, ze vstupni prvky TextBox vraci textovy retezec, ktery je nutne pomoci volani
         *   metod tridy Convert prevest na cislo typu decimal a teprve pak lze spravne obe vstupni
         *   hodnoty zpracovat pomoci matematickeho operatoru.
         * - vysledna hodnota je typu decimal, ktery ovsem nelze priradit do vlastnosti Text u prvku
         *   zobrazujiciho vysledky - proto je nutne na vysledek aplikovat jeste volani metody .ToString(),
         *   ktera u vetsiny datovych typu a casti trid .NET Frameworku zpusobi jejich prevod na textovou
         *   reprezentaci.
         */
        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDecimal(textBox1.Text) + Convert.ToDecimal(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDecimal(textBox1.Text) - Convert.ToDecimal(textBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDecimal(textBox1.Text) * Convert.ToDecimal(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDecimal(textBox1.Text) / Convert.ToDecimal(textBox2.Text)).ToString();
        }
    }
}
