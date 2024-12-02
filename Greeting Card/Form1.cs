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

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

            Graphics g = this.CreateGraphics();
            Pen greenPen = new Pen(Color.Green, 10);
            Pen blackPen = new Pen(Color.Black, 10);
            Pen redPen = new Pen(Color.Red, 10);
            Pen brownPen = new Pen(Color.Brown, 45);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush blackbrush = new SolidBrush(Color.Black);
            Font greeting = new Font("Arial", 20, FontStyle.Bold);

            g.DrawPie(greenPen, 150, 0, 250, 300, 50, 75);
            g.FillPie(greenBrush, 150, 0, 250, 300, 50, 75);
            g.DrawLine(brownPen, 275, 300, 275, 380);

            g.DrawString("Merry Chirstmas", greeting, blackbrush, 165, 100);

            g.DrawEllipse(blackPen, 35, 150, 85, 85);
            g.DrawEllipse(blackPen, 440, 150, 85, 85);
            g.FillEllipse(greenBrush, 35, 150, 85, 85);


            for (int i = 0; i <= 1; i++)
            {
               
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Text = "Card ";

            Graphics g = this.CreateGraphics();
            Pen greenPen = new Pen(Color.Green, 10);
            Pen redPen = new Pen(Color.Red, 10);
            Pen brownPen = new Pen(Color.Brown, 45);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            Font greeting = new Font("Arial", 20, FontStyle.Bold);

            g.DrawPie(greenPen, 150, 0, 250, 300, 50, 75);
            g.FillPie(greenBrush, 150, 0, 250, 300, 50, 75);
            g.DrawLine(brownPen, 275, 300, 275, 380);
        }
    }
}