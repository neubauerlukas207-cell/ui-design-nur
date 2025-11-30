using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Osoby
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool Kontrola(TextBox tb)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                MessageBox.Show("Pole nesmí být prázdné!", "Upozornění",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Kontrola(textBox1)) return;
            listBox1.Items.Add(textBox1.Text.Trim());
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Kontrola(textBox2)) return;
            listBox2.Items.Add(textBox2.Text.Trim());
            textBox2.Clear();
            textBox2.Focus();
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Opravdu chcete program ukončit?", "Konec",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK) Application.Exit();
        }

        private void jménoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Textové soubory|*.txt";
            if (s.ShowDialog() == DialogResult.OK)
                File.WriteAllLines(s.FileName, listBox1.Items.Cast<string>());
        }

        private void přijmeníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Textové soubory|*.txt";
            if (s.ShowDialog() == DialogResult.OK)
                File.WriteAllLines(s.FileName, listBox2.Items.Cast<string>());
        }

        private void jménoPřijmeníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != listBox2.Items.Count)
            {
                MessageBox.Show("Jiný počet jmen a příjmení!", "Upozornění",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Textové soubory|*.txt";

            if (s.ShowDialog() == DialogResult.OK)
            {
                List<string> osoby = new List<string>();
                for (int i = 0; i < listBox1.Items.Count; i++)
                    osoby.Add(listBox1.Items[i] + " " + listBox2.Items[i]);
                File.WriteAllLines(s.FileName, osoby);
            }
        }

        private void jménoPřijmeníToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Textové soubory|*.txt";
            if (o.ShowDialog() != DialogResult.OK) return;

            DialogResult r = MessageBox.Show("Nahradit stávající seznam?", "Import",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r != DialogResult.OK) return;

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            foreach (var radek in File.ReadAllLines(o.FileName))
            {
                if (string.IsNullOrWhiteSpace(radek)) continue;
                var casti = radek.Split(' ');
                if (casti.Length < 2) continue;
                listBox1.Items.Add(casti[0]);
                listBox2.Items.Add(casti[1]);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
