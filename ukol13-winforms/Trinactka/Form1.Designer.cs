namespace Trinactka
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelApp;

        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblLoggedUser;

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.panelLoading = new System.Windows.Forms.Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();

            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.panelApp = new System.Windows.Forms.Panel();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();

            this.timer1 = new System.Windows.Forms.Timer(this.components);

            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(360, 420);
            this.Text = "Aplikace";

            this.panelLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoading.BackgroundImage = Properties.Resources.pruhledny;
            this.panelLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.lblLoading.Text = "Loading";
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLoading.ForeColor = System.Drawing.Color.Black;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(140, 40);

            this.progressBar1.Location = new System.Drawing.Point(40, 190);
            this.progressBar1.Size = new System.Drawing.Size(280, 18);

            this.panelLoading.Controls.Add(this.lblLoading);
            this.panelLoading.Controls.Add(this.progressBar1);

            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.BackColor = System.Drawing.Color.Black;

            this.lblUser.Text = "Uživatelské jméno";
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(90, 90);

            this.txtUser.Location = new System.Drawing.Point(90, 115);
            this.txtUser.Size = new System.Drawing.Size(180, 22);
            this.txtUser.BackColor = System.Drawing.Color.Black;
            this.txtUser.ForeColor = System.Drawing.Color.White;

            this.lblPass.Text = "Heslo";
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(90, 155);

            this.txtPass.Location = new System.Drawing.Point(90, 180);
            this.txtPass.Size = new System.Drawing.Size(180, 22);
            this.txtPass.PasswordChar = '*';
            this.txtPass.BackColor = System.Drawing.Color.Black;
            this.txtPass.ForeColor = System.Drawing.Color.White;

            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(90, 215);
            this.lblError.AutoSize = true;

            this.btnLogin.Text = "Přihlásit";
            this.btnLogin.Location = new System.Drawing.Point(120, 255);
            this.btnLogin.Size = new System.Drawing.Size(120, 36);
            this.btnLogin.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.btnExit.Text = "KONEC";
            this.btnExit.Location = new System.Drawing.Point(120, 300);
            this.btnExit.Size = new System.Drawing.Size(120, 30);
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnExit.FlatAppearance.BorderSize = 1;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            this.panelLogin.Controls.Add(this.lblUser);
            this.panelLogin.Controls.Add(this.txtUser);
            this.panelLogin.Controls.Add(this.lblPass);
            this.panelLogin.Controls.Add(this.txtPass);
            this.panelLogin.Controls.Add(this.lblError);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.btnExit);

            this.panelApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelApp.BackColor = System.Drawing.Color.Black;

            this.lblLoggedUser.ForeColor = System.Drawing.Color.White;
            this.lblLoggedUser.Location = new System.Drawing.Point(20, 20);
            this.lblLoggedUser.AutoSize = true;

            this.btnLogout.Text = "Odhlásit";
            this.btnLogout.Location = new System.Drawing.Point(120, 200);
            this.btnLogout.Size = new System.Drawing.Size(120, 36);
            this.btnLogout.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.panelApp.Controls.Add(this.lblLoggedUser);
            this.panelApp.Controls.Add(this.btnLogout);

            this.timer1.Interval = 100;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            this.Controls.Add(this.panelLoading);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelApp);

            this.ResumeLayout(false);
        }
    }
}
