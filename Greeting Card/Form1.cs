using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greeting_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Text = "Card ";

            Graphics g = this.CreateGraphics();
            Pen greenPen = new Pen(Color.Green, 10);
            Pen redPen = new Pen(Color.Red, 10);
            Pen brownPen = new Pen(Color.Brown, 45);
            SolidBrush greenBrush = new SolidBrush(Color.Green);

            g.DrawPie(greenPen, 150, 0, 250, 300, 50, 75 );
            g.FillPie(greenBrush, 150, 0, 250, 300, 50, 75);
            g.DrawLine(brownPen ,275, 300,275, 380);
            


        }
    }
}
