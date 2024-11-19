using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovniPrikladPatek
{
    public class Ucet
    {
        public string Majitel { get; set; }
        public float Zustatek { get; private set; } = 0;
        public float Kontokorent { get; private set; } = 0;
        public float DisponibilniCastka
        {
            get { return Zustatek + Kontokorent; }
        }

        public Ucet(string majitel)
        {
            Majitel = majitel;
        }

        public Ucet(string majitel, float zustatek, float kontokorent = 0) : this(majitel)
        {
            Zustatek = zustatek;
            Kontokorent = kontokorent;
        }

        public override string ToString()
        {
            return String.Format("Majitel {0} má na účtu zůstatek {1} $ a disponibilní částku {2} $.",
                Majitel, Zustatek, DisponibilniCastka);
        }

        public void Vklad(float castka)
        {
            if (castka <= 0)
                throw new InvalidAmountException("Částka musí být větší než 0!");
            else
                Zustatek += castka;
        }

        public void Vyber(float castka)
        {
            if (castka <= 0)
                throw new InvalidAmountException("Částka musí být větší než 0!");
            else
                if (castka > DisponibilniCastka)
                throw new BalanceException("Nelze vybrat více než je zůstatek!");
            else
                Zustatek -= castka;
        }
    }
}
