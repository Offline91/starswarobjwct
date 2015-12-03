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
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Torpedo(0, 0, 100);
        }
        public void Torpedo (float x, float y, float pixels)
        {
            float scale = pixels / 150;//dividing pixels

            Pen torpen = new Pen(Color.White);//creates pen colour
            g.DrawLine(torpen, 25 * scale + x, 75 * scale + y , 75 * scale + x, 25 *scale + y);//draws the square
            g.DrawLine(torpen, 75 * scale + x , 25 *scale + y, 125 *scale + x, 75 *scale + y);//draws the square
            g.DrawLine(torpen, 125 *scale + x, 75 * scale + y, 75 *scale + x, 125 *scale + y);//draws the square
            g.DrawLine(torpen, 75 *scale + x, 125 *scale + y, 25 *scale + x, 75 *scale + y);//draws the square

            g.DrawEllipse(torpen, 0 *scale + x, 0 *scale + y, 150 * scale , 150 * scale);//draws the circle
        }
    }
}
