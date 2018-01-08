using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GrafikMusteriTakip
{
    public partial class YapilanIs : Form
    {
        public YapilanIs()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Baglanti.BaglantiYolu);
        private void PostaEkle_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("İş Tanımlama Bilgileri Sisteme Kaydedilsin mi?", "Kaydetme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                OleDbCommand com = new OleDbCommand("Insert Into YapilanIs(YapilanAd) values(@A)", con);
                com.Parameters.AddWithValue("@A", IsAd.Text);
                try
                {
                    if (com.ExecuteNonQuery() > 0)
                    {
                        mesaj.Text = "Eklendi.";
                        IsAd.Text = string.Empty;
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
        private void guncllbtn_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("İş Tanımlama Bilgileri Güncellensin mi?", "Güncelleme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                OleDbCommand com = new OleDbCommand("Update YapilanIs set YapilanAd=@A where ((YapilanIs.YapilanIsID)=@ID)", con);
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
        private void Silbtn_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("İş Tanımlama Bilgileri Silinsin mi?", "Silme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                OleDbCommand com = new OleDbCommand("Update YapilanIs set IsActive=0 where ((YapilanIs.YapilanIsID)=@ID)", con);
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
        private void GelYapilan()
        {
            OleDbDataAdapter dap = new OleDbDataAdapter("select YapilanIsID,YapilanAd from YapilanIs where ((YapilanIs.IsActive)=True)", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            if (dt != null)
            {
                comboBox1.DisplayMember = "YapilanAd";
                comboBox1.ValueMember = "YapilanIsID";
                comboBox1.DataSource = dt;
                this.Width = 470;
            }
        }
        private void YapilanIs_Load(object sender, EventArgs e)
        {
            GelYapilan();
            this.KeyPreview = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guncellebox.Text = comboBox1.Text.ToString();
        }
        private void YapilanIs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
