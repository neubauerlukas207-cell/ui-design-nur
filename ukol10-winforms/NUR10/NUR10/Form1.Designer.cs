namespace NUR10
{
    partial class Obrázky
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rbV1 = new System.Windows.Forms.RadioButton();
            this.rbV2 = new System.Windows.Forms.RadioButton();
            this.rbV3 = new System.Windows.Forms.RadioButton();
            this.btnSmazat = new System.Windows.Forms.Button();
            this.btnVlozit = new System.Windows.Forms.Button();
            this.rbS1 = new System.Windows.Forms.RadioButton();
            this.rbS2 = new System.Windows.Forms.RadioButton();
            this.rbS3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(27, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.picture_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.picture_DoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(148, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.picture_Click);
            this.pictureBox2.DoubleClick += new System.EventHandler(this.picture_DoubleClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(269, 144);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 113);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.Picture_Click);
            this.pictureBox3.DoubleClick += new System.EventHandler(this.Picture_DoubleClick);
            // 
            // rbV1
            // 
            this.rbV1.AutoSize = true;
            this.rbV1.Location = new System.Drawing.Point(0, 19);
            this.rbV1.Name = "rbV1";
            this.rbV1.Size = new System.Drawing.Size(75, 17);
            this.rbV1.TabIndex = 3;
            this.rbV1.TabStop = true;
            this.rbV1.Text = "1. obrázek";
            this.rbV1.UseVisualStyleBackColor = true;
            this.rbV1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbV2
            // 
            this.rbV2.AutoSize = true;
            this.rbV2.Location = new System.Drawing.Point(0, 44);
            this.rbV2.Name = "rbV2";
            this.rbV2.Size = new System.Drawing.Size(75, 17);
            this.rbV2.TabIndex = 4;
            this.rbV2.TabStop = true;
            this.rbV2.Text = "2. obrázek";
            this.rbV2.UseVisualStyleBackColor = true;
            // 
            // rbV3
            // 
            this.rbV3.AutoSize = true;
            this.rbV3.Location = new System.Drawing.Point(0, 67);
            this.rbV3.Name = "rbV3";
            this.rbV3.Size = new System.Drawing.Size(75, 17);
            this.rbV3.TabIndex = 5;
            this.rbV3.TabStop = true;
            this.rbV3.Text = "3. obrázek";
            this.rbV3.UseVisualStyleBackColor = true;
            this.rbV3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btnSmazat
            // 
            this.btnSmazat.Location = new System.Drawing.Point(111, 36);
            this.btnSmazat.Name = "btnSmazat";
            this.btnSmazat.Size = new System.Drawing.Size(72, 58);
            this.btnSmazat.TabIndex = 6;
            this.btnSmazat.Text = "Smazat obrázek";
            this.btnSmazat.UseVisualStyleBackColor = true;
            this.btnSmazat.Click += new System.EventHandler(this.btnSmazat_Click);
            // 
            // btnVlozit
            // 
            this.btnVlozit.Location = new System.Drawing.Point(92, 34);
            this.btnVlozit.Name = "btnVlozit";
            this.btnVlozit.Size = new System.Drawing.Size(69, 60);
            this.btnVlozit.TabIndex = 7;
            this.btnVlozit.Text = "Vložit obrázek";
            this.btnVlozit.UseVisualStyleBackColor = true;
            this.btnVlozit.Click += new System.EventHandler(this.btnVlozit_click);
            // 
            // rbS1
            // 
            this.rbS1.AutoSize = true;
            this.rbS1.Location = new System.Drawing.Point(0, 19);
            this.rbS1.Name = "rbS1";
            this.rbS1.Size = new System.Drawing.Size(75, 17);
            this.rbS1.TabIndex = 8;
            this.rbS1.TabStop = true;
            this.rbS1.Text = "1. obrázek";
            this.rbS1.UseVisualStyleBackColor = true;
            this.rbS1.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbS2
            // 
            this.rbS2.AutoSize = true;
            this.rbS2.Location = new System.Drawing.Point(0, 42);
            this.rbS2.Name = "rbS2";
            this.rbS2.Size = new System.Drawing.Size(75, 17);
            this.rbS2.TabIndex = 9;
            this.rbS2.TabStop = true;
            this.rbS2.Text = "2. obrázek";
            this.rbS2.UseVisualStyleBackColor = true;
            this.rbS2.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rbS3
            // 
            this.rbS3.AutoSize = true;
            this.rbS3.Location = new System.Drawing.Point(0, 65);
            this.rbS3.Name = "rbS3";
            this.rbS3.Size = new System.Drawing.Size(75, 17);
            this.rbS3.TabIndex = 10;
            this.rbS3.TabStop = true;
            this.rbS3.Text = "3. obrázek";
            this.rbS3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.rbV1);
            this.groupBox1.Controls.Add(this.rbV2);
            this.groupBox1.Controls.Add(this.btnVlozit);
            this.groupBox1.Controls.Add(this.rbV3);
            this.groupBox1.Location = new System.Drawing.Point(27, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vloženi obrázku";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.rbS1);
            this.groupBox2.Controls.Add(this.rbS2);
            this.groupBox2.Controls.Add(this.rbS3);
            this.groupBox2.Controls.Add(this.btnSmazat);
            this.groupBox2.Location = new System.Drawing.Point(200, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mazání obrázku";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Obrázky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 259);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Obrázky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galerie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackColorChanged += new System.EventHandler(this.radientInactiveCaption);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton rbV1;
        private System.Windows.Forms.RadioButton rbV2;
        private System.Windows.Forms.RadioButton rbV3;
        private System.Windows.Forms.Button btnSmazat;
        private System.Windows.Forms.Button btnVlozit;
        private System.Windows.Forms.RadioButton rbS1;
        private System.Windows.Forms.RadioButton rbS2;
        private System.Windows.Forms.RadioButton rbS3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

