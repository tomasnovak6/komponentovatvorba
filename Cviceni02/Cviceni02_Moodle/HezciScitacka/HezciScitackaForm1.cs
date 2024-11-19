using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HezciScitacka
{
    public partial class HezciScitackaForm1 : Form
    {
        public HezciScitackaForm1()
        {
            InitializeComponent();
        }

        /* U vsech nize uvedenych metod, ktere jsou event-handlery pro událost onClick vsech nami pouzitych
         * tlacitek, vyuzivame volani patricnych metod tridy Scitacka a jejich navratove hodnoty primo
         * prirazujeme do vlastnosti Text editacniho prvku textBox3, ktery slouzi k zobrazeni vysledku.
         * 
         * Aplikacni logika - tj. v tomto priklade zpusob vypoctu jednotlivych operaci - je od prezentacni
         * casti aplikace (naseho formulare) oddelena diky vytvoreni tridy Scitacka, jejiz metody pouze
         * volame, predavame jim parametry a zobrazujeme jejich vysledky.
         */
        private void button1_Click(object sender, EventArgs e)
        {
            /* protoze metody tridy Scitacka vraci hodnoty v ciselnem datovem typu decimal,
             * je nutne je pro prirazeni do vlastnosti Text (typu string) prekonvertovat na textovy
             * retezec. K tomu slouzi volani metody .ToString(), kterou implementuje vetsina trid
             * .NET Frameworku. 
             */
            textBox3.Text = Scitacka.Secti(hodnota1.Value, hodnota2.Value).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Scitacka.Odecti(hodnota1.Value, hodnota2.Value).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Scitacka.Vynasob(hodnota1.Value, hodnota2.Value).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Scitacka.Vydel(hodnota1.Value, hodnota2.Value).ToString();
        }
    }
}
