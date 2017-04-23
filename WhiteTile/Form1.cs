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
        
        PictureBox[] white = new PictureBox[8];
        PictureBox[] white2 = new PictureBox[8];
        PictureBox[] white3 = new PictureBox[8];
        PictureBox[] black = new PictureBox[8];
        PictureBox green = new PictureBox();
        int c;
        int n;
        int x;
        int[] y= new int[12];
       
        int i;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
         
        }

        public void Box2(int c, int i)
        {
            y[i] = -200;
            textBox1.Text = n.ToString();
            textBox2.Text = c.ToString();
            switch (c)
            {

                case 1:
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
                    white3[i].Location = new Point(300, y[i]);
                    Controls.Add(white3[i]);

                    black[i].Size = new Size(100, 200);
                    black[i].Image = Image.FromFile("black.jpg");
                    black[i].Location = new Point(400, y[i]);
                    Controls.Add(black[i]);

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
        */


        private void Row(int i)
        {
            Random c1 = new Random();
            int c2;
            c2 = c1.Next(1, 5);
            int c3 = 1;
            Box2(c3, i);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            i = 0;
           
            
            Row(i);
            black[i].Location = new Point(400, y[i] + 100);
            // white[i].Top += 100;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            c = 1;
           // Box(c,n);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        //Box(c,n);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
