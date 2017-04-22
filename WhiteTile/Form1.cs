using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WhiteTile
{
    public partial class Form1 : Form
    {

        //Bitmap btm;
        //public Graphics g;
        PictureBox[] white = new PictureBox[50];
        PictureBox[] black = new PictureBox[50];
        PictureBox[] green = new PictureBox[50];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                PictureBox pic2 = new PictureBox();
                pic2.Size = new Size(100, 200); 
                pic2.Location = new Point(pic2.Location.X + (i * 100), pic2.Location.Y);
                //pic2.BackColor = Color.Black;
                pic2.BackgroundImage = Image.FromFile("black.jpg");
                black[i] = pic2;
                Controls.Add(black[i]);

               /* black[i]  = new PictureBox();
                black[i].Size = new Size(100, 200);
                black[i].Image = Image.FromFile("black.jpg");
                black[i].Location = new Point(200, 200);
*/
            }
        }




        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
