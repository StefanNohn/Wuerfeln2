using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Würfeln
{
    public class Spieler
    {        
        private List<int> ListePunkte = new List<int>();
               
        public delegate void PunkteAusgabe(int SpielerNr, int Punkte);
        private PunkteAusgabe _PunkteAufLabel = null;
        public void PunkteAufLabel(PunkteAusgabe a)
        {
            _PunkteAufLabel += a;
        }
        public delegate void SpielerStatus(object Spieler, bool AktivInaktiv);
        private SpielerStatus _AktivInaktiv;
        public void AktivInaktiv(SpielerStatus a)
        {
            _AktivInaktiv += a;
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private bool _Aktiv;
        public bool Aktiv
        {
            get { return _Aktiv; }
            set
            {
                _Aktiv = value;
                if (_Aktiv)
                {
                    _AktivInaktiv(this, true);
                }
                if (!_Aktiv)
                {
                    _AktivInaktiv(this, false);
                }
            }
        }

        public Spieler()
        {}

        public Spieler(PunkteAusgabe b, SpielerStatus c /*, Form1 d*/)
        {
            Name = "Neuer Spieler";
            PunkteAufLabel(b);
            ListePunkte.Add(0);
            AktivInaktiv(c);
            //Aktiv = false;           
        }
    }
}
