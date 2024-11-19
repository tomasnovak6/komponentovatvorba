using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HezciScitacka
{
    /* Trida Scitacka implementuje hlavni aplikacni logiku. Realizuje jednotlive operace, ktere
     * od nasi jednoduche kalkulacky chceme.
     * 
     * V teto podobe jednotlive metody berou jako parametry hodnoty ciselneho typu decimal, provedou
     * patricnou operaci a vraci jeji vysledek - opet jako decimal.
     * 
     * Trida je staticka, protoze od ni nepotrebujeme vytvaret zadne instance a realizuje nam jen
     * nejakou spolecnou skupinu metod, ktere vyuzivame (podobne jako treba tridy Console, Convert atp.).
     */ 
    public static class Scitacka
    {
        public static decimal Secti(decimal hodnota1, decimal hodnota2)
        {
            return hodnota1 + hodnota2;
        }
        public static decimal Odecti(decimal hodnota1, decimal hodnota2)
        {
            return hodnota1 - hodnota2;
        }
        public static decimal Vynasob(decimal hodnota1, decimal hodnota2)
        {
            return hodnota1 * hodnota2;
        }
        public static decimal Vydel(decimal hodnota1, decimal hodnota2)
        {
            return hodnota1 / hodnota2;
        }
    }
}
