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
        Ball b1;
        public Form1()
        {
            InitializeComponent();
            btmp = new Bitmap(picbox.Width, picbox.Height);
            g = Graphics.FromImage(btmp);
            picbox.Image = btmp;
            b1 = new Ball(picbox.Width, picbox.Height, 5, 5);
        }

        private void PlayPause(object sender, MouseEventArgs e)
        {
            if (timer.Enabled) timer.Stop();
            else timer.Start();
        }

        private void Tick(object sender, EventArgs e)
        {
            b1.Move();
            g.Clear(Color.White);
            g.FillEllipse(Brushes.Blue,
                (b1.posAct.x - b1.radio), 
                (b1.posAct.y - b1.radio), 
                b1.radio * 2, b1.radio * 2);
            picbox.Refresh();
        }
    }
}
