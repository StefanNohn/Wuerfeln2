using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
//using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace Würfeln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LabelNachrichten.Visible = false;

            for (int i = 0; i <= 9; i++)
            {
                ListeSpieler[i] = new Spieler(PunkteAnzeigen, SpielerAktivInaktiv);
                ListeTextBoxSpieler[i] = new TextBox();
                ListeTextBoxSpieler[i].Visible = false;

                ListeLabelSpieler[i] = new Label();
                ListeLabelSpieler[i].AutoSize = true;
                ListeLabelSpieler[i].Size = new System.Drawing.Size(100, 13);
                ListeLabelSpieler[i].Location = new System.Drawing.Point(P1, Reihe + 24 * i);
                ListeLabelSpieler[i].TabIndex = 0;
                ListeLabelSpieler[i].Text = ListeSpieler[i].Name;
                ListeLabelSpieler[i].MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelSpieler_MouseClick);

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
                ListeLabelRunde[i].Text = $"{Runde}";
                               
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

                if (i <= 5)
                {
                    ListeDice[i]= new Dice();
                }
            }
        }
        //Lohnt sicht ein jagged array?
        //private Array[] Player = new Array[8]
        //    {
        //        ListeSpieler,
        //    }
        
        private Spieler[] ListeSpieler = new Spieler[10];
        private Label[] ListeLabelSpieler = new Label[10];
        private Label[] ListeLabelRunde = new Label[10];        
        private ComboBox[] ListeComboBoxSpieler = new ComboBox[10];
        private Label[] ListeLabelRundeAnzeige = new Label[10];
        private Label[] ListeLabelPunkte = new Label[10];
        private Label[] ListeLabelPunkteAnzeige = new Label[10];
        private TextBox[] ListeTextBoxSpieler = new TextBox[10];
      
        private Dice[] ListeDice = new Dice[6];
        
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
                this.Controls.Add(ListeLabelSpieler[AngelegterSpieler]); 
                this.Controls.Add(ListeComboBoxSpieler[AngelegterSpieler]);              
                this.Controls.Add(ListeLabelRunde[AngelegterSpieler]);
                this.Controls.Add(ListeLabelRundeAnzeige[AngelegterSpieler]);
                this.Controls.Add(ListeLabelPunkte[AngelegterSpieler]);                
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
            ListeTextBoxSpieler[Sender].Leave += new System.EventHandler(this.TextBoxSpieler_Leave);
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
        private void TextBoxSpieler_Leave(object sender, EventArgs e)
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

        //private static int _Anzahl;
        //public static int Anzahl
        //{
        //    get { return _Anzahl; }
        //    set { _Anzahl = value; }
        //}
        //private int GetAnzahl()
        //{
        //    int a = 0;
        //    if (Dice1.BackColor == Color.Red) a++;
        //    if (Dice2.BackColor == Color.Red) a++;
        //    if (Dice3.BackColor == Color.Red) a++;
        //    if (Dice4.BackColor == Color.Red) a++;
        //    if (Dice5.BackColor == Color.Red) a++;
        //    if (Dice6.BackColor == Color.Red) a++;
        //    return a;
        //}

        
        private void ButtonWeiterWürfeln_Click(object sender, EventArgs e)
        {
            
            //if (GetAnzahl() > Anzahl || GetAnzahl() == 0)
            //{
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

                LabelNachrichten.Visible = false;
            //}
            //else NachrichtAnzeigen("Es muss ein Würfel gewertet werden!");
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
            LabelNachrichten.Text = "Hallo!";
            
            //if (ListeSpieler[0].Aktiv) ListeSpieler[0].Aktiv=false;
            //else ListeSpieler[0].Aktiv = true;
        }

       
        public void NachrichtAnzeigen(string Nachricht)
        {
            LabelNachrichten.Text = Nachricht;
            LabelNachrichten.Visible = true;          
        }

        private int _SpielerAktuell;
        public int SpielerAktuell
        {
            get { return _SpielerAktuell; }
            set { _SpielerAktuell = value; }
        }
        public void SpielerAnfangInaktiv()
        {
            for (int i = 0; i < 10; i++)
            {
                ListeSpieler[i].Aktiv = false;
            }
        }
        private void ButtonSpielSteuerung_Click(object sender, EventArgs e)
        {
            if (Runde == 0)
            {
                SpielerAnfangInaktiv();
                Runde = 1;
                SpielerAktuell = 0;
                ListeSpieler[SpielerAktuell].Aktiv = true;              
                ButtonSpielerHinzufügen.Visible = false;
                ButtonSpielSteuerung.Text = "Nächster Spieler";
                LabelNachrichten.Visible = false;
            }
        }

        //readonly Thread warteTimer = new Thread(new ThreadStart(warteTimer()));
        //void warteTimer()
        //{
        //    Thread.Sleep(10000);
        //}
        private void LabelNachrichten_TextChanged(object sender, EventArgs e)
        {
            LabelNachrichten.Visible = true;             
        }
    }
}