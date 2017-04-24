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

        PictureBox[] white = new PictureBox[1000];
        PictureBox[] white2 = new PictureBox[1000];
        PictureBox[] white3 = new PictureBox[1000];
        PictureBox[] black = new PictureBox[1000];
        PictureBox green = new PictureBox();
        int c;
        int n=1;
        int x = 0;
        int i = 0;
        int y1 = 0;
        int y2 = 0;
        int[] y = new int[1000];
        int x2;
        int[] c3 = new int[1000];
        int x3 = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        public void Case(int i, int w, int h, int x1)
        {
            PictureBox pic2 = new PictureBox();
            PictureBox pic1 = new PictureBox();
            y[i] = -200;
            pic2.Size = new Size(w, h);
            pic2.Image = Image.FromFile("black.jpg");
            pic2.Location = new Point(x1 * 100-100, y[i]);
            pic2.BorderStyle = BorderStyle.FixedSingle;
            black[i] = pic2;
            Controls.Add(black[i]);
            black[i].Click += PictureBoxClick;
        

            pic1.Size = new Size(w * 4, h);
            pic1.Image = Image.FromFile("white1.jpg");
            pic1.Location = new Point(0, y[i]);
            pic1.BorderStyle = BorderStyle.FixedSingle;
            white2[i] = pic1;
            Controls.Add(white2[i]);
            
        }


    private void PictureBoxClick(object sender, System.EventArgs e)
    {
        if (sender is PictureBox)
        {
            ((PictureBox)sender).Image = Image.FromFile("green.jpg");
                y2++;
                textBox1.Text = y2.ToString();
        }
    }

    public void Box2(int c, int i)
        {

            switch (c)
            {

                case 1:
                    Case(i, 100, 200, 1);
                    break;

                case 2:
                    Case(i, 100, 200, 2);
                    break;

                case 3:
                    Case(i, 100, 200, 3);
                    break;

                case 4:
                    Case(i, 100, 200, 4);
                    break;


            }

        }

        Random c1 = new Random();

        private void Row(int i)
        {
            int c2;
            c2 = c1.Next(1, 5);
            Box2(c2, i);
            C2(i, c2);
        }


        public void Movee(int i, int c2)
        {

            black[i].Location = new Point(c3[i] * 100 - 100, y[i]);
            white2[i].Location = new Point(0, y[i]);
            y[i] += 200;

        }

        public int C2(int i, int c2)
        {
            c3[i] = c2;
            return c3[i];
        }
            
        private void timer1_Tick(object sender, EventArgs e)
        {


            Row(i);
            n++;

            for (int j=0; j<n-1; j++)
            {
                Movee(j, c3[j]);
            }

            i++;   
        }

        public void pictureBox_Click()
        {
            y2++;
            textBox1.Text = y2.ToString();
        }
    }
}


