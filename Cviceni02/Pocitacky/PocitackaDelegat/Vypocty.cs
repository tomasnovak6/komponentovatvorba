using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocitactkaDelegat
{
    public static class Vypocty
    {
        public delegate void VystupVysledku(string s);

        public static VystupVysledku Vystup { get; set; } = null;

        public static void Soucet(int a, int b) => Vystup?.Invoke((a + b).ToString());
        public static void Rozdil(int a, int b) => Vystup?.Invoke((a - b).ToString());
        public static void Soucin(int a, int b) => Vystup?.Invoke((a * b).ToString());
        public static void Podil(double a, double b) => Vystup?.Invoke((a / b).ToString());

    }


    
}
