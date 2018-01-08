using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GrafikMusteriTakip
{
    public partial class IsEmri : Form
    {
        public IsEmri()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Baglanti.BaglantiYolu);

        private void GelYapilaKontol()
        {
            OleDbDataAdapter dap = new OleDbDataAdapter("select KontrolID,KontrolAd from Kontrol where ((Kontrol.IsActive)=True)", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            if (dt != null)
            {
                durumcombo.DisplayMember = "KontrolAd";
                durumcombo.ValueMember = "KontrolID";
                durumcombo.DataSource = dt;
            }
        }
        private void GelYapilamusteri()
        {
            OleDbDataAdapter dap = new OleDbDataAdapter("select MusteriID,Ad from Musteriler where ((Musteriler.IsActive)=True)", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            if (dt != null)
            {
                mustericombo.DisplayMember = "Ad";
                mustericombo.ValueMember = "MusteriID";
                mustericombo.DataSource = dt;
            }
        }
        private void GelYapilaMatbaa()
        {
            OleDbDataAdapter dap = new OleDbDataAdapter("select MatbaaID,Ad from Matbaa where ((Matbaa.IsActive)=True)", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            if (dt != null)
            {
                Matbaacombo.DisplayMember = "Ad";
                Matbaacombo.ValueMember = "MatbaaID";
                Matbaacombo.DataSource = dt;
            }
        }
        private void GelYapilanPersonel()
        {
            OleDbDataAdapter dap = new OleDbDataAdapter("select PersonelID,PersonelAd from Personel where ((Personel.IsActive)=True)", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            if (dt != null)
            {
                personelcombo.DisplayMember = "PersonelAd";
                personelcombo.ValueMember = "PersonelID";
                personelcombo.DataSource = dt;
            }
        }
        private void GelYapilan()
        {
            OleDbDataAdapter dap = new OleDbDataAdapter("select YapilanIsID,YapilanAd from YapilanIs where ((YapilanIs.IsActive)=True)", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            if (dt != null)
            {
                Yapilancombo.DisplayMember = "YapilanAd";
                Yapilancombo.ValueMember = "YapilanIsID";
                Yapilancombo.DataSource = dt;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("İş Emri Sisteme Kaydedilsin mi?", "Kaydetme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                try
                {
                    OleDbCommand com = new OleDbCommand("Insert Into IsEmri(MusteriID,YapilanIsID,Kontrol,PersonelID,MatbaaID,Baslangic) values(@M,@Y,@K,@P,@MID,@B)", con);
                    com.Parameters.AddWithValue("@M", Convert.ToInt32(mustericombo.SelectedValue));
                    com.Parameters.AddWithValue("@Y", Convert.ToInt32(Yapilancombo.SelectedValue));
                    com.Parameters.AddWithValue("@K", durumcombo.Text.ToString());
                    com.Parameters.AddWithValue("@P", Convert.ToInt32(personelcombo.SelectedValue));
                    com.Parameters.AddWithValue("@MID", Convert.ToInt32(Matbaacombo.SelectedValue));
                    com.Parameters.AddWithValue("@B", dateTimePicker1.Value.ToLongDateString());
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Kayıt Yapıldı.");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
                finally { con.Close(); }
            }
        }

        private void IsEmri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void IsEmri_Load(object sender, EventArgs e)
        {
            GelYapilaKontol();
            GelYapilamusteri();
            GelYapilan();
            GelYapilanPersonel();
            GelYapilaMatbaa();
        }
    }
}
