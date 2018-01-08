namespace GrafikMusteriTakip
{
    partial class Kontrol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kontrol));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mesaj = new System.Windows.Forms.Label();
            this.PostaEkle = new System.Windows.Forms.Button();
            this.KontrolAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mesajgun = new System.Windows.Forms.Label();
            this.Silbtn = new System.Windows.Forms.Button();
            this.guncllbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.guncllbox = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mesaj);
            this.groupBox3.Controls.Add(this.PostaEkle);
            this.groupBox3.Controls.Add(this.KontrolAd);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 66);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Durum SeçenekTanımlama";
            // 
            // mesaj
            // 
            this.mesaj.AutoSize = true;
            this.mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesaj.ForeColor = System.Drawing.Color.Red;
            this.mesaj.Location = new System.Drawing.Point(240, 50);
            this.mesaj.Name = "mesaj";
            this.mesaj.Size = new System.Drawing.Size(0, 13);
            this.mesaj.TabIndex = 16;
            // 
            // PostaEkle
            // 
            this.PostaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PostaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PostaEkle.Location = new System.Drawing.Point(243, 19);
            this.PostaEkle.Name = "PostaEkle";
            this.PostaEkle.Size = new System.Drawing.Size(138, 20);
            this.PostaEkle.TabIndex = 1;
            this.PostaEkle.Text = "Ekle";
            this.PostaEkle.UseVisualStyleBackColor = true;
            this.PostaEkle.Click += new System.EventHandler(this.PostaEkle_Click);
            // 
            // KontrolAd
            // 
            this.KontrolAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KontrolAd.Location = new System.Drawing.Point(64, 19);
            this.KontrolAd.Name = "KontrolAd";
            this.KontrolAd.Size = new System.Drawing.Size(173, 20);
            this.KontrolAd.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Durum Ad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mesajgun);
            this.groupBox1.Controls.Add(this.Silbtn);
            this.groupBox1.Controls.Add(this.guncllbtn);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.guncllbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 93);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güncelle";
            // 
            // mesajgun
            // 
            this.mesajgun.AutoSize = true;
            this.mesajgun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesajgun.ForeColor = System.Drawing.Color.Red;
            this.mesajgun.Location = new System.Drawing.Point(6, 69);
            this.mesajgun.Name = "mesajgun";
            this.mesajgun.Size = new System.Drawing.Size(0, 13);
            this.mesajgun.TabIndex = 4;
            // 
            // Silbtn
            // 
            this.Silbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Silbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Silbtn.Location = new System.Drawing.Point(243, 46);
            this.Silbtn.Name = "Silbtn";
            this.Silbtn.Size = new System.Drawing.Size(138, 20);
            this.Silbtn.TabIndex = 3;
            this.Silbtn.Text = "Sil";
            this.Silbtn.UseVisualStyleBackColor = true;
            this.Silbtn.Click += new System.EventHandler(this.Silbtn_Click);
            // 
            // guncllbtn
            // 
            this.guncllbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guncllbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncllbtn.Location = new System.Drawing.Point(243, 19);
            this.guncllbtn.Name = "guncllbtn";
            this.guncllbtn.Size = new System.Drawing.Size(138, 21);
            this.guncllbtn.TabIndex = 2;
            this.guncllbtn.Text = "Güncelle";
            this.guncllbtn.UseVisualStyleBackColor = true;
            this.guncllbtn.Click += new System.EventHandler(this.guncllbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // guncllbox
            // 
            this.guncllbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guncllbox.Location = new System.Drawing.Point(7, 46);
            this.guncllbox.Name = "guncllbox";
            this.guncllbox.Size = new System.Drawing.Size(230, 20);
            this.guncllbox.TabIndex = 0;
            // 
            // Kontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(409, 86);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kontrol";
            this.Text = "Durum Tanımlama";
            this.Load += new System.EventHandler(this.Kontrol_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Kontrol_KeyDown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label mesaj;
        private System.Windows.Forms.Button PostaEkle;
        private System.Windows.Forms.TextBox KontrolAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox guncllbox;
        private System.Windows.Forms.Button Silbtn;
        private System.Windows.Forms.Button guncllbtn;
        private System.Windows.Forms.Label mesajgun;
    }
}