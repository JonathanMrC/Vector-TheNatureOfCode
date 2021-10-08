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
        bool mostrar;
        public Form1()
        {
            InitializeComponent();
            btmp = new Bitmap(picbox.Width, picbox.Height);
            g = Graphics.FromImage(btmp);
            picbox.Image = btmp;
            mostrar = true;
            b1 = new Ball(W: picbox.Width, H: picbox.Height, r: 10, lim:10);
        }

        void Draw(Ball b, vector acc)
        {
            b.Move(acc, false);
            g.FillEllipse(Brushes.Blue,
                (b.posAct.x - b.radio),
                (b.posAct.y - b.radio),
                b.radio * 2, b.radio * 2);
        }

        private void picbox_MouseMove(object sender, MouseEventArgs e)
        {
            g.Clear(Color.White);
            Draw(b1, new vector(e.X, e.Y));
            picbox.Refresh();
        }
    }
}
