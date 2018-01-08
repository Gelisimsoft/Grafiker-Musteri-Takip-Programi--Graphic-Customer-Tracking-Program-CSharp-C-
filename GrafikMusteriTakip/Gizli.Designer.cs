namespace GrafikMusteriTakip
{
    partial class Gizli
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gizli));
            this.musterigroup = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mesajgun = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NotGuntxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.musteriguncombo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mesajekle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notEktxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.musterieklecombo = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.şifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.sifrebtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sifregroup = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.musterigroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.sifregroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // musterigroup
            // 
            this.musterigroup.Controls.Add(this.groupBox2);
            this.musterigroup.Controls.Add(this.groupBox3);
            this.musterigroup.Location = new System.Drawing.Point(12, 12);
            this.musterigroup.Name = "musterigroup";
            this.musterigroup.Size = new System.Drawing.Size(539, 361);
            this.musterigroup.TabIndex = 0;
            this.musterigroup.TabStop = false;
            this.musterigroup.Text = "Müşteri Bilgi Bankası";
            this.musterigroup.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mesajgun);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NotGuntxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.musteriguncombo);
            this.groupBox2.Location = new System.Drawing.Point(9, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 163);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Güncelleme";
            // 
            // mesajgun
            // 
            this.mesajgun.AutoSize = true;
            this.mesajgun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesajgun.ForeColor = System.Drawing.Color.White;
            this.mesajgun.Location = new System.Drawing.Point(383, 139);
            this.mesajgun.Name = "mesajgun";
            this.mesajgun.Size = new System.Drawing.Size(0, 13);
            this.mesajgun.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Müşteri";
            // 
            // NotGuntxt
            // 
            this.NotGuntxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotGuntxt.Location = new System.Drawing.Point(62, 40);
            this.NotGuntxt.Multiline = true;
            this.NotGuntxt.Name = "NotGuntxt";
            this.NotGuntxt.Size = new System.Drawing.Size(456, 83);
            this.NotGuntxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Not";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(62, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // musteriguncombo
            // 
            this.musteriguncombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriguncombo.FormattingEnabled = true;
            this.musteriguncombo.Location = new System.Drawing.Point(62, 13);
            this.musteriguncombo.Name = "musteriguncombo";
            this.musteriguncombo.Size = new System.Drawing.Size(456, 21);
            this.musteriguncombo.TabIndex = 1;
            this.musteriguncombo.SelectedIndexChanged += new System.EventHandler(this.musteriguncombo_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mesajekle);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.notEktxt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.musterieklecombo);
            this.groupBox3.Location = new System.Drawing.Point(10, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(527, 163);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekleme";
            // 
            // mesajekle
            // 
            this.mesajekle.AutoSize = true;
            this.mesajekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesajekle.ForeColor = System.Drawing.Color.White;
            this.mesajekle.Location = new System.Drawing.Point(221, 139);
            this.mesajekle.Name = "mesajekle";
            this.mesajekle.Size = new System.Drawing.Size(0, 13);
            this.mesajekle.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri";
            // 
            // notEktxt
            // 
            this.notEktxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notEktxt.Location = new System.Drawing.Point(62, 39);
            this.notEktxt.Multiline = true;
            this.notEktxt.Name = "notEktxt";
            this.notEktxt.Size = new System.Drawing.Size(459, 83);
            this.notEktxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Not";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(62, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // musterieklecombo
            // 
            this.musterieklecombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musterieklecombo.FormattingEnabled = true;
            this.musterieklecombo.Location = new System.Drawing.Point(62, 13);
            this.musterieklecombo.Name = "musterieklecombo";
            this.musterieklecombo.Size = new System.Drawing.Size(459, 21);
            this.musterieklecombo.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreDeğiştirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 26);
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            this.şifreDeğiştirToolStripMenuItem.Image = global::GrafikMusteriTakip.Properties.Resources.security_locked_16;
            this.şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            this.şifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.şifreDeğiştirToolStripMenuItem.Text = "Şifre Değiştir";
            this.şifreDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.şifreDeğiştirToolStripMenuItem_Click);
            // 
            // sifretxt
            // 
            this.sifretxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifretxt.Location = new System.Drawing.Point(68, 19);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(165, 20);
            this.sifretxt.TabIndex = 6;
            // 
            // sifrebtn
            // 
            this.sifrebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sifrebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrebtn.Location = new System.Drawing.Point(248, 17);
            this.sifrebtn.Name = "sifrebtn";
            this.sifrebtn.Size = new System.Drawing.Size(125, 23);
            this.sifrebtn.TabIndex = 7;
            this.sifrebtn.Text = "Şifre Değiştir";
            this.sifrebtn.UseVisualStyleBackColor = true;
            this.sifrebtn.Click += new System.EventHandler(this.sifrebtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sifrebtn);
            this.groupBox4.Controls.Add(this.sifretxt);
            this.groupBox4.Location = new System.Drawing.Point(12, 379);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(539, 51);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Şifre İşlemleri";
            // 
            // sifregroup
            // 
            this.sifregroup.Controls.Add(this.button3);
            this.sifregroup.Controls.Add(this.textBox1);
            this.sifregroup.Location = new System.Drawing.Point(12, 1);
            this.sifregroup.Name = "sifregroup";
            this.sifregroup.Size = new System.Drawing.Size(543, 195);
            this.sifregroup.TabIndex = 0;
            this.sifregroup.TabStop = false;
            this.sifregroup.Text = "Özel Bölüm Giriş";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(32, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(422, 54);
            this.button3.TabIndex = 1;
            this.button3.Text = "Giriş";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(32, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '#';
            this.textBox1.Size = new System.Drawing.Size(422, 83);
            this.textBox1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(224, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Gizli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(559, 203);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.musterigroup);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.sifregroup);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Gizli";
            this.Text = "Özel Bölüm";
            this.Load += new System.EventHandler(this.Gizli_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gizli_KeyDown);
            this.musterigroup.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.sifregroup.ResumeLayout(false);
            this.sifregroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox musterigroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NotGuntxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox musteriguncombo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox notEktxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox musterieklecombo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.Button sifrebtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label mesajekle;
        private System.Windows.Forms.Label mesajgun;
        private System.Windows.Forms.GroupBox sifregroup;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
    }
}