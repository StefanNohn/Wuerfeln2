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
using System.Windows.Forms;


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
                Spieler.ListeSpieler[i] = new Spieler(PunkteAnzeigen,/* SpielerAktivInaktiv,*/ i);
               
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
        
       
      
        private Dice[] ListeDice = new Dice[6];
        
        private static int _Runde=0;
        public static int Runde
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
       
        public void SpielerHinzufügen()
        {
            if (AngelegterSpieler < 10)
            {
                this.Controls.Add(Spieler.ListeLabelSpieler[AngelegterSpieler]); 
                this.Controls.Add(Spieler.ListeComboBoxSpieler[AngelegterSpieler]);              
                this.Controls.Add(Spieler.ListeLabelRunde[AngelegterSpieler]);
                this.Controls.Add(Spieler.ListeLabelRundeAnzeige[AngelegterSpieler]);
                this.Controls.Add(Spieler.ListeLabelPunkte[AngelegterSpieler]);                
                this.Controls.Add(Spieler.ListeLabelPunkteAnzeige[AngelegterSpieler]);
                this.Controls.Add(Spieler.ListeTextBoxSpieler[AngelegterSpieler]);
                AngelegterSpieler++;
            }            
        }
         
        private void PunkteAnzeigen(int SpielerNr, int Punkte)
        {
            int a = Convert.ToInt32(Spieler.ListeLabelPunkte[SpielerNr].Text);
            Spieler.ListeLabelPunkte[SpielerNr].Text = Convert.ToString(Punkte + a);
        }

       
       

        public int WelcherDice(object sender)
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
        public void Clicked(int Sender)
        {
            if (!ListeDice[Sender].Used)
            {
                ListeDice[Sender].Used = true;
            }
            else ListeDice[Sender].Used = false;
        }
        public void Dice_Click(object sender, EventArgs e)
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

        public static void SpielerAktivInaktiv(object SpielerName, bool AktivInaktiv)
        {
            int Sender = Spieler.WerIstSender(SpielerName);
            if (Spieler.ListeLabelSpieler[Sender]!=null)
            {
                if (AktivInaktiv) Spieler.ListeLabelSpieler[Sender].ForeColor = Color.Red;
                else Spieler.ListeLabelSpieler[Sender].ForeColor = Color.Black;
            }
            
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
                Spieler.ListeSpieler[i].Aktiv = false;
            }
        }
        private void ButtonSpielSteuerung_Click(object sender, EventArgs e)
        {
            if (Runde == 0)
            {
                SpielerAnfangInaktiv();
                Runde = 1;
                SpielerAktuell = 0;
                Spieler.ListeSpieler[SpielerAktuell].Aktiv = true;              
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