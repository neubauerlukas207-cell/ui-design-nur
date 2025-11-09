using System;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Kalkul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool TryNum(string s, out double v)
        {
            if (double.TryParse(s, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out v))
                return true;
            return double.TryParse(s.Replace(',', '.'), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out v);
        }

        private void ResetInputs()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = 0;
        }

        private void ShowOk(string msg)
        {
            label1.BackColor = Color.Honeydew;
            label1.ForeColor = Color.DarkGreen;
            label1.Text = msg;
        }

        private void ShowErr(string msg)
        {
            label1.BackColor = Color.MistyRose;
            label1.ForeColor = Color.Maroon;
            label1.Text = msg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string op = comboBox1.SelectedItem as string ?? "Vyber operaci";
            if (op == "Vyber operaci")
            {
                ShowErr("Vyber nejprve operaci.");
                return;
            }

            if (op == "odmocnina")
            {
                bool anyOk = false;
                var sb = new StringBuilder();

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (TryNum(textBox1.Text, out double a))
                    {
                        if (a < 0) sb.AppendLine("Nelze odmocnit záporné první číslo.");
                        else { sb.AppendLine($"√{a} = {Math.Sqrt(a)}"); anyOk = true; }
                    }
                    else sb.AppendLine("První číslo není platné.");
                }

                if (!string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    if (TryNum(textBox2.Text, out double b))
                    {
                        if (b < 0) sb.AppendLine("Nelze odmocnit záporné druhé číslo.");
                        else { sb.AppendLine($"√{b} = {Math.Sqrt(b)}"); anyOk = true; }
                    }
                    else sb.AppendLine("Druhé číslo není platné.");
                }

                if (!anyOk)
                {
                    ShowErr(sb.ToString().Trim());
                    return;
                }

                ShowOk(sb.ToString().Trim());
                ResetInputs();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                ShowErr("Prázdné textboxy – zadej obě čísla.");
                return;
            }

            if (!TryNum(textBox1.Text, out double x))
            {
                ShowErr("První číslo není platné.");
                return;
            }

            if (!TryNum(textBox2.Text, out double y))
            {
                ShowErr("Druhé číslo není platné.");
                return;
            }

            switch (op)
            {
                case "+":
                    ShowOk($"{x} + {y} = {x + y}");
                    break;
                case "-":
                    ShowOk($"{x} - {y} = {x - y}");
                    break;
                case "*":
                    ShowOk($"{x} × {y} = {x * y}");
                    break;
                case "/":
                    if (y == 0) { ShowErr("Dělení nulou není povoleno."); return; }
                    ShowOk($"{x} ÷ {y} = {x / y}");
                    break;
                case "mocnina":
                    ShowOk($"{x}^{y} = {Math.Pow(x, y)}");
                    break;
                default:
                    ShowErr("Neznámá operace.");
                    return;
            }

            ResetInputs();
        }
    }
}
