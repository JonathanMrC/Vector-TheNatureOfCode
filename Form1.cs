using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap btmp;
        Ball b1, b2, b3;
        public Form1()
        {
            InitializeComponent();
            btmp = new Bitmap(picbox.Width, picbox.Height);
            g = Graphics.FromImage(btmp);
            picbox.Image = btmp;
            //b1 = new Ball(W : picbox.Width, H : picbox.Height, spx: 5, spy:5, acelx: (float)0.01, acely: (float)0.005, r:10);
            b1 = new Ball(W: picbox.Width, H: picbox.Height, spy: 5, r: 10, lim:10);
            //b2 = new Ball(W: picbox.Width, H: picbox.Height, r: 20, lim: 5);
            //b3 = new Ball(W: picbox.Width, H: picbox.Height, spx:10, r: 30, lim:(float)7.5);
        }

        private void PlayPause(object sender, MouseEventArgs e)
        {
            if (timer.Enabled) timer.Stop();
            else timer.Start();
        }

        private void Tick(object sender, EventArgs e)
        {
            b1.Move();
            //b2.Move();
            //b3.Move();
            g.Clear(Color.White);
            Draw(b1);
            //Draw(b2);
            //Draw(b3);
            picbox.Refresh();
        }

        void Draw(Ball b)
        {
            g.FillEllipse(Brushes.Blue,
                (b.posAct.x - b.radio),
                (b.posAct.y - b.radio),
                b.radio * 2, b.radio * 2);
        }
    }
}
