using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Würfeln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Spieler Spieler1 = new Spieler("Spieler1", PunkteAnzeigen, SpielerAktivInaktiv /*, this*/);
            Spieler Spieler2 = new Spieler("Spieler2", PunkteAnzeigen, SpielerAktivInaktiv /*, this*/);
            Spieler Spieler3 = new Spieler("Spieler3", PunkteAnzeigen, SpielerAktivInaktiv /*, this*/);
            Spieler Spieler4 = new Spieler("Spieler4", PunkteAnzeigen, SpielerAktivInaktiv /*, this*/);
            Spieler Spieler5 = new Spieler("Spieler5", PunkteAnzeigen, SpielerAktivInaktiv /*, this*/);
            Spieler Spieler6 = new Spieler("Spieler6", PunkteAnzeigen, SpielerAktivInaktiv  /*, this*/);
            Spieler Spieler7 = new Spieler("Spieler7", PunkteAnzeigen, SpielerAktivInaktiv /*, this*/);
            Spieler Spieler8 = new Spieler("Spieler8", PunkteAnzeigen, SpielerAktivInaktiv /*, this*/);
            Spieler Spieler9 = new Spieler("Spieler9", PunkteAnzeigen, SpielerAktivInaktiv  /*, this*/);
            Spieler Spieler10 = new Spieler("Spieler10", PunkteAnzeigen, SpielerAktivInaktiv /*, this*/);
            ListeSpieler.Add(Spieler1);
            ListeSpieler.Add(Spieler2);
            ListeSpieler.Add(Spieler3);
            ListeSpieler.Add(Spieler4);
            ListeSpieler.Add(Spieler5);
            ListeSpieler.Add(Spieler6);
            ListeSpieler.Add(Spieler7);
            ListeSpieler.Add(Spieler8);
            ListeSpieler.Add(Spieler9);
            ListeSpieler.Add(Spieler10);

            Label LabelSpieler1Name = new Label();
            Label LabelSpieler2Name = new Label();
            Label LabelSpieler3Name = new Label();
            Label LabelSpieler4Name = new Label();
            Label LabelSpieler5Name = new Label();
            Label LabelSpieler6Name = new Label();
            Label LabelSpieler7Name = new Label();
            Label LabelSpieler8Name = new Label();
            Label LabelSpieler9Name = new Label();
            Label LabelSpieler10Name = new Label();
            ListeLabelSpieler.Add(LabelSpieler1Name);
            ListeLabelSpieler.Add(LabelSpieler2Name);
            ListeLabelSpieler.Add(LabelSpieler3Name);
            ListeLabelSpieler.Add(LabelSpieler4Name);
            ListeLabelSpieler.Add(LabelSpieler5Name);
            ListeLabelSpieler.Add(LabelSpieler6Name);
            ListeLabelSpieler.Add(LabelSpieler7Name);
            ListeLabelSpieler.Add(LabelSpieler8Name);
            ListeLabelSpieler.Add(LabelSpieler9Name);
            ListeLabelSpieler.Add(LabelSpieler10Name);

            TextBox TextBoxSpieler1 = new TextBox();
            TextBox TextBoxSpieler2 = new TextBox();
            TextBox TextBoxSpieler3 = new TextBox();
            TextBox TextBoxSpieler4 = new TextBox();
            TextBox TextBoxSpieler5 = new TextBox();
            TextBox TextBoxSpieler6 = new TextBox();
            TextBox TextBoxSpieler7 = new TextBox();
            TextBox TextBoxSpieler8 = new TextBox();
            TextBox TextBoxSpieler9 = new TextBox();
            TextBox TextBoxSpieler10 = new TextBox();
            ListeTextBoxSpieler.Add(TextBoxSpieler1);
            ListeTextBoxSpieler.Add(TextBoxSpieler2);
            ListeTextBoxSpieler.Add(TextBoxSpieler3);
            ListeTextBoxSpieler.Add(TextBoxSpieler4);
            ListeTextBoxSpieler.Add(TextBoxSpieler5);
            ListeTextBoxSpieler.Add(TextBoxSpieler6);
            ListeTextBoxSpieler.Add(TextBoxSpieler7);
            ListeTextBoxSpieler.Add(TextBoxSpieler8);
            ListeTextBoxSpieler.Add(TextBoxSpieler9);
            ListeTextBoxSpieler.Add(TextBoxSpieler10);


            ComboBox ComboBoxSpieler1 = new ComboBox();
            ComboBox ComboBoxSpieler2 = new ComboBox();
            ComboBox ComboBoxSpieler3 = new ComboBox();
            ComboBox ComboBoxSpieler4 = new ComboBox();
            ComboBox ComboBoxSpieler5 = new ComboBox();
            ComboBox ComboBoxSpieler6 = new ComboBox();
            ComboBox ComboBoxSpieler7 = new ComboBox();
            ComboBox ComboBoxSpieler8 = new ComboBox();
            ComboBox ComboBoxSpieler9 = new ComboBox();
            ComboBox ComboBoxSpieler10 = new ComboBox();
            ListeComboBoxSpieler.Add(ComboBoxSpieler1);
            ListeComboBoxSpieler.Add(ComboBoxSpieler2);
            ListeComboBoxSpieler.Add(ComboBoxSpieler3);
            ListeComboBoxSpieler.Add(ComboBoxSpieler4);
            ListeComboBoxSpieler.Add(ComboBoxSpieler5);
            ListeComboBoxSpieler.Add(ComboBoxSpieler6);
            ListeComboBoxSpieler.Add(ComboBoxSpieler7);
            ListeComboBoxSpieler.Add(ComboBoxSpieler8);
            ListeComboBoxSpieler.Add(ComboBoxSpieler9);
            ListeComboBoxSpieler.Add(ComboBoxSpieler10);

            Label LabelRunde1 = new Label();
            Label LabelRunde2 = new Label();
            Label LabelRunde3 = new Label();
            Label LabelRunde4 = new Label();
            Label LabelRunde5 = new Label();
            Label LabelRunde6 = new Label();
            Label LabelRunde7 = new Label();
            Label LabelRunde8 = new Label();
            Label LabelRunde9 = new Label();
            Label LabelRunde10 = new Label();
            ListeLabelRunde.Add(LabelRunde1);
            ListeLabelRunde.Add(LabelRunde2);
            ListeLabelRunde.Add(LabelRunde3);
            ListeLabelRunde.Add(LabelRunde4);
            ListeLabelRunde.Add(LabelRunde5);
            ListeLabelRunde.Add(LabelRunde6);
            ListeLabelRunde.Add(LabelRunde7);
            ListeLabelRunde.Add(LabelRunde8);
            ListeLabelRunde.Add(LabelRunde9);
            ListeLabelRunde.Add(LabelRunde10);

            Label LabelRundeAnzeige1 = new Label();
            Label LabelRundeAnzeige2 = new Label();
            Label LabelRundeAnzeige3 = new Label();
            Label LabelRundeAnzeige4 = new Label();
            Label LabelRundeAnzeige5 = new Label();
            Label LabelRundeAnzeige6 = new Label();
            Label LabelRundeAnzeige7 = new Label();
            Label LabelRundeAnzeige8 = new Label();
            Label LabelRundeAnzeige9 = new Label();
            Label LabelRundeAnzeige10 = new Label();
            ListeLabelRundeAnzeige.Add(LabelRundeAnzeige1);
            ListeLabelRundeAnzeige.Add(LabelRundeAnzeige2);
            ListeLabelRundeAnzeige.Add(LabelRundeAnzeige3);
            ListeLabelRundeAnzeige.Add(LabelRundeAnzeige4);
            ListeLabelRundeAnzeige.Add(LabelRundeAnzeige5);
            ListeLabelRundeAnzeige.Add(LabelRundeAnzeige6);
            ListeLabelRundeAnzeige.Add(LabelRundeAnzeige7);
            ListeLabelRundeAnzeige.Add(LabelRundeAnzeige8);
            ListeLabelRundeAnzeige.Add(LabelRundeAnzeige9);
            ListeLabelRundeAnzeige.Add(LabelRundeAnzeige10);

            Label LabelPunkte1 = new Label();
            Label LabelPunkte2 = new Label();
            Label LabelPunkte3 = new Label();
            Label LabelPunkte4 = new Label();
            Label LabelPunkte5 = new Label();
            Label LabelPunkte6 = new Label();
            Label LabelPunkte7 = new Label();
            Label LabelPunkte8 = new Label();
            Label LabelPunkte9 = new Label();
            Label LabelPunkte10 = new Label();
            ListeLabelPunkte.Add(LabelPunkte1);
            ListeLabelPunkte.Add(LabelPunkte2);
            ListeLabelPunkte.Add(LabelPunkte3);
            ListeLabelPunkte.Add(LabelPunkte4);
            ListeLabelPunkte.Add(LabelPunkte5);
            ListeLabelPunkte.Add(LabelPunkte6);
            ListeLabelPunkte.Add(LabelPunkte7);
            ListeLabelPunkte.Add(LabelPunkte8);
            ListeLabelPunkte.Add(LabelPunkte9);
            ListeLabelPunkte.Add(LabelPunkte10);

            Label LabelPunkteAnzeige1 = new Label();
            Label LabelPunkteAnzeige2 = new Label();
            Label LabelPunkteAnzeige3 = new Label();
            Label LabelPunkteAnzeige4 = new Label();
            Label LabelPunkteAnzeige5 = new Label();
            Label LabelPunkteAnzeige6 = new Label();
            Label LabelPunkteAnzeige7 = new Label();
            Label LabelPunkteAnzeige8 = new Label();
            Label LabelPunkteAnzeige9 = new Label();
            Label LabelPunkteAnzeige10 = new Label();
            ListeLabelPunkteAnzeige.Add(LabelPunkteAnzeige1);
            ListeLabelPunkteAnzeige.Add(LabelPunkteAnzeige2);
            ListeLabelPunkteAnzeige.Add(LabelPunkteAnzeige3);
            ListeLabelPunkteAnzeige.Add(LabelPunkteAnzeige4);
            ListeLabelPunkteAnzeige.Add(LabelPunkteAnzeige5);
            ListeLabelPunkteAnzeige.Add(LabelPunkteAnzeige6);
            ListeLabelPunkteAnzeige.Add(LabelPunkteAnzeige7);
            ListeLabelPunkteAnzeige.Add(LabelPunkteAnzeige8);
            ListeLabelPunkteAnzeige.Add(LabelPunkteAnzeige9);
            ListeLabelPunkteAnzeige.Add(LabelPunkteAnzeige10);

            ListeDice.Add(Dice1);
            ListeDice.Add(Dice2);
            ListeDice.Add(Dice3);
            ListeDice.Add(Dice4);
            ListeDice.Add(Dice5);
            ListeDice.Add(Dice6);
        }

        private List<Spieler> ListeSpieler = new List<Spieler>();
        private List<Label> ListeLabelSpieler = new List<Label>();
        private List<ComboBox> ListeComboBoxSpieler = new List<ComboBox>();
        private List<Label> ListeLabelRunde = new List<Label>();
        private List<Label> ListeLabelRundeAnzeige = new List<Label>();
        private List<Label> ListeLabelPunkte = new List<Label>();
        private List<Label> ListeLabelPunkteAnzeige = new List<Label>();
        private List<TextBox> ListeTextBoxSpieler = new List<TextBox>();
        private List<Dice> ListeDice = new List<Dice>();

        private int _Runde=0;
        public int Runde
        {
            get { return _Runde; }
            set { _Runde = value; }
        }

        private int _AngelegteSpieler = 0;
        public int AngelegterSpieler
        {
            get { return _AngelegteSpieler; }
            set { _AngelegteSpieler = value; }
        }
        const int Reihe = 12;
        const int P1 = 9;
        public void SpielerHinzufügen()
        {
            if (AngelegterSpieler < 10)
            {
                Label Stempel = new Label();
                Stempel.AutoSize = true;
                Stempel.Location = new System.Drawing.Point(P1, Reihe + 24 * AngelegterSpieler);
                Stempel.Name = ListeLabelSpieler[AngelegterSpieler].Name;
                Stempel.Size = new System.Drawing.Size(100, 13);
                Stempel.TabIndex = 0;
                Stempel.Text = ListeSpieler[AngelegterSpieler].Name;                
                Stempel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelSpieler_MouseClick);
                ListeLabelSpieler[AngelegterSpieler] = Stempel;               
                this.Controls.Add(ListeLabelSpieler[AngelegterSpieler]);

                ComboBox Stempel1 = new ComboBox();
                Stempel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                Stempel1.FormattingEnabled = true;
                Stempel1.Items.AddRange(new object[] {
                "Mensch",
                "KI - ängstlich",
                "KI - normal",
                "KI - risiko"});
                Stempel1.Visible = true;
                Stempel1.Location = new System.Drawing.Point(P1 + 92, Reihe-3 + 24 * AngelegterSpieler);
                Stempel1.Name = ListeComboBoxSpieler[AngelegterSpieler].Name;
                Stempel1.Size = new System.Drawing.Size(92, 21);
                Stempel1.TabIndex = 9;
                Stempel1.SelectedValueChanged += new System.EventHandler(this.ComboBoxSpieler_SelectedValueChanged);
                ListeComboBoxSpieler[AngelegterSpieler] = Stempel1;
                this.Controls.Add(ListeComboBoxSpieler[AngelegterSpieler]);

                Label Stempel2 = new Label();
                Stempel2.AutoSize = true;
                Stempel2.Location = new System.Drawing.Point(P1 + 200, Reihe + 24 * AngelegterSpieler);
                Stempel2.Name = ListeLabelRunde[AngelegterSpieler].Name;
                Stempel2.TabIndex = 0;
                Stempel2.Text = "Runde: ";
                ListeLabelRunde[AngelegterSpieler] = Stempel2;
                this.Controls.Add(ListeLabelRunde[AngelegterSpieler]);

                Label Stempel3 = new Label();
                Stempel3.AutoSize = true;
                Stempel3.Location = new System.Drawing.Point(P1 + 260, Reihe + 24 * AngelegterSpieler);
                Stempel3.Name = ListeLabelRundeAnzeige[AngelegterSpieler].Name;
                Stempel3.TabIndex = 0;
                Stempel3.Text = $"{Runde}";
                ListeLabelRunde[AngelegterSpieler] = Stempel3;
                this.Controls.Add(ListeLabelRunde[AngelegterSpieler]);

                Label Stempel4 = new Label();
                Stempel4.AutoSize = true;
                Stempel4.Location = new System.Drawing.Point(P1 + 280, Reihe + 24 * AngelegterSpieler);
                Stempel4.Name = ListeLabelPunkte[AngelegterSpieler].Name;
                Stempel4.TabIndex = 0;
                Stempel4.Text = "Punkte: ";              
                ListeLabelPunkte[AngelegterSpieler] = Stempel4;
                this.Controls.Add(ListeLabelPunkte[AngelegterSpieler]);

                Label Stempel5 = new Label();
                Stempel5.AutoSize = true;
                Stempel5.Location = new System.Drawing.Point(P1 + 330, Reihe + 24 * AngelegterSpieler);
                Stempel5.Name = ListeLabelPunkteAnzeige[AngelegterSpieler].Name;
                Stempel5.TabIndex = 0;
                Stempel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
                Stempel5.Text = "123456";
                ListeLabelPunkteAnzeige[AngelegterSpieler] = Stempel5;
                this.Controls.Add(ListeLabelPunkteAnzeige[AngelegterSpieler]);                              

                AngelegterSpieler++;
            }            
        }
         
        private void PunkteAnzeigen(int SpielerNr, int Punkte)
        {
            int a = Convert.ToInt32(ListeLabelPunkte[SpielerNr].Text);
            ListeLabelPunkte[SpielerNr].Text = Convert.ToString(Punkte + a);
        }

        private int WerIstSender(object sender)
        {           
            int a = 10;
            for (int i=0;i<10;i++)
            {
                if ((sender == ListeLabelSpieler[i]) || (sender == ListeTextBoxSpieler[i]) || (sender== ListeComboBoxSpieler[i]) || (sender == ListeSpieler[i]))
                { a= i; }
            };
            return a;
        }
        private void LabelSpieler_MouseClick(object sender, MouseEventArgs e)
        {
            int Sender= WerIstSender(sender);
            //if (ComboBoxSpieler1.SelectedIndex == 0)    Erlaubt nur die Benennung eines menschlichen Spielers, nimmt aber Moeglichkeiten und evtl. Spassfaktor
            //{
            //ListeTextBoxSpieler[Sender].AutoSize = true;
            ListeTextBoxSpieler[Sender].Location = new Point(ListeLabelSpieler[Sender].Location.X, ListeLabelSpieler[Sender].Location.Y-2);
            ListeTextBoxSpieler[Sender].Text = ListeLabelSpieler[Sender].Text;
            ListeTextBoxSpieler[Sender].KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSpieler_KeyDown);
            ListeTextBoxSpieler[Sender].Visible = true;
            ListeLabelSpieler[Sender].Visible = false;
            ListeTextBoxSpieler[Sender].AcceptsReturn = false;
            this.Controls.Add(ListeTextBoxSpieler[Sender]);
            //}
        }
        private void TextBoxSpieler_KeyDown(object sender, KeyEventArgs e)
        {
            int Sender = WerIstSender(sender);
               
            if ((e.KeyCode == Keys.Enter)||(e.KeyCode == Keys.Escape))
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
        private void ComboBoxSpieler_SelectedValueChanged(object sender, EventArgs e)
        {
            int Sender = WerIstSender(sender);
            ListeLabelSpieler[Sender].Text = ListeComboBoxSpieler[Sender].Items[ListeComboBoxSpieler[Sender].SelectedIndex].ToString();           
        }
               
        private int WelcherDice(object sender)
        {
            int a=11;
            for (int i=0;i<6;i++)
            {
                if (sender == ListeDice[i])
                {
                    a = i;
                }
            }
            return a;
        }
        private void Clicked(int Sender)
        {
            if (!ListeDice[Sender].Used)
            {
                ListeDice[Sender].Used = true;
            }
            else ListeDice[Sender].Used = false;
        }
        private void Dice_Click(object sender, EventArgs e)
        {
            int Sender=WelcherDice(sender);
            Clicked(Sender);            
        }

        private static int _Anzahl;
        public static int Anzahl
        {
            get { return _Anzahl; }
            set { _Anzahl = value; }
        }
        private int GetAnzahl()
        {
            int a = 0;
            if (Dice1.BackColor == Color.Red) a++;
            if (Dice2.BackColor == Color.Red) a++;
            if (Dice3.BackColor == Color.Red) a++;
            if (Dice4.BackColor == Color.Red) a++;
            if (Dice5.BackColor == Color.Red) a++;
            if (Dice6.BackColor == Color.Red) a++;
            return a;
        }

        
        private void ButtonWeiterWürfeln_Click(object sender, EventArgs e)
        {
            
            if (GetAnzahl() > Anzahl || GetAnzahl() == 0)
            {
                if (Dice1.BackColor == Color.Red) Dice1.Used = true;
                if (Dice2.BackColor == Color.Red) Dice2.Used = true;
                if (Dice3.BackColor == Color.Red) Dice3.Used = true;
                if (Dice4.BackColor == Color.Red) Dice4.Used = true;
                if (Dice5.BackColor == Color.Red) Dice5.Used = true;
                if (Dice6.BackColor == Color.Red) Dice6.Used = true;

                if (Dice1.BackColor == Color.LightGray) Dice1.Text = Convert.ToString(Dice.NeueZahl());
                if (Dice2.BackColor == Color.LightGray) Dice2.Text = Convert.ToString(Dice.NeueZahl());
                if (Dice3.BackColor == Color.LightGray) Dice3.Text = Convert.ToString(Dice.NeueZahl());
                if (Dice4.BackColor == Color.LightGray) Dice4.Text = Convert.ToString(Dice.NeueZahl());
                if (Dice5.BackColor == Color.LightGray) Dice5.Text = Convert.ToString(Dice.NeueZahl());
                if (Dice6.BackColor == Color.LightGray) Dice6.Text = Convert.ToString(Dice.NeueZahl());

                LabelNachrichten.Text = "";
            }
            else LabelNachrichten.Text = "Es muss ein Würfel gewertet werden!";
        }

        private void ButtonSpielerHinzufügen_Click(object sender, EventArgs e)
        {
            SpielerHinzufügen();
        }

        private void SpielerAktivInaktiv(object SpielerName, bool AktivInaktiv)
        {
            int Sender = WerIstSender(SpielerName);
            if (AktivInaktiv) ListeLabelSpieler[Sender].ForeColor = Color.Red;
            else ListeLabelSpieler[Sender].ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (ListeSpieler[0].Aktiv) ListeSpieler[0].Aktiv=false;
            else ListeSpieler[0].Aktiv = true;
        }

        private void ButtonSpielSteuerung_Click(object sender, EventArgs e)
        {
            Spieler1.Aktiv = true;
            ListeSpieler[0].Aktiv = true;
        }
    }
}