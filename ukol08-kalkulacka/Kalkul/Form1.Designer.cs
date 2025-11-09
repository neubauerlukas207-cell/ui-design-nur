namespace Kalkul
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new System.Windows.Forms.TextBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            textBox2 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();

            textBox1.Location = new System.Drawing.Point(20, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(160, 23);

            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "Vyber operaci", "+", "-", "*", "/", "mocnina", "odmocnina" });
            comboBox1.SelectedIndex = 0;
            comboBox1.Location = new System.Drawing.Point(200, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(140, 23);

            textBox2.Location = new System.Drawing.Point(360, 20);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(160, 23);

            button1.Location = new System.Drawing.Point(200, 60);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(140, 30);
            button1.Text = "Spočítat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);

            label1.Location = new System.Drawing.Point(20, 110);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(500, 60);
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.BackColor = System.Drawing.Color.MistyRose;
            label1.ForeColor = System.Drawing.Color.Maroon;
            label1.Text = "Zadej čísla a vyber operaci.";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.Padding = new System.Windows.Forms.Padding(8);

            AcceptButton = button1;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(600, 200);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "MojeKalkulacka";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
