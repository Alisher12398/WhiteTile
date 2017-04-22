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
        
        PictureBox white = new PictureBox();
        PictureBox white2 = new PictureBox();
        PictureBox white3 = new PictureBox();
        PictureBox black = new PictureBox();
        PictureBox green = new PictureBox();
        int n;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
         
        }

        public void Box(int n)
        {
            switch(n)
            {
                case 1:
                    white.Size = new Size(100, 200);
                    white.Image = Image.FromFile("white1.jpg");              
                    white.Location = new Point(100, 200);
                    Controls.Add(white);

                    white2.Size = new Size(100, 200);
                    white2.Image = Image.FromFile("white1.jpg");
                    white2.Location = new Point(200, 200);
                    Controls.Add(white2);

                    white3.Size = new Size(100, 200);
                    white3.Image = Image.FromFile("white1.jpg");
                    white3.Location = new Point(300, 200);
                    Controls.Add(white3);

                    black.Size = new Size(100, 200);
                    black.Image = Image.FromFile("black.jpg");
                    black.Location = new Point(400, 200);
                    Controls.Add(black);

                    break;


                case 2:
                    white.Size = new Size(100, 200);
                    white.Image = Image.FromFile("white1.jpg");
                    white.Location = new Point(100, 200);
                    Controls.Add(white);

                    white2.Size = new Size(100, 200);
                    white2.Image = Image.FromFile("white1.jpg");
                    white2.Location = new Point(200, 200);
                    Controls.Add(white2);

                    white3.Size = new Size(100, 200);
                    white3.Image = Image.FromFile("white1.jpg");
                    white3.Location = new Point(400, 200);
                    Controls.Add(white3);

                    black.Size = new Size(100, 200);
                    black.Image = Image.FromFile("black.jpg");
                    black.Location = new Point(300, 200);
                    Controls.Add(black);

                    break;


                case 3:
                    white.Size = new Size(100, 200);
                    white.Image = Image.FromFile("white1.jpg");
                    white.Location = new Point(100, 200);
                    Controls.Add(white);

                    white2.Size = new Size(100, 200);
                    white2.Image = Image.FromFile("white1.jpg");
                    white2.Location = new Point(400, 200);
                    Controls.Add(white2);

                    white3.Size = new Size(100, 200);
                    white3.Image = Image.FromFile("white1.jpg");
                    white3.Location = new Point(300, 200);
                    Controls.Add(white3);

                    black.Size = new Size(100, 200);
                    black.Image = Image.FromFile("black.jpg");
                    black.Location = new Point(200, 200);
                    Controls.Add(black);

                    break;

                case 4:
                    white.Size = new Size(100, 200);
                    white.Image = Image.FromFile("white1.jpg");
                    white.Location = new Point(400, 200);
                    Controls.Add(white);

                    white2.Size = new Size(100, 200);
                    white2.Image = Image.FromFile("white1.jpg");
                    white2.Location = new Point(200, 200);
                    Controls.Add(white2);

                    white3.Size = new Size(100, 200);
                    white3.Image = Image.FromFile("white1.jpg");
                    white3.Location = new Point(300, 200);
                    Controls.Add(white3);

                    black.Size = new Size(100, 200);
                    black.Image = Image.FromFile("black.jpg");
                    black.Location = new Point(100, 200);
                    Controls.Add(black);

                    break;


            }

           
            /*
            for (int i = 0; i < 3; i++)
            {
                /*
                PictureBox pic2 = new PictureBox();
                pic2.Size = new Size(100, 200); 
                pic2.Location = new Point(pic2.Location.X + (i * 100), pic2.Location.Y);
                //pic2.BackColor = Color.Black;
                pic2.BackgroundImage = Image.FromFile("black.jpg");
                black[i] = pic2;
                Controls.Add(black[i]);
                
                black[i] = new PictureBox();
                black[i].Size = new Size(80, 120);
                black[i].Image = Image.FromFile("black.jpg");
                black[i].BackgroundImage = Image.FromFile("black.jpg");
                black[i].Location = new Point(black[i].Location.X + (i * 100), black[i].Location.Y);

                white[i] = new PictureBox();
                white[i].Size = new Size(80, 120);
                white[i].Image = Image.FromFile("black.jpg");
                white[i].BackgroundImage = Image.FromFile("black.jpg");
                white[i].Location = new Point(black[i].Location.X + (i * 100), black[i].Location.Y);

                green[i] = new PictureBox();
                green[i].Size = new Size(80, 120);
                green[i].Image = Image.FromFile("black.jpg");
                green[i].BackgroundImage = Image.FromFile("black.jpg");
                green[i].Location = new Point(black[i].Location.X + (i * 100), black[i].Location.Y);


                Controls.Add(black[i]);
                Controls.Add(white[i]);
                Controls.Add(green[i]);
            }*/
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = 1;
            Box(n);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            n = 2;
            Box(n);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            n = 3;
            Box(n);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            n = 4;
            Box(n);
        }
    }
}
