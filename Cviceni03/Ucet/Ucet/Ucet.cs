using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ucet
{
    public string Majitel { get; set; }
    public float Zustatek { get; set; } = 0;
    public float Kontokorent { get; set; } = 0;
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

    public void Vklad(float castka)
    {
        if (castka > 0)
        {
            Zustatek += castka;
        } else
        {
            throw new AmountException();
        }
        
    }

    public void Vyber(float castka)
    {
        if (castka <= 0)
        {
            throw new AmountException();
        } else
        {
            if (castka > DisponibilniCastka)
            {
                throw new AvailableTotalException();
            } else
            {
                Zustatek -= castka;
            }
        }
        
    }

    public override string ToString()
    {
        return String.Format("Majitel {0} ma na uctu zustatek {1} $ a disponibilni castku {2} $.",
                Majitel, Zustatek, DisponibilniCastka);
    }
}
