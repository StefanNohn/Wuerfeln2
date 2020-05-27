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

        private int _Punktegesamt;
        public int Punktegesamt
        {
            get
            {
                return ListePunkte.Sum();
            }
            set { }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public Spieler()
        {}

        public Spieler(string a, PunkteAusgabe b /*, Form1 d*/)
        {
            Name = a;
            PunkteAufLabel(b);           
            
        }
    }
}