/*
        public void Box(int c, int n, int i)
        {
            textBox1.Text = n.ToString();
            textBox2.Text = c.ToString();
            switch (c)
            {

                case 1:
                    white.Size = new Size(100, 200);
                    white.Image = Image.FromFile("white1.jpg");
                    white.Location = new Point(100, -200 + n - black.Height * i);
                    Controls.Add(white);

                    white2.Size = new Size(100, 200);
                    white2.Image = Image.FromFile("white1.jpg");
                    white2.Location = new Point(200, -200 + n - black.Height * i);
                    Controls.Add(white2);

                    white3.Size = new Size(100, 200);
                    white3.Image = Image.FromFile("white1.jpg");
                    white3.Location = new Point(300, -200 + n - black.Height * i);
                    Controls.Add(white3);

                    black.Size = new Size(100, 200);
                    black.Image = Image.FromFile("black.jpg");
                    black.Location = new Point(400, -200 + n - black.Height * i);
                    Controls.Add(black);

                    break;


                case 2:
                    white.Size = new Size(100, 200);
                    white.Image = Image.FromFile("white1.jpg");
                    white.Location = new Point(100, -200 + n - black.Height * i);
                    Controls.Add(white);

                    white2.Size = new Size(100, 200);
                    white2.Image = Image.FromFile("white1.jpg");
                    white2.Location = new Point(200, -200 + n - black.Height * i);
                    Controls.Add(white2);

                    white3.Size = new Size(100, 200);
                    white3.Image = Image.FromFile("white1.jpg");
                    white3.Location = new Point(400, -200 + n - black.Height * i);
                    Controls.Add(white3);

                    black.Size = new Size(100, 200);
                    black.Image = Image.FromFile("black.jpg");
                    black.Location = new Point(300, -200 + n - black.Height * i);
                    Controls.Add(black);

                    break;


                case 3:
                    white.Size = new Size(100, 200);
                    white.Image = Image.FromFile("white1.jpg");
                    white.Location = new Point(100, -200 + n - black.Height * i);
                    Controls.Add(white);

                    white2.Size = new Size(100, 200);
                    white2.Image = Image.FromFile("white1.jpg");
                    white2.Location = new Point(400, -200 + n - black.Height * i);
                    Controls.Add(white2);

                    white3.Size = new Size(100, 200);
                    white3.Image = Image.FromFile("white1.jpg");
                    white3.Location = new Point(300, -200 + n - black.Height * i);
                    Controls.Add(white3);

                    black.Size = new Size(100, 200);
                    black.Image = Image.FromFile("black.jpg");
                    black.Location = new Point(200, -200 + n - black.Height * i);
                    Controls.Add(black);

                    break;

                case 4:
                    white.Size = new Size(100, 200);
                    white.Image = Image.FromFile("white1.jpg");
                    white.Location = new Point(400, -200 + n - black.Height * i);
                    Controls.Add(white);

                    white2.Size = new Size(100, 200);
                    white2.Image = Image.FromFile("white1.jpg");
                    white2.Location = new Point(200, -200 + n - black.Height * i);
                    Controls.Add(white2);

                    white3.Size = new Size(100, 200);
                    white3.Image = Image.FromFile("white1.jpg");
                    white3.Location = new Point(300, -200 + n - black.Height * i);
                    Controls.Add(white3);

                    black.Size = new Size(100, 200);
                    black.Image = Image.FromFile("black.jpg");
                    black.Location = new Point(100, -200 + n - black.Height * i);
                    Controls.Add(black);

                    break;


            }

        }






    public void Box2(int c, int i)
        {
            y[i] = -200;
            
            PictureBox pic2 = new PictureBox();
            PictureBox pic4 = new PictureBox();
            PictureBox pic1 = new PictureBox();
            PictureBox pic3 = new PictureBox();
            switch (c)
            {
                                    
                case 1:
                    /* pic1.Size = new Size(100, 200);
                     pic1.Image = Image.FromFile("green.jpg");
                     pic1.Location = new Point(100, y[i]);

                     white[i] = pic1;
                     Controls.Add(white[i]);

                     pic4.Size = new Size(100, 200);
                     pic4.Image = Image.FromFile("white1.jpg");
                     pic4.Location = new Point(200, y[i]);
                     white2[i] = pic4;
                     Controls.Add(white2[i]);

                     pic2.Size = new Size(100, 200);
                     pic2.Image = Image.FromFile("white1.jpg");
                      pic2.Location = new Point(300, y[i]);

                     white3[i] = pic2;
                     Controls.Add(white3[i]);

                     pic3.Size = new Size(100, 200);
                     pic3.Image = Image.FromFile("black.jpg");
                      pic3.Location = new Point(400, y[i]);

                     black[i] = pic3;
                     Controls.Add(black[i]);
                     
                    Case(100, i, 100, 200, c);
                    break;


                case 2:
                    white[i].Size = new Size(100, 200);
white[i].Image = Image.FromFile("white1.jpg");
                    white[i].Location = new Point(100, y[i]);
Controls.Add(white[i]);

                    white2[i].Size = new Size(100, 200);
white2[i].Image = Image.FromFile("white1.jpg");
                    white2[i].Location = new Point(200, y[i]);
Controls.Add(white2[i]);

                    white3[i].Size = new Size(100, 200);
white3[i].Image = Image.FromFile("white1.jpg");
                    white3[i].Location = new Point(400, y[i]);
Controls.Add(white3[i]);

                    black[i].Size = new Size(100, 200);
black[i].Image = Image.FromFile("black.jpg");
                    black[i].Location = new Point(300, y[i]);
Controls.Add(black[i]);

                    break;


                case 3:
                    white[i].Size = new Size(100, 200);
white[i].Image = Image.FromFile("white1.jpg");
                    white[i].Location = new Point(100, y[i]);
Controls.Add(white[i]);

                    white2[i].Size = new Size(100, 200);
white2[i].Image = Image.FromFile("white1.jpg");
                    white2[i].Location = new Point(400, y[i]);
Controls.Add(white2[i]);

                    white3[i].Size = new Size(100, 200);
white3[i].Image = Image.FromFile("white1.jpg");
                    white3[i].Location = new Point(300, y[i]);
Controls.Add(white3[i]);

                    black[i].Size = new Size(100, 200);
black[i].Image = Image.FromFile("black.jpg");
                    black[i].Location = new Point(200, y[i]);
Controls.Add(black[i]);

                    break;

                case 4:
                    white[i].Size = new Size(100, 200);
white[i].Image = Image.FromFile("white1.jpg");
                    white[i].Location = new Point(400, y[i]);
Controls.Add(white[i]);

                    white2[i].Size = new Size(100, 200);
white2[i].Image = Image.FromFile("white1.jpg");
                    white2[i].Location = new Point(200, y[i]);
Controls.Add(white2[i]);

                    white3[i].Size = new Size(100, 200);
white3[i].Image = Image.FromFile("white1.jpg");
                    white3[i].Location = new Point(300, y[i]);
Controls.Add(white3[i]);

                    black[i].Size = new Size(100, 200);
black[i].Image = Image.FromFile("black.jpg");
                    black[i].Location = new Point(100, y[i]);
Controls.Add(black[i]);

                    break;


            }

        }
        */

