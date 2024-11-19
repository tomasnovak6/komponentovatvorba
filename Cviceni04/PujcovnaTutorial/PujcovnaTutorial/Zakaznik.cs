using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PujcovnaTutorial
{
    [Serializable()]
    public class Zakaznik : INotifyPropertyChanged
    {
        private string _jmeno;
        private string _prijmeni;
        private string _adresa;
        private int _rokNarozeni;

        public string Jmeno {
            get { return _jmeno; }
            set
            {
                if (_jmeno != value)
                {
                    _jmeno = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Prijmeni
        {
            get { return _prijmeni; }
            set
            {
                if (_prijmeni != value)
                {
                    _prijmeni = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Adresa
        {
            get { return _adresa; }
            set
            {
                if (_adresa != value)
                {
                    _adresa = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int RokNarozeni
        {
            get { return _rokNarozeni; }
            set
            {
                if (_rokNarozeni != value)
                {
                    _rokNarozeni = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged("Plnolety");
                }
            }
        }

        public bool Plnolety
        {
            get { return (DateTime.Today.Year - RokNarozeni) >= 18; }
        }

        public BindingList<Disk> Vypujcene { get; private set; } = new BindingList<Disk>();

        public Zakaznik(string jmeno, string prijmeni, string adresa, int rokNarozeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Adresa = adresa;
            RokNarozeni = rokNarozeni;
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
