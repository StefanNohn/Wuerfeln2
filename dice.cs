using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Würfeln
{
    public class Dice : Button
    {
        public Dice()
        {
            Width = 30;
            Height = 30;
            Text = "X";
            Used = false;
            
        }

        

        private bool _Used;
        public bool Used
        {
            get { return _Used; }
            set { _Used = value; }
        }

    }
}
