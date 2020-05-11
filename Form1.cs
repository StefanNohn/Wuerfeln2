using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            TextBoxSpieler1.Visible = false;
            TextBoxSpieler2.Visible = false;
            TextBoxSpieler3.Visible = false;
            TextBoxSpieler4.Visible = false;
            Spieler Spieler1 = new Spieler("Spieler1", PunkteAufListeSchreiben, GesamtPunkteLesen);
        }

        private List<int> PunkteSpieler1 = new List<int>();
        private List<int> PunkteSpieler2 = new List<int>();
        private List<int> PunkteSpieler3 = new List<int>();
        private List<int> PunkteSpieler4 = new List<int>();

         
        private int GesamtPunkteLesen(int Liste)
        {
            int PunkteGesamt = 0;
            switch (Liste)
            {
                case 1:
                    PunkteGesamt = PunkteSpieler1.Sum();
                    break;
                case 2:
                     PunkteGesamt = PunkteSpieler2.Sum();
                    break;
                case 3:
                     PunkteGesamt = PunkteSpieler3.Sum();
                    break;
                case 4:
                     PunkteGesamt = PunkteSpieler4.Sum();
                    break;
                default:
                    PunkteGesamt = 0;
                    MessageBox.Show("Gesamtpunkteauslesen mit Fehler");
                    break;
            }            
            return PunkteGesamt;
        }

        private void PunkteAufListeSchreiben(int Punkte, int Liste)
        {
            switch (Liste)
            {
                case 1:
                    PunkteSpieler1.Add(Punkte);
                    break;
                case 2:
                    PunkteSpieler2.Add(Punkte);
                    break;
                case 3:
                    PunkteSpieler3.Add(Punkte);
                    break;
                case 4:
                    PunkteSpieler4.Add(Punkte);
                    break;
            }        
        }
        

        private void LabelSpieler1_MouseClick(object sender, MouseEventArgs e)
        {
            //if (ComboBoxSpieler1.SelectedIndex == 0)    Erlaubt nur die Benennung eines menschlichen Spielers, nimmt aber Moeglichkeiten und evtl. Spassfaktor
            //{
                TextBoxSpieler1.Location = new Point(12, 9);
                TextBoxSpieler1.Text = LabelSpieler1.Text;
                TextBoxSpieler1.Visible = true;
                TextBoxSpieler1.AcceptsReturn = false;
            //}
        }             
        private void TextBoxSpieler1_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter)
            {
                if (TextBoxSpieler1.Text.Length >= 1) { LabelSpieler1.Text = TextBoxSpieler1.Text; }
                else LabelSpieler1.Text = "Ohne Namen 1";
                TextBoxSpieler1.Visible = false;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }            
        }
        private void ComboBoxSpieler1_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (ComboBoxSpieler1.SelectedIndex)
            {
                case 0:
                    //LabelSpieler1.Text = "Mensch 1";
                    break;
                case 1:
                    LabelSpieler1.Text = "KI-ängstlich";
                    break;
                case 2:
                    LabelSpieler1.Text = "KI-normal";
                    break;
                case 3:
                    LabelSpieler1.Text = "KI-risiko";
                    break;               
            }
        }
       

        private void LabelSpieler2_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxSpieler2.Location = new Point(12, 31);
            TextBoxSpieler2.Text = LabelSpieler2.Text;
            TextBoxSpieler2.Visible = true;
            TextBoxSpieler2.AcceptsReturn = false;
        }
        private void TextBoxSpieler2_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                if (TextBoxSpieler2.Text.Length >= 1) { LabelSpieler2.Text = TextBoxSpieler2.Text; }
                else LabelSpieler2.Text = "Ohne Namen 2";
                TextBoxSpieler2.Visible = false;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void ComboBoxSpieler2_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (ComboBoxSpieler2.SelectedIndex)
            {
                case 0:
                    //LabelSpieler2.Text = "Mensch";
                    break;
                case 1:
                    LabelSpieler2.Text = "KI-ängstlich";
                    break;
                case 2:
                    LabelSpieler2.Text = "KI-normal";
                    break;
                case 3:
                    LabelSpieler2.Text = "KI-risiko";
                    break;
            }
        }

        private void LabelSpieler3_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxSpieler3.Location = new Point(12, 53);
            TextBoxSpieler3.Text = LabelSpieler3.Text;
            TextBoxSpieler3.Visible = true;
            TextBoxSpieler3.AcceptsReturn = false;
        }
        private void TextBoxSpieler3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextBoxSpieler3.Text.Length >= 1) { LabelSpieler3.Text = TextBoxSpieler3.Text; }
                else LabelSpieler1.Text = "Ohne Namen 3";
                TextBoxSpieler3.Visible = false;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void ComboBoxSpieler3_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (ComboBoxSpieler3.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    LabelSpieler3.Text = "KI-ängstlich";
                    break;
                case 2:
                    LabelSpieler3.Text = "KI-normal";
                    break;
                case 3:
                    LabelSpieler3.Text = "KI-risiko";
                    break;
            }
        }

        private void LabelSpieler4_MouseClick(object sender, EventArgs e)
        {
            TextBoxSpieler4.Location = new Point(12, 75);
            TextBoxSpieler4.Text = LabelSpieler4.Text;
            TextBoxSpieler4.Visible = true;
            TextBoxSpieler4.AcceptsReturn = false;
        }
        private void TextBoxSpieler4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextBoxSpieler4.Text.Length >= 1) { LabelSpieler4.Text = TextBoxSpieler4.Text; }
                else LabelSpieler4.Text = "Ohne Namen 4";
                TextBoxSpieler4.Visible = false;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void ComboBoxSpieler4_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (ComboBoxSpieler4.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    LabelSpieler4.Text = "KI-ängstlich";
                    break;
                case 2:
                    LabelSpieler4.Text = "KI-normal";
                    break;
                case 3:
                    LabelSpieler4.Text = "KI-risiko";
                    break;
            }
        }

        private void ComboBoxSpieler1_Leave(object sender, EventArgs e)
        {
           
        }

        private void LabelSpieler1_Leave(object sender, EventArgs e)
        {
           
        }
                        
        private void Dice1_Click(object sender, EventArgs e)
        {
            if (!Dice1.Used)
            {
                if (Dice1.BackColor == Color.Red)
                    Dice1.BackColor = Color.LightGray;
                else Dice1.BackColor = Color.Red;
            }
        }

        private void Dice2_Click(object sender, EventArgs e)
        {
            if (!Dice2.Used)
            {
                if (Dice2.BackColor == Color.Red)
                    Dice2.BackColor = Color.LightGray;
                else Dice2.BackColor = Color.Red;
            }
        }

        private void Dice3_Click(object sender, EventArgs e)
        {
            if (!Dice3.Used)
            {
                if (Dice3.BackColor == Color.Red)
                    Dice3.BackColor = Color.LightGray;
                else Dice3.BackColor = Color.Red;
            }
        }

        private void Dice4_Click(object sender, EventArgs e)
        {
            if (!Dice4.Used)
            {
                if (Dice4.BackColor == Color.Red)
                    Dice4.BackColor = Color.LightGray;
                else Dice4.BackColor = Color.Red;
            }
        }

        private void Dice5_Click(object sender, EventArgs e)
        {
            if (!Dice5.Used)
            {
                if (Dice5.BackColor == Color.Red)
                    Dice5.BackColor = Color.LightGray;
                else Dice5.BackColor = Color.Red;
            }
        }

        private void Dice6_Click(object sender, EventArgs e)
        {
            if (!Dice6.Used)
            {
                if (Dice6.BackColor == Color.Red)
                    Dice6.BackColor = Color.LightGray;
                else Dice6.BackColor = Color.Red;
            }
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
            if (GetAnzahl() > Anzahl || GetAnzahl()==0)
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
    }
}






//private void NameSpieler(string a, int b)
//{
//    switch (b)
//    {
//        case 1:
//            LabelSpieler1.Text = a;
//            break;
//        case 2:
//            LabelSpieler2.Text = a;
//            break;
//        case 3:
//            LabelSpieler3.Text = a;
//            break;
//        case 4:
//            LabelSpieler4.Text = a;
//            break;
//    }                
//}
