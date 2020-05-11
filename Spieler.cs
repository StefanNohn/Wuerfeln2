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
        private List<Spieler> Namesliste = new List<Spieler>();

        public delegate void Punktannahme(int Punkte, int Liste);
        private Punktannahme Punkteannahme = null;
        public void Punkteschreiben(Punktannahme a)
        {
            Punkteannahme += a;
        }


        public delegate int Punkteauslesen(int Liste);
        private Punkteauslesen Punktelesen = null;
        public void Punktegesamtlesen(Punkteauslesen a)
        {
            Punktelesen += a;
        }

        private int _Punktegesamt;
        public int Punktegesamt
        {
            get
            {
                switch (Name)
                {
                    case "Spieler1":
                        return Punktelesen(1);
                    case "Spieler2":
                        return Punktelesen(2);
                    case "Spieler3":
                        return Punktelesen(3);
                    case "Spieler4":
                        return Punktelesen(4);
                    default:
                        MessageBox.Show("Gesamtpunkteauslesen mit Fehler");
                        return 0;
                }

            }
            set { }
        }


        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public Spieler(string a, Punktannahme b, Punkteauslesen c)
        {
            Name = a;
            Punkteschreiben(b);
            Punktegesamtlesen(c);
        }
    }
}
