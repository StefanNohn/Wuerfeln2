using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Würfeln
{
    class Anzeige : Label
    {
        // Deklarieren, initialisieren, ausgeben
        int AktuelleRunde, Punkte, Punktedazu;
        List<int> Speicher = new List<int>();

        //public delegate void Annahme(int Runde, int Punkte);
        //private Annahme Rundenannahme = null;
        //private void Runde(Annahme a)
        //{
        //    Rundenannahme += a;
        //}

        public Anzeige()
        {
        }


        //public void AnzeigeErstellen(int a, int b)
        //{
        //    AktuelleRunde = a;
        //    Punktedazu = b;
        //    string c, d, e;
        //    c = Convert.ToString(a);
        //    d = Convert.ToString(b);
        //    e = null;
        //    Punkte = "Runde    1  1237";
        //    int LetztePunkte = 0;
        //    for (int i = Punkte.Length; i > 11; i--)
        //    {
        //        MessageBox.Show(Convert.ToString(LetztePunkte));
        //        MessageBox.Show(Convert.ToString(i));
        //        LetztePunkte += (Convert.ToInt16((Punkte[i - 1]) * (Math.Pow(10, 16 - i))));
        //    }


        //    switch (c.Length)
        //    {
        //        case 1:
        //            e += "Runde    " + c;
        //            break;
        //        case 2:
        //            e += "Runde   " + c;
        //            break;
        //        case 3:
        //            e += "Runde  " + c;
        //            break;
        //        case 4:
        //            e += "Runde " + c;
        //            break;
        //    }
        //    switch (d.Length)
        //    {
        //        case 1:
        //            break;

        //    }


        //}



    }
}
