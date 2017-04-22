using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WhiteTile
{
    public partial class Form1 : Form
    {

        Button[] white = new Button[50];
        Button[] black = new Button[50];
        Button[] green = new Button[50];


        public Form1()
        {
            InitializeComponent();
            buttons();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void buttons()
        {
            for (int i=0; i<50; i++)
            {
                white[i] = new Button();
                white[i].Size = new Size(30, 60);
                white[i].Location = new Point(100, 100);

                black[i] = new Button();
                black[i].Size = new Size(30, 60);
                black[i].Location = new Point(200, 200);
                black[i].BackgroundImage = Image.FromFile("Black.png");
            }
        }
        



        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
