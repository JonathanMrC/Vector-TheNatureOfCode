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
        vector mid, dif;
        readonly int radio;
        public Form1()
        {
            InitializeComponent();
            btmp = new Bitmap(picbox.Width, picbox.Height);
            g = Graphics.FromImage(btmp);
            picbox.Image = btmp;
            radio = 5;
            mid = new vector(picbox.Width / 2, picbox.Height / 2);
            g.FillEllipse(Brushes.Black, mid.x - radio, mid.y - radio, radio*2, radio*2);
        }

        private void picbox_MouseMove(object sender, MouseEventArgs e)
        {
            g.Clear(Color.White);
            g.FillEllipse(Brushes.Black, mid.x - radio, mid.y - radio, radio * 2, radio * 2);
            dif = new vector(e.X, e.Y) - mid;
            if (e.X <= mid.x) dif *= 2;
            else dif *= (float)0.5;
            g.DrawLine(new Pen(Color.Black, 2), mid.x, mid.y, mid.x + dif.x, mid.y + dif.y);
            picbox.Refresh();
        }
    }
}
