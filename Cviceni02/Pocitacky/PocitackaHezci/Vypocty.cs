using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PocitackaHezci
{
    public static class Vypocty
    {
       
        public static int Soucet(int a, int b)
        {
            return a + b;
        }
        
        public static int Rozdil(int a, int b)
        {
            return a - b;
        }

        public static int Soucin(int a, int b)
        {
            return a * b;
        }

        public static double Podil(int a, int b)
        {
            return a / b;
        }

        public static string Soucet(string a, string b)
        {
            return Soucet(Convert.ToInt32(a), Convert.ToInt32(b)).ToString();
        }

        public static string Rozdil(string a, string b)
        {
            return Rozdil(Convert.ToInt32(a), Convert.ToInt32(b)).ToString();
        }

        public static string Soucin(string a, string b)
        {
            return Soucin(Convert.ToInt32(a), Convert.ToInt32(b)).ToString();
        }

        public static string Podil(string a, string b)
        {
            return Podil(Convert.ToInt32(a), Convert.ToInt32(b)).ToString();
        }
    }
}
