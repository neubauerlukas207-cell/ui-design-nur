using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol_9
{
    public partial class Form1 : Form
    {
        string[] barvy = new string[]
        {
            "Černá", "Červená", "Modrá", "Žlutá",
            "Oranžová", "Zelená", "Hnědá", "Bílá"
        };

        public Form1()
        {
            InitializeComponent();

            foreach (string barva in barvy)
            {
                comboBox1.Items.Add(barva);
                checkedListBox1.Items.Add(barva);
            }

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;

            string barva = comboBox1.SelectedItem.ToString();

            if (!listBox1.Items.Contains(barva))
                listBox1.Items.Add(barva);
        }

        void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

            string barva = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(barva);

            int index = checkedListBox1.Items.IndexOf(barva);
            if (index >= 0)
                checkedListBox1.SetItemChecked(index, false);
        }

        void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);

            foreach (var item in listBox1.Items)
            {
                int index = checkedListBox1.Items.IndexOf(item);
                if (index >= 0)
                    checkedListBox1.SetItemChecked(index, true);
            }
        }

        void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches)
                return;

            string barva = listBox1.Items[index].ToString();

            Form okno = new Form();
            okno.Text = barva;
            okno.BackColor = PrevedNaColor(barva);
            okno.Size = new Size(500, 300);
            okno.StartPosition = FormStartPosition.CenterScreen;
            okno.Show();
        }

        Color PrevedNaColor(string barva)
        {
            switch (barva)
            {
                case "Černá": return Color.Black;
                case "Červená": return Color.Red;
                case "Modrá": return Color.Blue;
                case "Žlutá": return Color.Yellow;
                case "Oranžová": return Color.Orange;
                case "Zelená": return Color.Green;
                case "Hnědá": return Color.Brown;
                case "Bílá": return Color.White;
                default: return SystemColors.Control;
            }
        }
    }
}
