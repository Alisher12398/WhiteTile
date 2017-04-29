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
using System.Media;

namespace WhiteTile
{
    public partial class Form1 : Form
    {
        PictureBox[] white2 = new PictureBox[1000];
        PictureBox[] black = new PictureBox[1000];
        PictureBox green = new PictureBox();
        int n = 1;
        int i = 0;
        int y2 = 0;
        int[] y = new int[1000];
        int x2=0;
        int[] c3 = new int[1000];


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
            black[i] = pic2;
            Controls.Add(black[i]);
            black[i].Click += PictureBoxClick;

            pic1.Size = new Size(w * 4, h);
            pic1.Location = new Point(0, y[i]);
            white2[i] = pic1;
            Controls.Add(white2[i]);
            white2[i].Click += PictureBoxClick2;
        }


        Random c1 = new Random();
        private void PictureBoxClick(object sender, System.EventArgs e)
        {
            if (sender is PictureBox)
            {
                ((PictureBox)sender).Image = Image.FromFile("green.jpg");
                ((PictureBox)sender).Enabled = false;

                int c4 = c1.Next(1, 5);

                if (c4 == 1)
                {
                    System.Media.SoundPlayer s = new SoundPlayer(@"C:\PT\WhiteTile — копия\WhiteTile\WhiteTile\bin\Debug\1.wav");
                    s.Load();
                    s.PlaySync();
                }

                if (c4 == 2)
                {
                    System.Media.SoundPlayer s = new SoundPlayer(@"C:\PT\WhiteTile — копия\WhiteTile\WhiteTile\bin\Debug\3.wav");
                    s.Load();
                    s.PlaySync();
                }

                if (c4 == 3)
                {
                    System.Media.SoundPlayer s = new SoundPlayer(@"C:\PT\WhiteTile — копия\WhiteTile\WhiteTile\bin\Debug\4.wav");
                    s.Load();
                    s.PlaySync();
                }

                if (c4 == 4)
                {
                    System.Media.SoundPlayer s = new SoundPlayer(@"C:\PT\WhiteTile — копия\WhiteTile\WhiteTile\bin\Debug\5.wav");
                    s.Load();
                    s.PlaySync();
                }

                y2++;

            }
        }


        private void PictureBoxClick2(object sender, System.EventArgs e)
        {
            if (sender is PictureBox)
            {
                timer1.Enabled = false;
                MessageBox.Show("Вы проиграли. Счет: "+ y2);
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

        

        private void Row(int i)
        {
            int c2;
            c2 = c1.Next(1, 5);
            int i2 = i - 1;         
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
 
            if (y[i] > 1200)
            {
                x2++;    
            }

                for (int j = x2; j < n - 1; j++)
                {
                    Movee(j, c3[j]);

                    if (black[j].Enabled == true)
                    {
                        if (y[j] > 1000)
                        {
                            timer1.Enabled = false;

                            MessageBox.Show("Вы проиграли. Счет: " + y2);
                            Application.Restart();
                        }
                    }


                }

            i++;   
        }

        public void pictureBox_Click()
        {
            y2++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}