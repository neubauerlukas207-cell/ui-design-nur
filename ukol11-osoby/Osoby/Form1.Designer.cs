namespace Osoby
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jménoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přijmeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jménoPřijmeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jménoPřijmeníToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GrayText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.konecToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jménoToolStripMenuItem,
            this.přijmeníToolStripMenuItem,
            this.jménoPřijmeníToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";

            this.jménoToolStripMenuItem.Name = "jménoToolStripMenuItem";
            this.jménoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.jménoToolStripMenuItem.Text = "Jméno";
            this.jménoToolStripMenuItem.Click += new System.EventHandler(this.jménoToolStripMenuItem_Click);

            this.přijmeníToolStripMenuItem.Name = "přijmeníToolStripMenuItem";
            this.přijmeníToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.přijmeníToolStripMenuItem.Text = "Přijmení";
            this.přijmeníToolStripMenuItem.Click += new System.EventHandler(this.přijmeníToolStripMenuItem_Click);
 
            this.jménoPřijmeníToolStripMenuItem.Name = "jménoPřijmeníToolStripMenuItem";
            this.jménoPřijmeníToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.jménoPřijmeníToolStripMenuItem.Text = "Jméno + přijmení";
            this.jménoPřijmeníToolStripMenuItem.Click += new System.EventHandler(this.jménoPřijmeníToolStripMenuItem_Click);

            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jménoPřijmeníToolStripMenuItem1});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";

            this.jménoPřijmeníToolStripMenuItem1.Name = "jménoPřijmeníToolStripMenuItem1";
            this.jménoPřijmeníToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.jménoPřijmeníToolStripMenuItem1.Text = "Jméno + Přijmení";
            this.jménoPřijmeníToolStripMenuItem1.Click += new System.EventHandler(this.jménoPřijmeníToolStripMenuItem1_Click);

            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.konecToolStripMenuItem.Text = "Konec";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click)
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
  
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(49, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 238);
            this.listBox1.TabIndex = 2;
     listBox2
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(179, 59);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(100, 238);
            this.listBox2.TabIndex = 3; 
            this.textBox1.Location = new System.Drawing.Point(49, 303);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);

            this.textBox2.Location = new System.Drawing.Point(179, 303);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);

            this.button1.Location = new System.Drawing.Point(49, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Vložit jméno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Location = new System.Drawing.Point(179, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Vložit přijmení";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click); 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "JMÉNA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(176, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "PŘIJMENÍ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Osoby";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jménoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přijmeníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jménoPřijmeníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jménoPřijmeníToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
