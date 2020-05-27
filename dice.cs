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
using System.Threading;
using System.Windows.Forms;

namespace Würfeln
{
    public class Dice : Button
    {
        public Dice()
        { }

        public Dice(char a)
        {
            Width = 30;
            Height = 30;
            Text = Convert.ToString(a);
            Used = false;
            BackColor = Color.LightGray;
        }
        
        private bool _Used;
        public bool Used
        {
            get { return _Used; }
            set 
            {
                _Used = value;
                if (value)
                {
                    BackColor = Color.Red;
                }
                else BackColor = Color.LightGray;

            }
        }

        private static Random _rnd;
        private static int _seed = Environment.TickCount;
        public static int NeueZahl()
        {
            if (_rnd == null)
            {
                int seed = Interlocked.Increment(ref _seed);
                _rnd = new Random(seed);
            }
            return _rnd.Next(1, 7);
        }
    }
}
