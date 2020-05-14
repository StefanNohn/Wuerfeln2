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
        private List<Spieler> Namesliste = new List<Spieler>()
        {
            
        };

        //private struct Übersicht      Die Klasse stellt an sich schon eine bessere Struktur und Wertesammlung dar...
        //{
        //    string Name;
        //    List<int> Punkte;    
        //}
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

        public Spieler(string a, Punktannahme b, Punkteauslesen c, Form1 d)
        {
            Name = a;
            Punkteschreiben(b);
            Punktegesamtlesen(c);
            switch (a)
            {
                case "Spieler5":
                    Label d.LabelSpieler5 = new System.Windows.Forms.Label();
                    d.LabelSpieler5.AutoSize = true;
                    d.LabelSpieler5.Location = new System.Drawing.Point(12, 9);
                    d.LabelSpieler5.Name = "LabelSpieler1";
                    d.LabelSpieler5.Size = new System.Drawing.Size(98, 13);
                    d.LabelSpieler5.TabIndex = 0;
                    d.LabelSpieler5.Text = "Spieler 5 auto";
                    d.LabelSpieler5.Leave += new System.EventHandler(this.LabelSpieler5_Leave);
                    d.LabelSpieler5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelSpieler1_MouseClick);
                    d.Controls.Add(d.LabelSpieler5);
                    break;
            }
        }
    }
}
