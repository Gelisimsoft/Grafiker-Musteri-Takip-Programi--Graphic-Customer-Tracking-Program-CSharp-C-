using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GrafikMusteriTakip
{
    public partial class Nottxrt : Form
    {
        public Nottxrt()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Baglanti.BaglantiYolu);
        private static int GelenID;
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                durumcombo.Enabled = false;
            }
            else
            {
                durumcombo.Enabled = true;
            }
        }
        private void IsEmriGuncelle_Load(object sender, EventArgs e)
        {
            if (Anamenu.GidenID != 0)
            {
                GelenID = Convert.ToInt32(Anamenu.GidenID);
            }
            else
            {
                GelenID = Convert.ToInt32(IsEmriRaporlama.GidenID);
            }
            IsEmriBilgiGelen();
            GelYapilaKontol();
            GelYapilamusteri();
            GelYapilan();
            GelYapilanPersonel();
            GelYapilaMatbaa();
            this.KeyPreview = true;

        }
        private void IsEmriBilgiGelen()
        {

            OleDbCommand comGunce = new OleDbCommand("select MusteriID,YapilanIsID,Kontrol,PersonelID,MatbaaID,Baslangic,Notlar,Tamamlandi from IsEmri where ((IsEmri.IsEmriID)=@ID)", con);
            comGunce.Parameters.AddWithValue("@ID", GelenID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbDataReader drr = comGunce.ExecuteReader();
            try
            {
                while (drr.Read())
                {
                    if (drr.HasRows == true)
                    {
                        mustericombo.SelectedValue = Convert.ToInt32(drr["MusteriID"]);
                        Yapilancombo.SelectedValue = Convert.ToInt32(drr["YapilanIsID"]);
                        durumcombo.Text = drr["Kontrol"].ToString();
                        personelcombo.SelectedValue = Convert.ToInt32(drr["PersonelID"]);
                        dateTimePicker1.Value = Convert.ToDateTime(drr["Baslangic"]);
                        EskiNot.Text = drr["Notlar"].ToString().TrimStart();
                        if (drr["Tamamlandi"].ToString() != "True")
                        {
                            checkBox1.Checked = true;
                        }
                        else
                        {
                            checkBox1.Checked = false;
                        }
                        Matbaacombo.Text = drr["MatbaaID"].ToString();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            finally { con.Close(); }
        }
        private void IsEmriGuncelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        string GidicekNot;
        private void button1_Click(object sender, EventArgs e)
        {
            GidicekNot = Nottxt.Text + "\r\n" + "\r\nNotu Bırakan : " + personelcombo.Text.ToString() + "\r\n" + DateTime.Now;
            DialogResult dlg = MessageBox.Show("İş Emri Güncellensin mi?", "Güncellenme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                if (checkBox1.CheckState == CheckState.Checked)
                {
                    Bitti();
                }
                else
                {
                    if (string.IsNullOrEmpty(Nottxt.Text))
                    {
                        DevamEdiyorNotYok();
                    }
                    else
                    {
                        DevamEdiyorNotVar();
                    }
                }
            }
        }
        private void Bitti()
        {
            string Kon = "Teslim Edildi";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbCommand com = new OleDbCommand("Update IsEmri set MusteriID=@M,YapilanIsID=@Y,Kontrol=@K,PersonelID=@P,MatbaaID=@MID,Baslangic=@B,Bitis=@BTarih,Notlar=@N,Tamamlandi=False where ((IsEmri.IsEmriID)=@ID)", con);
            com.Parameters.AddWithValue("@M", Convert.ToInt32(mustericombo.SelectedValue));
            com.Parameters.AddWithValue("@Y", Convert.ToInt32(Yapilancombo.SelectedValue));
            com.Parameters.AddWithValue("@K", Kon.ToString());
            com.Parameters.AddWithValue("@P", Convert.ToInt32(personelcombo.SelectedValue));
            com.Parameters.AddWithValue("@MID", Convert.ToInt32(Matbaacombo.SelectedValue));
            com.Parameters.AddWithValue("@B", dateTimePicker1.Value.ToLongDateString());
            com.Parameters.AddWithValue("@BTarih", DateTime.Now.ToLongDateString());
            com.Parameters.AddWithValue("@N", GidicekNot);
            com.Parameters.AddWithValue("@ID", GelenID);
            try
            {
                if (com.ExecuteNonQuery() > 0)
                {
                    mesaj.Text = "Güncellendi.";
                    this.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            finally { con.Close(); }
        }
        private void DevamEdiyorNotYok()
        {
            string Bitis = "";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbCommand com = new OleDbCommand("Update IsEmri set MusteriID=@M,YapilanIsID=@Y,Kontrol=@K,PersonelID=@P,MatbaaID=@MID,Baslangic=@B,Bitis=@BTarih,Tamamlandi=True where ((IsEmri.IsEmriID)=@ID)", con);
            com.Parameters.AddWithValue("@M", Convert.ToInt32(mustericombo.SelectedValue));
            com.Parameters.AddWithValue("@Y", Convert.ToInt32(Yapilancombo.SelectedValue));
            com.Parameters.AddWithValue("@K", durumcombo.Text.ToString());
            com.Parameters.AddWithValue("@P", Convert.ToInt32(personelcombo.SelectedValue));
            com.Parameters.AddWithValue("@MID", Convert.ToInt32(Matbaacombo.SelectedValue));
            com.Parameters.AddWithValue("@B", dateTimePicker1.Value.ToLongDateString());
            com.Parameters.AddWithValue("@BTarih", Bitis);
            com.Parameters.AddWithValue("@ID", GelenID);
            try
            {
                if (com.ExecuteNonQuery() > 0)
                {
                    mesaj.Text = "Güncellendi.";
                    this.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            finally { con.Close(); }
        }
        private void DevamEdiyorNotVar()
        {
            string Bitis = "";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbCommand com = new OleDbCommand("Update IsEmri set MusteriID=@M,YapilanIsID=@Y,Kontrol=@K,PersonelID=@P,MatbaaID=@MID,Baslangic=@B,Bitis=@BTarih,Notlar=@N,Tamamlandi=True where ((IsEmri.IsEmriID)=@ID)", con);
            com.Parameters.AddWithValue("@M", Convert.ToInt32(mustericombo.SelectedValue));
            com.Parameters.AddWithValue("@Y", Convert.ToInt32(Yapilancombo.SelectedValue));
            com.Parameters.AddWithValue("@K", durumcombo.Text.ToString());
            com.Parameters.AddWithValue("@P", Convert.ToInt32(personelcombo.SelectedValue));
            com.Parameters.AddWithValue("@MID", Convert.ToInt32(Matbaacombo.SelectedValue));
            com.Parameters.AddWithValue("@B", dateTimePicker1.Value.ToLongDateString());
            com.Parameters.AddWithValue("@BTarih", Bitis);
            com.Parameters.AddWithValue("@N", GidicekNot);
            com.Parameters.AddWithValue("@ID", GelenID);
            try
            {
                if (com.ExecuteNonQuery() > 0)
                {
                    mesaj.Text = "Güncellendi.";
                    this.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            finally { con.Close(); }
        }
        private void Nottxt_Click(object sender, EventArgs e)
        {
            Nottxt.Clear();
        }
        private void Nottxt_Click_1(object sender, EventArgs e)
        {
            Nottxt.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("İş Emri Güncellensin mi?", "Güncellenme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                OleDbCommand com = new OleDbCommand("delete from IsEmri where ((IsEmri.IsEmriID)=@ID)", con);
                com.Parameters.AddWithValue("@ID", GelenID);
                try
                {
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Silindi", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ecx)
                {
                    MessageBox.Show(ecx.ToString());
                }
                finally { con.Close(); }
            }
        }
    }
}
