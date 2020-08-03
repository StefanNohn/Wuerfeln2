using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Würfeln
{
    public class Spieler
    {
        public static Spieler[] ListeSpieler = new Spieler[10];
        public static Label[] ListeLabelSpieler = new Label[10];
        public static Label[] ListeLabelRunde = new Label[10];
        public static ComboBox[] ListeComboBoxSpieler = new ComboBox[10];
        public static Label[] ListeLabelRundeAnzeige = new Label[10];
        public static Label[] ListeLabelPunkte = new Label[10];
        public static Label[] ListeLabelPunkteAnzeige = new Label[10];
        public static TextBox[] ListeTextBoxSpieler = new TextBox[10];

        const int Reihe = 12;
        const int P1 = 9;

        private List<int> ListePunkte = new List<int>();

        public delegate void PunkteAusgabe(int SpielerNr, int Punkte);
        private PunkteAusgabe _PunkteAufLabel = null;
        public void PunkteAufLabel(PunkteAusgabe a)
        {
            _PunkteAufLabel += a;
        }
        //public delegate void SpielerStatus(object Spieler, bool AktivInaktiv);
        //private SpielerStatus _AktivInaktiv;
        //public void AktivInaktiv(SpielerStatus a)
        //{
        //    _AktivInaktiv += a;
        //}

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private int _Nr;
        public int Nr
        {
            get { return _Nr; }
            set { _Nr = value; }
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
                    Form1.SpielerAktivInaktiv(this, true);
                }
                if (!_Aktiv)
                {
                    Form1.SpielerAktivInaktiv(this, false);
                }
            }
        }

        public Spieler()
        { }

        public Spieler(PunkteAusgabe b,/* SpielerStatus c,*/ int i)
        {
            Name = "Neuer Spieler";
            PunkteAufLabel(b);
            ListePunkte.Add(0);
            Nr = i;
            //AktivInaktiv(c);
            if (i == 0) Aktiv = true;
            else Aktiv = false;
            //erstellen der Anzeigen von Spielername, Spielertypauswahl, Rundenanzeige und Punkteanzeige
            ListeLabelSpieler[i] = new Label();
            ListeLabelSpieler[i].AutoSize = true;
            ListeLabelSpieler[i].Size = new System.Drawing.Size(100, 13);
            ListeLabelSpieler[i].Location = new System.Drawing.Point(P1, Reihe + 24 * i);
            ListeLabelSpieler[i].TabIndex = 0;
            ListeLabelSpieler[i].Text = "Spieler";
            ListeLabelSpieler[i].MouseClick += new System.Windows.Forms.MouseEventHandler (LabelSpieler_MouseClick);

            ListeTextBoxSpieler[i] = new TextBox();
            ListeTextBoxSpieler[i].Visible = false;
                      
            ListeComboBoxSpieler[i] = new ComboBox();
            ListeComboBoxSpieler[i].FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            ListeComboBoxSpieler[i].FormattingEnabled = true;
            ListeComboBoxSpieler[i].Items.AddRange(new object[] {
                "Mensch",
                "KI - ängstlich",
                "KI - normal",
                "KI - risiko"});
            ListeComboBoxSpieler[i].Visible = true;
            ListeComboBoxSpieler[i].Size = new System.Drawing.Size(92, 21);
            ListeComboBoxSpieler[i].Location = new System.Drawing.Point(P1 + 92, Reihe - 3 + 24 * i);
            ListeComboBoxSpieler[i].TabIndex = 9;
            ListeComboBoxSpieler[i].SelectedValueChanged += new System.EventHandler(this.ComboBoxSpieler_SelectedValueChanged);

            ListeLabelRundeAnzeige[i] = new Label();
            ListeLabelRundeAnzeige[i].Location = new System.Drawing.Point(P1 + 200, Reihe + 24 * i);
            ListeLabelRundeAnzeige[i].AutoSize = true;
            ListeLabelRundeAnzeige[i].TabIndex = 0;
            ListeLabelRundeAnzeige[i].Text = "Runde: ";

            ListeLabelRunde[i] = new Label();
            ListeLabelRunde[i].AutoSize = true;
            ListeLabelRunde[i].Location = new System.Drawing.Point(P1 + 260, Reihe + 24 * i);
            ListeLabelRunde[i].TabIndex = 0;
            ListeLabelRunde[i].Text = $"{Form1.Runde}";

            ListeLabelPunkte[i] = new Label();
            ListeLabelPunkte[i].AutoSize = true;
            ListeLabelPunkte[i].Location = new System.Drawing.Point(P1 + 280, Reihe + 24 * i);
            ListeLabelPunkte[i].TabIndex = 0;
            ListeLabelPunkte[i].Text = "Punkte: ";

            ListeLabelPunkteAnzeige[i] = new Label();
            ListeLabelPunkteAnzeige[i].AutoSize = true;
            ListeLabelPunkteAnzeige[i].Location = new System.Drawing.Point(P1 + 330, Reihe + 24 * i);
            ListeLabelPunkteAnzeige[i].TabIndex = 0;
            ListeLabelPunkteAnzeige[i].TextAlign = System.Drawing.ContentAlignment.TopRight;
            ListeLabelPunkteAnzeige[i].Text = "123456";
        }

        public static void LabelSpieler_MouseClick(object sender, MouseEventArgs e)
        {                       
            int Sender = WerIstSender(sender);
            //if (ComboBoxSpieler1.SelectedIndex == 0)    Erlaubt nur die Benennung eines menschlichen Spielers, nimmt aber Moeglichkeiten und evtl. Spassfaktor
            //{
            //ListeTextBoxSpieler[Sender].AutoSize = true;
            Spieler.ListeTextBoxSpieler[Sender].Location = new Point(Spieler.ListeLabelSpieler[Sender].Location.X, Spieler.ListeLabelSpieler[Sender].Location.Y - 2);
            Spieler.ListeTextBoxSpieler[Sender].Text = Spieler.ListeLabelSpieler[Sender].Text;
            Spieler.ListeTextBoxSpieler[Sender].KeyDown += new System.Windows.Forms.KeyEventHandler(TextBoxSpieler_KeyDown);
            Spieler.ListeTextBoxSpieler[Sender].Leave += new System.EventHandler(Spieler.TextBoxSpieler_Leave);
            Spieler.ListeTextBoxSpieler[Sender].Visible = true;
            Spieler.ListeLabelSpieler[Sender].Visible = false;
            Spieler.ListeTextBoxSpieler[Sender].AcceptsReturn = false;
            // Form1.Controls.Add(Spieler.ListeTextBoxSpieler[Sender]);
            //}
        }
        public static void TextBoxSpieler_KeyDown(object sender, KeyEventArgs e)
        {
            int Sender = WerIstSender(sender);

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Escape))
            {
                if (ListeTextBoxSpieler[Sender].Text.Length >= 1)
                {
                    ListeLabelSpieler[Sender].Text = ListeTextBoxSpieler[Sender].Text;
                }
                else ListeLabelSpieler[Sender].Text = "Ohne Namen";
                e.Handled = true;
                e.SuppressKeyPress = true;
                ListeTextBoxSpieler[Sender].Visible = false;
                ListeLabelSpieler[Sender].Visible = true;
            }
        }
        public static void TextBoxSpieler_Leave(object sender, EventArgs e)
        {
            int Sender = WerIstSender(sender);


            if (ListeTextBoxSpieler[Sender].Text.Length >= 1)
            {
                ListeLabelSpieler[Sender].Text = ListeTextBoxSpieler[Sender].Text;
            }
            else ListeLabelSpieler[Sender].Text = "Ohne Namen";

            ListeTextBoxSpieler[Sender].Visible = false;
            ListeLabelSpieler[Sender].Visible = true;
        }

        public void ComboBoxSpieler_SelectedValueChanged(object sender, EventArgs e)
        {
            int Sender = WerIstSender(sender);
            ListeLabelSpieler[Sender].Text = ListeComboBoxSpieler[Sender].Items[ListeComboBoxSpieler[Sender].SelectedIndex].ToString();
        }

        public static int WerIstSender(object sender)
        {
            int a = 0;
            for (int i = 0; i < 10; i++)
            {
                if ((sender == Spieler.ListeLabelSpieler[i]) || (sender == Spieler.ListeTextBoxSpieler[i]) || (sender == Spieler.ListeComboBoxSpieler[i]) || (sender == Spieler.ListeSpieler[i]))
                { a = i; }
            };
            return a;
        }
    }
}
