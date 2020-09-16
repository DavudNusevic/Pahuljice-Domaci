using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pahuljice_Domaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(46, 68, 130);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            Random r = new Random();

            int red, green, blue;

            red = r.Next(256);
            green = r.Next(256);
            blue = r.Next(256);

            Pen olovka = new Pen(Color.FromArgb(red, green, blue), 2.5f);

            
            g.DrawLine(olovka, e.X - 30, e.Y, e.X + 30, e.Y);
            g.DrawLine(olovka, e.X - 10, e.Y, e.X - 20, e.Y - 10);
            g.DrawLine(olovka, e.X - 10, e.Y, e.X - 20, e.Y + 10);
            g.DrawLine(olovka, e.X + 10, e.Y, e.X + 20, e.Y - 10);
            g.DrawLine(olovka, e.X + 10, e.Y, e.X + 20, e.Y + 10);
            g.DrawLine(olovka, e.X - 20, e.Y, e.X - 30, e.Y - 10);
            g.DrawLine(olovka, e.X - 20, e.Y, e.X - 30, e.Y + 10);
            g.DrawLine(olovka, e.X + 20, e.Y, e.X + 30, e.Y - 10);
            g.DrawLine(olovka, e.X + 20, e.Y, e.X + 30, e.Y + 10);           
            g.DrawLine(olovka, e.X, e.Y - 30, e.X, e.Y + 30);
            g.DrawLine(olovka, e.X, e.Y - 20, e.X + 10, e.Y - 30);
            g.DrawLine(olovka, e.X, e.Y - 20, e.X - 10, e.Y - 30);
            g.DrawLine(olovka, e.X, e.Y - 10, e.X + 10, e.Y - 20);
            g.DrawLine(olovka, e.X, e.Y - 10, e.X - 10, e.Y - 20);
            g.DrawLine(olovka, e.X, e.Y + 10, e.X + 10, e.Y + 20);
            g.DrawLine(olovka, e.X, e.Y + 10, e.X - 10, e.Y + 20);
            g.DrawLine(olovka, e.X, e.Y + 20, e.X + 10, e.Y + 30);
            g.DrawLine(olovka, e.X, e.Y + 20, e.X - 10, e.Y + 30);   
            g.DrawLine(olovka, e.X - 25, e.Y - 25, e.X + 25, e.Y + 25);
            g.DrawLine(olovka, e.X - 15, e.Y - 15, e.X - 15, e.Y - 25);
            g.DrawLine(olovka, e.X - 15, e.Y - 15, e.X - 25, e.Y - 15);
            g.DrawLine(olovka, e.X + 15, e.Y + 15, e.X + 15, e.Y + 25);
            g.DrawLine(olovka, e.X + 15, e.Y + 15, e.X + 25, e.Y + 15);
            g.DrawLine(olovka, e.X + 25, e.Y - 25, e.X - 25, e.Y + 25);
            g.DrawLine(olovka, e.X + 15, e.Y - 15, e.X + 15, e.Y - 25);
            g.DrawLine(olovka, e.X + 15, e.Y - 15, e.X + 25 , e.Y - 15);
            g.DrawLine(olovka, e.X - 15, e.Y + 15, e.X - 15, e.Y + 25);
            g.DrawLine(olovka, e.X - 15, e.Y + 15, e.X - 25, e.Y + 15);
            
        }
    }
}
