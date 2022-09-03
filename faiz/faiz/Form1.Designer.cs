namespace faiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblsonuc = new System.Windows.Forms.Label();
            this.txtana = new System.Windows.Forms.TextBox();
            this.gunhesapla = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.temizle = new System.Windows.Forms.Button();
            this.yilhesapla = new System.Windows.Forms.Button();
            this.ayhesapla = new System.Windows.Forms.Button();
            this.lblsonuc2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvd = new System.Windows.Forms.TextBox();
            this.txtfz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsonuc.Location = new System.Drawing.Point(16, 236);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(73, 28);
            this.lblsonuc.TabIndex = 1;
            this.lblsonuc.Text = "label1";
            // 
            // txtana
            // 
            this.txtana.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtana.Location = new System.Drawing.Point(143, 62);
            this.txtana.Name = "txtana";
            this.txtana.Size = new System.Drawing.Size(137, 35);
            this.txtana.TabIndex = 2;
            // 
            // gunhesapla
            // 
            this.gunhesapla.BackColor = System.Drawing.SystemColors.Highlight;
            this.gunhesapla.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gunhesapla.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gunhesapla.Location = new System.Drawing.Point(372, 170);
            this.gunhesapla.Name = "gunhesapla";
            this.gunhesapla.Size = new System.Drawing.Size(135, 35);
            this.gunhesapla.TabIndex = 12;
            this.gunhesapla.Text = "Hesapla";
            this.gunhesapla.UseVisualStyleBackColor = false;
            this.gunhesapla.Click += new System.EventHandler(this.gunhesapla_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "Günlük Faiz Hesapla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(191, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 42);
            this.button2.TabIndex = 16;
            this.button2.Text = "Aylık Faiz Hesapla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(370, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 42);
            this.button3.TabIndex = 17;
            this.button3.Text = "Yıllık Faiz Hesapla";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.temizle);
            this.panel1.Controls.Add(this.yilhesapla);
            this.panel1.Controls.Add(this.ayhesapla);
            this.panel1.Controls.Add(this.lblsonuc2);
            this.panel1.Controls.Add(this.lblsonuc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.gunhesapla);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtvd);
            this.panel1.Controls.Add(this.txtfz);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtana);
            this.panel1.Location = new System.Drawing.Point(13, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 329);
            this.panel1.TabIndex = 5;
            this.panel1.TabStop = true;
            // 
            // temizle
            // 
            this.temizle.BackColor = System.Drawing.Color.DarkGreen;
            this.temizle.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.temizle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.temizle.Location = new System.Drawing.Point(372, 115);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(135, 35);
            this.temizle.TabIndex = 14;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = false;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // yilhesapla
            // 
            this.yilhesapla.BackColor = System.Drawing.SystemColors.Highlight;
            this.yilhesapla.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yilhesapla.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.yilhesapla.Location = new System.Drawing.Point(372, 170);
            this.yilhesapla.Name = "yilhesapla";
            this.yilhesapla.Size = new System.Drawing.Size(135, 35);
            this.yilhesapla.TabIndex = 12;
            this.yilhesapla.Text = "Hesapla";
            this.yilhesapla.UseVisualStyleBackColor = false;
            this.yilhesapla.Click += new System.EventHandler(this.yilhesapla_Click);
            // 
            // ayhesapla
            // 
            this.ayhesapla.BackColor = System.Drawing.SystemColors.Highlight;
            this.ayhesapla.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ayhesapla.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ayhesapla.Location = new System.Drawing.Point(372, 170);
            this.ayhesapla.Name = "ayhesapla";
            this.ayhesapla.Size = new System.Drawing.Size(135, 35);
            this.ayhesapla.TabIndex = 12;
            this.ayhesapla.Text = "Hesapla";
            this.ayhesapla.UseVisualStyleBackColor = false;
            this.ayhesapla.Click += new System.EventHandler(this.ayhesapla_Click);
            // 
            // lblsonuc2
            // 
            this.lblsonuc2.AutoSize = true;
            this.lblsonuc2.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsonuc2.Location = new System.Drawing.Point(16, 282);
            this.lblsonuc2.Name = "lblsonuc2";
            this.lblsonuc2.Size = new System.Drawing.Size(73, 28);
            this.lblsonuc2.TabIndex = 12;
            this.lblsonuc2.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(13, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Günlük Faiz Hesaplama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(286, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "GÜN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(286, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 34);
            this.label5.TabIndex = 9;
            this.label5.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(286, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "TL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Faiz Oranı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vade Süresi:";
            // 
            // txtvd
            // 
            this.txtvd.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtvd.Location = new System.Drawing.Point(143, 170);
            this.txtvd.Name = "txtvd";
            this.txtvd.Size = new System.Drawing.Size(137, 35);
            this.txtvd.TabIndex = 5;
            // 
            // txtfz
            // 
            this.txtfz.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtfz.Location = new System.Drawing.Point(143, 115);
            this.txtfz.Name = "txtfz";
            this.txtfz.Size = new System.Drawing.Size(137, 35);
            this.txtfz.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ana Para:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "F. Furkan Koç  •  github.com/ff-koc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(555, 436);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(571, 475);
            this.MinimumSize = new System.Drawing.Size(571, 475);
            this.Name = "Form1";
            this.Text = "Faiz Hesapla";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblsonuc;
        private TextBox txtana;
        private Button gunhesapla;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtvd;
        private TextBox txtfz;
        private Label label1;
        private Label lblsonuc2;
        private Label label8;
        private Button yilhesapla;
        private Button ayhesapla;
        private Button temizle;
    }
}