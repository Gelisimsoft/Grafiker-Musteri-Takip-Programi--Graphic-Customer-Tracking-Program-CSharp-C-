namespace GrafikMusteriTakip
{
    partial class Personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel));
            this.mesajgun = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Silbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guncllbtn = new System.Windows.Forms.Button();
            this.Guncellebox = new System.Windows.Forms.TextBox();
            this.mesaj = new System.Windows.Forms.Label();
            this.PostaEkle = new System.Windows.Forms.Button();
            this.PersonelAd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mesajgun
            // 
            this.mesajgun.AutoSize = true;
            this.mesajgun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesajgun.ForeColor = System.Drawing.Color.Red;
            this.mesajgun.Location = new System.Drawing.Point(6, 101);
            this.mesajgun.Name = "mesajgun";
            this.mesajgun.Size = new System.Drawing.Size(0, 13);
            this.mesajgun.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Silbtn
            // 
            this.Silbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Silbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Silbtn.Location = new System.Drawing.Point(133, 72);
            this.Silbtn.Name = "Silbtn";
            this.Silbtn.Size = new System.Drawing.Size(104, 26);
            this.Silbtn.TabIndex = 1;
            this.Silbtn.Text = "Sil";
            this.Silbtn.UseVisualStyleBackColor = true;
            this.Silbtn.Click += new System.EventHandler(this.Silbtn_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mesajgun);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Silbtn);
            this.groupBox1.Controls.Add(this.guncllbtn);
            this.groupBox1.Controls.Add(this.Guncellebox);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 124);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güncelle";
            // 
            // guncllbtn
            // 
            this.guncllbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncllbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncllbtn.Location = new System.Drawing.Point(6, 72);
            this.guncllbtn.Name = "guncllbtn";
            this.guncllbtn.Size = new System.Drawing.Size(104, 26);
            this.guncllbtn.TabIndex = 1;
            this.guncllbtn.Text = "Güncelle";
            this.guncllbtn.UseVisualStyleBackColor = true;
            this.guncllbtn.Click += new System.EventHandler(this.guncllbtn_Click_1);
            // 
            // Guncellebox
            // 
            this.Guncellebox.Location = new System.Drawing.Point(7, 46);
            this.Guncellebox.Name = "Guncellebox";
            this.Guncellebox.Size = new System.Drawing.Size(230, 20);
            this.Guncellebox.TabIndex = 0;
            // 
            // mesaj
            // 
            this.mesaj.AutoSize = true;
            this.mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesaj.ForeColor = System.Drawing.Color.Red;
            this.mesaj.Location = new System.Drawing.Point(4, 70);
            this.mesaj.Name = "mesaj";
            this.mesaj.Size = new System.Drawing.Size(0, 13);
            this.mesaj.TabIndex = 16;
            // 
            // PostaEkle
            // 
            this.PostaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PostaEkle.Location = new System.Drawing.Point(76, 46);
            this.PostaEkle.Name = "PostaEkle";
            this.PostaEkle.Size = new System.Drawing.Size(161, 26);
            this.PostaEkle.TabIndex = 1;
            this.PostaEkle.Text = "Ekle";
            this.PostaEkle.UseVisualStyleBackColor = true;
            this.PostaEkle.Click += new System.EventHandler(this.PostaEkle_Click_1);
            // 
            // PersonelAd
            // 
            this.PersonelAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PersonelAd.Location = new System.Drawing.Point(76, 20);
            this.PersonelAd.Name = "PersonelAd";
            this.PersonelAd.Size = new System.Drawing.Size(161, 20);
            this.PersonelAd.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mesaj);
            this.groupBox3.Controls.Add(this.PostaEkle);
            this.groupBox3.Controls.Add(this.PersonelAd);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 86);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personel Tanımlama";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Personel Adı";
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(263, 236);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Personel";
            this.Text = "Personel Kayıt";
            this.Load += new System.EventHandler(this.Personel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Personel_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mesajgun;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Silbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button guncllbtn;
        private System.Windows.Forms.TextBox Guncellebox;
        private System.Windows.Forms.Label mesaj;
        private System.Windows.Forms.Button PostaEkle;
        private System.Windows.Forms.TextBox PersonelAd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
    }
}