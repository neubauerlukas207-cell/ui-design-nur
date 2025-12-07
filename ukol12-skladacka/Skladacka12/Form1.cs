using System;
using System.Drawing;
using System.Windows.Forms;

namespace Skladacka12
{
    public partial class Form1 : Form
    {
        PictureBox[] pole;
        int sekundy = 0;
        bool hraBezi = false;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            pole = new PictureBox[]
            {
                pictureBox1, pictureBox2, pictureBox3,
                pictureBox4, pictureBox5, pictureBox6,
                pictureBox7, pictureBox8, pictureBox9
            };

            foreach (PictureBox p in pole)
            {
                p.Enabled = false;
                p.Tag = 0;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Click += ObrazekKlik;
            }

            label1.Text = "00";

            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;

            button1.Click += Button1_Click;

            NactiARozdelObrazek();
        }

        void Button1_Click(object sender, EventArgs e)
        {
            if (!hraBezi)
            {
                hraBezi = true;
                sekundy = 0;
                label1.Text = "00";

                Zamichat();

                foreach (PictureBox p in pole)
                    p.Enabled = true;

                timer1.Start();
                button1.Text = "KONEC";
            }
            else
            {
                Close();
            }
        }

        void Timer1_Tick(object sender, EventArgs e)
        {
            sekundy++;
            label1.Text = sekundy.ToString("00");
        }

        void ObrazekKlik(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            if (p.Image != null)
            {
                p.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                p.Refresh();
            }

            int uhel = (int)p.Tag;
            uhel = (uhel + 90) % 360;
            p.Tag = uhel;

            Kontrola();
        }

        void NactiARozdelObrazek()
        {
            Image img = Image.FromFile("bwm.jpg");
            Bitmap bmp = new Bitmap(img);

            int w = bmp.Width / 3;
            int h = bmp.Height / 3;
            int index = 0;

            for (int ry = 0; ry < 3; ry++)
            {
                for (int rx = 0; rx < 3; rx++)
                {
                    Bitmap dil = new Bitmap(w, h);
                    using (Graphics g = Graphics.FromImage(dil))
                    {
                        g.DrawImage(
                            bmp,
                            new Rectangle(0, 0, w, h),
                            new Rectangle(rx * w, ry * h, w, h),
                            GraphicsUnit.Pixel
                        );
                    }

                    pole[index].Image = dil;
                    pole[index].Tag = 0;
                    index++;
                }
            }
        }

        void Zamichat()
        {
            foreach (PictureBox p in pole)
            {
                int otoceni = rnd.Next(0, 4);
                p.Tag = 0;

                for (int i = 0; i < otoceni; i++)
                    if (p.Image != null)
                        p.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                p.Refresh();
                p.Tag = (otoceni * 90) % 360;
            }
        }

        void Kontrola()
        {
            bool hotovo = true;

            foreach (PictureBox p in pole)
            {
                if ((int)p.Tag != 0)
                {
                    hotovo = false;
                    break;
                }
            }

            if (hotovo)
            {
                timer1.Stop();

                foreach (PictureBox p in pole)
                    p.Enabled = false;

                MessageBox.Show("Gratuluji, čas: " + sekundy + " s");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
