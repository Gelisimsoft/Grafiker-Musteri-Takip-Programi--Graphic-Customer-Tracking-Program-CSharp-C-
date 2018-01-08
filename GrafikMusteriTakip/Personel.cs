using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GrafikMusteriTakip
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Baglanti.BaglantiYolu);
        private void Personel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void GelYapilan()
        {
            OleDbDataAdapter dap = new OleDbDataAdapter("select PersonelID,PersonelAd from Personel where ((Personel.IsActive)=True)", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            if (dt != null)
            {
                comboBox1.DisplayMember = "PersonelAd";
                comboBox1.ValueMember = "PersonelID";
                comboBox1.DataSource = dt;
                this.Height = 260;
            }
        }
        private void Personel_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            GelYapilan();
        }
        private void PostaEkle_Click_1(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Personel Bilgileri Sisteme Kaydedilsin mi?", "Kaydetme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                OleDbCommand com = new OleDbCommand("Insert Into Personel(PersonelAd) values(@A)", con);
                com.Parameters.AddWithValue("@A", PersonelAd.Text);
                try
                {
                    if (com.ExecuteNonQuery() > 0)
                    {
                        mesaj.Text = "Eklendi.";
                        PersonelAd.Text = string.Empty;
                        GelYapilan();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
                finally { con.Close(); }
            }
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Guncellebox.Text = comboBox1.Text.ToString();

        }
        private void guncllbtn_Click_1(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Personel Bilgileri Güncellensin mi?", "Güncelleme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                OleDbCommand com = new OleDbCommand("Update Personel set PersonelAd=@A where ((Personel.PersonelID)=@ID)", con);
                com.Parameters.AddWithValue("@A", Guncellebox.Text);
                com.Parameters.AddWithValue("@ID", Convert.ToInt32(comboBox1.SelectedValue));
                try
                {
                    if (com.ExecuteNonQuery() > 0)
                    {
                        mesajgun.Text = "Güncellendi.";
                        Guncellebox.Text = string.Empty;
                        GelYapilan();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
                finally { con.Close(); }
            }
        }
        private void Silbtn_Click_1(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Personel Bilgileri Silinsin mi?", "Silme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                OleDbCommand com = new OleDbCommand("Update Personel set IsActive=0 where ((Personel.PersonelID)=@ID)", con);
                com.Parameters.AddWithValue("@ID", Convert.ToInt32(comboBox1.SelectedValue));
                try
                {
                    if (com.ExecuteNonQuery() > 0)
                    {
                        mesajgun.Text = "Silindi.";
                        Guncellebox.Text = string.Empty;
                        GelYapilan();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
                finally { con.Close(); }
            }
        }
    }
}
