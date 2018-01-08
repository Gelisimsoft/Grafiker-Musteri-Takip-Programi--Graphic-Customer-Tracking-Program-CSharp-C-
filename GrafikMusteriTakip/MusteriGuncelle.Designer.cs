namespace GrafikMusteriTakip
{
    partial class MusteriGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriGuncelle));
            this.YCep = new System.Windows.Forms.MaskedTextBox();
            this.Faks = new System.Windows.Forms.MaskedTextBox();
            this.Tlf = new System.Windows.Forms.MaskedTextBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.Temizle = new System.Windows.Forms.Button();
            this.FUnvan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.VNo = new System.Windows.Forms.TextBox();
            this.Vdairesi = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.TextBox();
            this.Eposta = new System.Windows.Forms.TextBox();
            this.YAdi = new System.Windows.Forms.TextBox();
            this.FAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YCep
            // 
            this.YCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YCep.Location = new System.Drawing.Point(95, 75);
            this.YCep.Mask = "999-000-0000";
            this.YCep.Name = "YCep";
            this.YCep.Size = new System.Drawing.Size(169, 20);
            this.YCep.TabIndex = 46;
            // 
            // Faks
            // 
            this.Faks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Faks.Location = new System.Drawing.Point(95, 121);
            this.Faks.Mask = "(999) 000-0000";
            this.Faks.Name = "Faks";
            this.Faks.Size = new System.Drawing.Size(169, 20);
            this.Faks.TabIndex = 49;
            // 
            // Tlf
            // 
            this.Tlf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tlf.Location = new System.Drawing.Point(95, 98);
            this.Tlf.Mask = "(999) 000-0000";
            this.Tlf.Name = "Tlf";
            this.Tlf.Size = new System.Drawing.Size(169, 20);
            this.Tlf.TabIndex = 47;
            // 
            // Ekle
            // 
            this.Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ekle.Location = new System.Drawing.Point(10, 290);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(117, 23);
            this.Ekle.TabIndex = 58;
            this.Ekle.Text = "Güncelle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Temizle
            // 
            this.Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Temizle.Location = new System.Drawing.Point(147, 290);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(117, 23);
            this.Temizle.TabIndex = 59;
            this.Temizle.Text = "Sil";
            this.Temizle.UseVisualStyleBackColor = true;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // FUnvan
            // 
            this.FUnvan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FUnvan.Location = new System.Drawing.Point(95, 29);
            this.FUnvan.Name = "FUnvan";
            this.FUnvan.Size = new System.Drawing.Size(169, 20);
            this.FUnvan.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Firma Ünvan";
            // 
            // VNo
            // 
            this.VNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VNo.Location = new System.Drawing.Point(95, 264);
            this.VNo.Name = "VNo";
            this.VNo.Size = new System.Drawing.Size(169, 20);
            this.VNo.TabIndex = 56;
            // 
            // Vdairesi
            // 
            this.Vdairesi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Vdairesi.Location = new System.Drawing.Point(95, 241);
            this.Vdairesi.Name = "Vdairesi";
            this.Vdairesi.Size = new System.Drawing.Size(169, 20);
            this.Vdairesi.TabIndex = 55;
            // 
            // Adres
            // 
            this.Adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Adres.Location = new System.Drawing.Point(95, 169);
            this.Adres.Multiline = true;
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(169, 70);
            this.Adres.TabIndex = 53;
            // 
            // Eposta
            // 
            this.Eposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Eposta.Location = new System.Drawing.Point(95, 144);
            this.Eposta.Name = "Eposta";
            this.Eposta.Size = new System.Drawing.Size(169, 20);
            this.Eposta.TabIndex = 52;
            // 
            // YAdi
            // 
            this.YAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YAdi.Location = new System.Drawing.Point(95, 52);
            this.YAdi.Name = "YAdi";
            this.YAdi.Size = new System.Drawing.Size(169, 20);
            this.YAdi.TabIndex = 44;
            // 
            // FAdi
            // 
            this.FAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FAdi.Location = new System.Drawing.Point(95, 6);
            this.FAdi.Name = "FAdi";
            this.FAdi.Size = new System.Drawing.Size(169, 20);
            this.FAdi.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Vergi No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Vergi Dairesi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "E - Posta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Faks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Telefon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Yetkili Cep";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Yetkili Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Firma Adı";
            // 
            // mesaj
            // 
            this.mesaj.AutoSize = true;
            this.mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesaj.ForeColor = System.Drawing.Color.Red;
            this.mesaj.Location = new System.Drawing.Point(7, 316);
            this.mesaj.Name = "mesaj";
            this.mesaj.Size = new System.Drawing.Size(0, 13);
            this.mesaj.TabIndex = 60;
            // 
            // MusteriGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(276, 339);
            this.Controls.Add(this.mesaj);
            this.Controls.Add(this.YCep);
            this.Controls.Add(this.Faks);
            this.Controls.Add(this.Tlf);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.FUnvan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.VNo);
            this.Controls.Add(this.Vdairesi);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Eposta);
            this.Controls.Add(this.YAdi);
            this.Controls.Add(this.FAdi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MusteriGuncelle";
            this.Text = "Müşteri Güncelle";
            this.Load += new System.EventHandler(this.MusteriGuncelle_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MusteriGuncelle_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox YCep;
        private System.Windows.Forms.MaskedTextBox Faks;
        private System.Windows.Forms.MaskedTextBox Tlf;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.TextBox FUnvan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox VNo;
        private System.Windows.Forms.TextBox Vdairesi;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.TextBox Eposta;
        private System.Windows.Forms.TextBox YAdi;
        private System.Windows.Forms.TextBox FAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mesaj;
    }
}