using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace starswarobjwct
{
    public partial class Form1 : Form
    {
        Graphics G;

        public Form1()
        {
            InitializeComponent();
            G = this.CreateGraphics();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Torpedo(100, 100, 100);
        }

        public void Torpedo (float torpedox, float torpedoy, float pixels)
        {
            Pen expen = new Pen(Color.White);
            G.DrawLine(expen, 150, 50 , 100, 100);
            G.DrawLine(expen, 150, 50,200, 100);
            G.DrawLine(expen, 200, 100, 150, 150);
            G.DrawLine(expen, 100, 100, 150, 150);
            G.DrawEllipse(expen, 75, 25, 150, 150);
        }
    }
}
