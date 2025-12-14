using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Trinactka
{
    public partial class Form1 : Form
    {
        string[] users =
        {
            "admin admin",
            "user user",
            "test test"
        };

        int dots = 0;

        public Form1()
        {
            InitializeComponent();

            panelLogin.Visible = false;
            panelApp.Visible = false;
            panelLoading.Visible = true;

            BackColor = Color.Magenta;
            TransparencyKey = Color.Magenta;
            FormBorderStyle = FormBorderStyle.None;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dots = (dots + 1) % 4;
            lblLoading.Text = "Loading" + new string('.', dots);

            if (progressBar1.Value < 100)
                progressBar1.Value += 2;
            else
            {
                timer1.Stop();

                panelLoading.Visible = false;
                panelLogin.Visible = true;

                TransparencyKey = Color.Empty;
                BackColor = Color.Black;
                FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                lblError.Text = "Vyplňte všechna pole!";
                return;
            }

            if (users.Contains(txtUser.Text + " " + txtPass.Text))
            {
                lblLoggedUser.Text = "Přihlášen: " + txtUser.Text;
                panelLogin.Visible = false;
                panelApp.Visible = true;
            }
            else
            {
                lblError.Text = "Špatné údaje!";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            lblError.Text = "";
            panelApp.Visible = false;
            panelLogin.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
