namespace GrafikMusteriTakip
{
    partial class IsEmriRaporlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsEmriRaporlama));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.durumbtn = new System.Windows.Forms.Button();
            this.durumcombo = new System.Windows.Forms.ComboBox();
            this.musteribtn = new System.Windows.Forms.Button();
            this.yapilanbtn = new System.Windows.Forms.Button();
            this.mustericombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.personelbtn = new System.Windows.Forms.Button();
            this.Yapilancombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.personelcombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MatbaaAraBtn = new System.Windows.Forms.Button();
            this.Matbaacombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistemde Kayıtlı İş Emirleri Listesi";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(931, 311);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İş No";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Müşteri Ünvan";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yapılan İş";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İşin Durumu";
            this.columnHeader4.Width = 99;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sorumlu Personel";
            this.columnHeader5.Width = 124;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Başlangıç Tarihi";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Bitiş Tarihi";
            this.columnHeader7.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.durumbtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Matbaacombo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mustericombo);
            this.groupBox2.Controls.Add(this.yapilanbtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Yapilancombo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.personelcombo);
            this.groupBox2.Controls.Add(this.MatbaaAraBtn);
            this.groupBox2.Controls.Add(this.personelbtn);
            this.groupBox2.Controls.Add(this.musteribtn);
            this.groupBox2.Controls.Add(this.durumcombo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(961, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 336);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listeleme Seçenekleri";
            // 
            // durumbtn
            // 
            this.durumbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.durumbtn.Location = new System.Drawing.Point(157, 149);
            this.durumbtn.Name = "durumbtn";
            this.durumbtn.Size = new System.Drawing.Size(35, 23);
            this.durumbtn.TabIndex = 2;
            this.durumbtn.Text = "Ara";
            this.durumbtn.UseVisualStyleBackColor = true;
            this.durumbtn.Click += new System.EventHandler(this.durumbtn_Click);
            // 
            // durumcombo
            // 
            this.durumcombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.durumcombo.FormattingEnabled = true;
            this.durumcombo.Location = new System.Drawing.Point(6, 152);
            this.durumcombo.Name = "durumcombo";
            this.durumcombo.Size = new System.Drawing.Size(145, 21);
            this.durumcombo.TabIndex = 1;
            // 
            // musteribtn
            // 
            this.musteribtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteribtn.Location = new System.Drawing.Point(157, 35);
            this.musteribtn.Name = "musteribtn";
            this.musteribtn.Size = new System.Drawing.Size(35, 23);
            this.musteribtn.TabIndex = 2;
            this.musteribtn.Text = "Ara";
            this.musteribtn.UseVisualStyleBackColor = true;
            this.musteribtn.Click += new System.EventHandler(this.musteribtn_Click);
            // 
            // yapilanbtn
            // 
            this.yapilanbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yapilanbtn.Location = new System.Drawing.Point(157, 267);
            this.yapilanbtn.Name = "yapilanbtn";
            this.yapilanbtn.Size = new System.Drawing.Size(35, 23);
            this.yapilanbtn.TabIndex = 2;
            this.yapilanbtn.Text = "Ara";
            this.yapilanbtn.UseVisualStyleBackColor = true;
            this.yapilanbtn.Click += new System.EventHandler(this.yapilanbtn_Click);
            // 
            // mustericombo
            // 
            this.mustericombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mustericombo.FormattingEnabled = true;
            this.mustericombo.Location = new System.Drawing.Point(6, 35);
            this.mustericombo.Name = "mustericombo";
            this.mustericombo.Size = new System.Drawing.Size(145, 21);
            this.mustericombo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Durum";
            // 
            // personelbtn
            // 
            this.personelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelbtn.Location = new System.Drawing.Point(157, 212);
            this.personelbtn.Name = "personelbtn";
            this.personelbtn.Size = new System.Drawing.Size(35, 23);
            this.personelbtn.TabIndex = 2;
            this.personelbtn.Text = "Ara";
            this.personelbtn.UseVisualStyleBackColor = true;
            this.personelbtn.Click += new System.EventHandler(this.personelbtn_Click);
            // 
            // Yapilancombo
            // 
            this.Yapilancombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yapilancombo.FormattingEnabled = true;
            this.Yapilancombo.Location = new System.Drawing.Point(6, 268);
            this.Yapilancombo.Name = "Yapilancombo";
            this.Yapilancombo.Size = new System.Drawing.Size(145, 21);
            this.Yapilancombo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yapılan İş";
            // 
            // personelcombo
            // 
            this.personelcombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelcombo.FormattingEnabled = true;
            this.personelcombo.Location = new System.Drawing.Point(6, 213);
            this.personelcombo.Name = "personelcombo";
            this.personelcombo.Size = new System.Drawing.Size(145, 21);
            this.personelcombo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel";
            // 
            // MatbaaAraBtn
            // 
            this.MatbaaAraBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatbaaAraBtn.Location = new System.Drawing.Point(157, 92);
            this.MatbaaAraBtn.Name = "MatbaaAraBtn";
            this.MatbaaAraBtn.Size = new System.Drawing.Size(35, 23);
            this.MatbaaAraBtn.TabIndex = 2;
            this.MatbaaAraBtn.Text = "Ara";
            this.MatbaaAraBtn.UseVisualStyleBackColor = true;
            this.MatbaaAraBtn.Click += new System.EventHandler(this.MatbaaAraBtn_Click);
            // 
            // Matbaacombo
            // 
            this.Matbaacombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Matbaacombo.FormattingEnabled = true;
            this.Matbaacombo.Location = new System.Drawing.Point(6, 92);
            this.Matbaacombo.Name = "Matbaacombo";
            this.Matbaacombo.Size = new System.Drawing.Size(145, 21);
            this.Matbaacombo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Matbaa";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Matbaa";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 150;
            // 
            // IsEmriRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1161, 357);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IsEmriRaporlama";
            this.Text = "Iş Emri Raporlama";
            this.Load += new System.EventHandler(this.IsEmriRaporlama_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsEmriRaporlama_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button durumbtn;
        private System.Windows.Forms.ComboBox durumcombo;
        private System.Windows.Forms.Button musteribtn;
        private System.Windows.Forms.Button yapilanbtn;
        private System.Windows.Forms.ComboBox mustericombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button personelbtn;
        private System.Windows.Forms.ComboBox Yapilancombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox personelcombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Matbaacombo;
        private System.Windows.Forms.Button MatbaaAraBtn;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}