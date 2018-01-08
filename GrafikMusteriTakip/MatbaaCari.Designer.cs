namespace GrafikMusteriTakip
{
    partial class MatbaaCari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatbaaCari));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(7, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 317);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistemde Kayıtlı Matbaalar";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(715, 292);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Firma Adı";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Firma Ünvanı";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yetkili Adı";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yetkili Cep";
            this.columnHeader5.Width = 100;
            // 
            // YCep
            // 
            this.YCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YCep.Location = new System.Drawing.Point(79, 78);
            this.YCep.Mask = "999-000-0000";
            this.YCep.Name = "YCep";
            this.YCep.Size = new System.Drawing.Size(169, 20);
            this.YCep.TabIndex = 22;
            // 
            // Faks
            // 
            this.Faks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Faks.Location = new System.Drawing.Point(79, 124);
            this.Faks.Mask = "(999) 000-0000";
            this.Faks.Name = "Faks";
            this.Faks.Size = new System.Drawing.Size(169, 20);
            this.Faks.TabIndex = 25;
            // 
            // Tlf
            // 
            this.Tlf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tlf.Location = new System.Drawing.Point(79, 101);
            this.Tlf.Mask = "(999) 000-0000";
            this.Tlf.Name = "Tlf";
            this.Tlf.Size = new System.Drawing.Size(169, 20);
            this.Tlf.TabIndex = 23;
            // 
            // Ekle
            // 
            this.Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ekle.Location = new System.Drawing.Point(573, 10);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(161, 36);
            this.Ekle.TabIndex = 36;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Temizle
            // 
            this.Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Temizle.Location = new System.Drawing.Point(573, 55);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(161, 36);
            this.Temizle.TabIndex = 37;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // FUnvan
            // 
            this.FUnvan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FUnvan.Location = new System.Drawing.Point(79, 32);
            this.FUnvan.Name = "FUnvan";
            this.FUnvan.Size = new System.Drawing.Size(169, 20);
            this.FUnvan.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Firma Ünvan";
            // 
            // VNo
            // 
            this.VNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VNo.Location = new System.Drawing.Point(347, 126);
            this.VNo.Name = "VNo";
            this.VNo.Size = new System.Drawing.Size(216, 20);
            this.VNo.TabIndex = 33;
            // 
            // Vdairesi
            // 
            this.Vdairesi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Vdairesi.Location = new System.Drawing.Point(347, 103);
            this.Vdairesi.Name = "Vdairesi";
            this.Vdairesi.Size = new System.Drawing.Size(216, 20);
            this.Vdairesi.TabIndex = 32;
            // 
            // Adres
            // 
            this.Adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Adres.Location = new System.Drawing.Point(347, 28);
            this.Adres.Multiline = true;
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(216, 70);
            this.Adres.TabIndex = 29;
            // 
            // Eposta
            // 
            this.Eposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Eposta.Location = new System.Drawing.Point(347, 7);
            this.Eposta.Name = "Eposta";
            this.Eposta.Size = new System.Drawing.Size(216, 20);
            this.Eposta.TabIndex = 28;
            // 
            // YAdi
            // 
            this.YAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YAdi.Location = new System.Drawing.Point(79, 55);
            this.YAdi.Name = "YAdi";
            this.YAdi.Size = new System.Drawing.Size(169, 20);
            this.YAdi.TabIndex = 20;
            // 
            // FAdi
            // 
            this.FAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FAdi.Location = new System.Drawing.Point(79, 9);
            this.FAdi.Name = "FAdi";
            this.FAdi.Size = new System.Drawing.Size(169, 20);
            this.FAdi.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Vergi No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Vergi Dairesi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "E - Posta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Faks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Telefon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Yetkili Cep";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Yetkili Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Firma Adı";
            // 
            // MatbaaCari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(737, 473);
            this.Controls.Add(this.groupBox1);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MatbaaCari";
            this.Text = "Matbaa Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
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
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

