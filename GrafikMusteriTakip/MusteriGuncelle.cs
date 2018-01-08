using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GrafikMusteriTakip
{
    public partial class MusteriGuncelle : Form
    {
        public MusteriGuncelle()
        {
            InitializeComponent();
        }
        private void GetirBilgi()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Musteriler WHERE ((Musteriler.MusteriID)=@ID)", con);
            cmd.Parameters.AddWithValue("@ID", GelenID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbDataReader rdr = cmd.ExecuteReader();
            if (rdr != null)
            {
                while (rdr.Read())
                {
                    ListViewItem list = new ListViewItem();
                    FAdi.Text = rdr["Ad"].ToString();
                    FUnvan.Text = rdr["Unvan"].ToString();
                    YAdi.Text = rdr["Yetkili"].ToString();
                    YCep.Text = rdr["Cep"].ToString();
                    Tlf.Text = rdr["Telefon"].ToString();
                    Faks.Text = rdr["Faks"].ToString();
                    Eposta.Text = rdr["Posta"].ToString();
                    Adres.Text = rdr["Adres"].ToString();
                    Vdairesi.Text = rdr["VDairesi"].ToString();
                    VNo.Text = rdr["VergiNo"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Listelenecek Kayıt Bulunamadı", "Raporlama Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
        private static int GelenID;
        OleDbConnection con = new OleDbConnection(Baglanti.BaglantiYolu);
        private void Ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FAdi.Text) && !string.IsNullOrEmpty(FUnvan.Text))
            {
                DialogResult dlg = MessageBox.Show("Müşteri Bilgileri Güncellensin mi?", "Güncellenme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dlg == DialogResult.Yes)
                {
                    OleDbCommand comcuk = new OleDbCommand("Update Musteriler set Ad=@A,Unvan=@U,Yetkili=@Y,Cep=@C,Telefon=@T,Faks=@F,Posta=@P,Adres=@Ad,VDairesi=@VD,VergiNo=@VN where ((Musteriler.MusteriID)=@ID)", con);
                    comcuk.Parameters.AddWithValue("@A", FAdi.Text);
                    comcuk.Parameters.AddWithValue("@U", FUnvan.Text);
                    comcuk.Parameters.AddWithValue("@Y", YAdi.Text);
                    comcuk.Parameters.AddWithValue("@C", YCep.Text);
                    comcuk.Parameters.AddWithValue("@T", Tlf.Text);
                    comcuk.Parameters.AddWithValue("@F", Faks.Text);
                    comcuk.Parameters.AddWithValue("@P", Eposta.Text);
                    comcuk.Parameters.AddWithValue("@Ad", Adres.Text);
                    comcuk.Parameters.AddWithValue("@VD", Vdairesi.Text);
                    comcuk.Parameters.AddWithValue("@VN", VNo.Text);
                    comcuk.Parameters.AddWithValue("@ID", GelenID);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    try
                    {
                        if (comcuk.ExecuteNonQuery() > 0)
                        {
                            Temizlik();
                            mesaj.Text = "Güncellendi.";
                            this.Close();
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Bilgi girişi iptal edildi", "Kayıt İptal", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {
            try
            {
                this.KeyPreview = true;
                GelenID = Convert.ToInt32(MusteriCari.GidenID);
                GetirBilgi();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        private void Temizlik()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                    YCep.Text = string.Empty;
                    Faks.Text = string.Empty;
                    Tlf.Text = string.Empty;
                }
            }
        }
        private void MusteriGuncelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void Temizle_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Müşteri Bilgileri Silinsinn mi?", "Silme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                OleDbCommand comcuk = new OleDbCommand("Update Musteriler set IsActive=0 where ((Musteriler.MusteriID)=@ID)", con);
                comcuk.Parameters.AddWithValue("@ID", GelenID);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                try
                {
                    if (comcuk.ExecuteNonQuery() > 0)
                    {
                        Temizlik();
                        mesaj.Text = "Silindi.";
                        this.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Bilgi girişi iptal edildi", "Kayıt İptal", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
