using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GrafikMusteriTakip
{
    public partial class Kontrol : Form
    {
        public Kontrol()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Baglanti.BaglantiYolu);
        private void PostaEkle_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Kontrol Tanımlama Bilgileri Sisteme Kaydedilsin mi?", "Kaydetme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                OleDbCommand com = new OleDbCommand("Insert Into Kontrol(KontrolAd) values(@A)", con);
                com.Parameters.AddWithValue("@A", KontrolAd.Text);
                try
                {
                    if (com.ExecuteNonQuery() > 0)
                    {
                        mesaj.Text = "Eklendi.";
                        KontrolAd.Text = string.Empty;
                        GelYapilaKontol();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
                finally { con.Close(); }
            }
        }
        private void guncllbtn_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Kontrol Tanımlama Bilgileri Güncellensin mi?", "Güncelleme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                OleDbCommand com = new OleDbCommand("Update Kontrol set KontrolAd=@A where ((Kontrol.KontrolID)=@ID)", con);
                com.Parameters.AddWithValue("@A", guncllbox.Text);
                com.Parameters.AddWithValue("@ID", Convert.ToInt32(comboBox1.SelectedValue));
                try
                {
                    if (com.ExecuteNonQuery() > 0)
                    {
                        mesajgun.Text = "Güncellendi.";
                        guncllbox.Text = string.Empty;
                        GelYapilaKontol();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
                finally { con.Close(); }
            }
        }
        private void Silbtn_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Kontrol Tanımlama Bilgileri Silinsin mi?", "Silme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                OleDbCommand com = new OleDbCommand("Update Kontrol set IsActive=0 where ((Kontrol.KontrolID)=@ID)", con);
                com.Parameters.AddWithValue("@ID", Convert.ToInt32(comboBox1.SelectedValue));
                try
                {
                    if (com.ExecuteNonQuery() > 0)
                    {
                        mesajgun.Text = "Silindi.";
                        guncllbox.Text = string.Empty;
                        GelYapilaKontol();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
                finally { con.Close(); }
            }
        }
        private void GelYapilaKontol()
        {
            OleDbDataAdapter dap = new OleDbDataAdapter("select KontrolID,KontrolAd from Kontrol where ((Kontrol.IsActive)=True)", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            if (dt != null)
            {
                comboBox1.DisplayMember = "KontrolAd";
                comboBox1.ValueMember = "KontrolID";
                comboBox1.DataSource = dt;
                this.Width = 425;
                this.Height = 220;
            }
        }
        private void Kontrol_Load(object sender, EventArgs e)
        {
            GelYapilaKontol();
            this.KeyPreview = true;
        }
        private void Kontrol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            guncllbox.Text = comboBox1.Text.ToString();
        }
    }
}
