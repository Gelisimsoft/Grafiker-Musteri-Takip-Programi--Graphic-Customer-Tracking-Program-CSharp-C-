using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GrafikMusteriTakip
{
    public partial class MusteriCari : Form
    {
        public MusteriCari()
        {
            InitializeComponent();
        }
        public static int GidenID;
        OleDbConnection con = new OleDbConnection(Baglanti.BaglantiYolu);
        private void Ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FAdi.Text) && !string.IsNullOrEmpty(FUnvan.Text))
            {
                DialogResult dlg = MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedilsin mi?", "Kaydetme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dlg == DialogResult.Yes)
                {
                    OleDbCommand comcuk = new OleDbCommand("Insert Into Musteriler(Ad,Unvan,Yetkili,Cep,Telefon,Faks,Posta,Adres,VDairesi,VergiNo) values(@A,@U,@Y,@C,@T,@F,@P,@Ad,@VD,@VN)", con);
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
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    try
                    {
                        if (comcuk.ExecuteNonQuery() > 0)
                        {
                            GetirBilgi();
                            Temizlik();
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
        public void GetirBilgi()
        {
            listView1.Items.Clear();
            OleDbCommand cmd = new OleDbCommand("SELECT Musteriler.MusteriID,Musteriler.Ad, Musteriler.Unvan, Musteriler.Yetkili, Musteriler.Cep FROM Musteriler WHERE ((Musteriler.IsActive)=True) order by Musteriler.Ad", con);
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
                    list.Text = rdr["MusteriID"].ToString();
                    list.SubItems.Add(rdr["Ad"].ToString());
                    list.SubItems.Add(rdr["Unvan"].ToString());
                    list.SubItems.Add(rdr["Yetkili"].ToString());
                    list.SubItems.Add(rdr["Cep"].ToString());
                    listView1.Items.Add(list);
                }
            }
            else
            {
                MessageBox.Show("Listelenecek Kayıt Bulunamadı", "Raporlama Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.F5:
                    GetirBilgi();
                    break;
                default:
                    break;
            }
        }
        private void Temizle_Click(object sender, EventArgs e)
        {
            Temizlik();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                GetirBilgi();
                this.KeyPreview = true;
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
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CariGuncelleme();
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
        private void CariGuncelleme()
        {
            int index = listView1.SelectedItems[0].Index;
            GidenID = Convert.ToInt32(listView1.Items[index].SubItems[0].Text);
            //OleDbCommand comgel = new OleDbCommand("select MusteriID from Musteriler where ((Musteriler.Cep)=@Cep) and IsActive=1", con);
            //comgel.Parameters.AddWithValue("@Cep", GelenMusteri);
            //if (con.State == ConnectionState.Closed)
            //{
            //    con.Open();
            //}
            //OleDbDataReader dr = comgel.ExecuteReader();
            //try
            //{
            //    while (dr.Read())
            //    {
            //        if (dr.HasRows == true)
            //        {
            //            GidenID = Convert.ToInt32(dr["MusteriID"]);
            //        }
            //    }
            //}
            //catch (Exception Ex)
            //{
            //    MessageBox.Show(Ex.ToString());
            //}
            //finally { con.Close(); }
            MusteriGuncelle musg = new MusteriGuncelle();
            musg.ShowDialog();
            GetirBilgi();
        }
    }
}
