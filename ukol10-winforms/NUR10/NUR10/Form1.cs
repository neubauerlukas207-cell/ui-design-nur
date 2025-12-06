using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUR10
{
    public partial class Obrázky : Form
    {
        public Obrázky()
        {
            InitializeComponent();
        }

        PictureBox GetPB(int id)
        {
            if (id == 1) return pictureBox1;
            if (id == 2) return pictureBox2;
            return pictureBox3;
        }

        int VlozitID()
        {
            if (rbV1.Checked) return 1;
            if (rbV2.Checked) return 2;
            if (rbV3.Checked) return 3;
            return 1;
        }

        int SmazatID()
        {
            if (rbS1.Checked) return 1;
            if (rbS2.Checked) return 2;
            if (rbS3.Checked) return 3;
            return 1;
        }

        void VybratRadio(int id)
        {
            if (id == 1)
            {
                rbV1.Checked = true;
                rbS1.Checked = true;
            }
            if (id == 2)
            {
                rbV2.Checked = true;
                rbS2.Checked = true;
            }
            if (id == 3)
            {
                rbV3.Checked = true;
                rbS3.Checked = true;
            }
        }

        void VlozitObrazek()
        {
            int id = VlozitID();
            PictureBox pb = GetPB(id);

            if (pb.Image != null)
            {
                MessageBox.Show("PictureBox není volný.");
                return;
            }

            using (OpenFileDialog d = new OpenFileDialog())
            {
                d.Filter = "Obrázky|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (d.ShowDialog() == DialogResult.OK)
                {
                    pb.Image = Image.FromFile(d.FileName);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        void SmazatObrazek()
        {
            int id = SmazatID();
            PictureBox pb = GetPB(id);

            if (pb.Image == null)
            {
                MessageBox.Show("V PictureBoxu nic není.");
                return;
            }

            pb.Image.Dispose();
            pb.Image = null;
        }

        void KlikNaPicture(object sender)
        {
            if (sender == pictureBox1) VybratRadio(1);
            if (sender == pictureBox2) VybratRadio(2);
            if (sender == pictureBox3) VybratRadio(3);
        }

        void DoubleKlikNaPicture(object sender)
        {
            PictureBox pb = sender as PictureBox;
            if (pb == null || pb.Image == null) return;

            Form f = new Form();
            f.WindowState = FormWindowState.Maximized;
            f.BackgroundImage = (Image)pb.Image.Clone();
            f.BackgroundImageLayout = ImageLayout.Zoom;
            f.ShowDialog();
            f.BackgroundImage.Dispose();
            f.Dispose();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void picture_Click(object sender, EventArgs e)
        {
            KlikNaPicture(sender);
        }

        private void picture_DoubleClick(object sender, EventArgs e)
        {
            DoubleKlikNaPicture(sender);
        }

        private void Picture_DoubleClick(object sender, EventArgs e)
        {
            DoubleKlikNaPicture(sender);
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            KlikNaPicture(sender);
        }

        private void btnVlozit_click(object sender, EventArgs e)
        {
            VlozitObrazek();
        }

        private void btnVlozit_Click(object sender, EventArgs e)
        {
            VlozitObrazek();
        }

        private void btnSmazat_Click(object sender, EventArgs e)
        {
            SmazatObrazek();
        }

        private void radientInactiveCaption(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
