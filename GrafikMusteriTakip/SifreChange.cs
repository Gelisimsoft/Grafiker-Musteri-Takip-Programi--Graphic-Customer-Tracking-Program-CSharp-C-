using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GrafikMusteriTakip
{
    public partial class SifreChange : Form
    {
        public SifreChange()
        {
            InitializeComponent();
        }
        private void SifreChange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        OleDbConnection con = new OleDbConnection(Baglanti.BaglantiYolu);
        private void Degistir()
        {
            OleDbCommand comcuk = new OleDbCommand("update UserTable set UserName=@U,Pass=@P where ((UserTable.UserID)=True)", con);
            comcuk.Parameters.AddWithValue("@U", kullanicibox.Text);
            comcuk.Parameters.AddWithValue("@P", sifrebox.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            if (comcuk.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Değiştirilmiştir.", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kullanicibox.Clear();
                sifrebox.Clear();
                eskisifre.Clear();
            }
            con.Close();
            comcuk.Dispose();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (KontrolEt() == true)
                {
                    Degistir();
                }
                else
                {
                    MessageBox.Show("Şifre Yanlış !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    eskisifre.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { con.Close(); }
        }
        public Boolean KontrolEt()
        {
            OleDbCommand com = new OleDbCommand("select Pass from UserTable where ((UserTable.Pass)=@P)", con);
            com.Parameters.AddWithValue("@P", eskisifre.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
            dr.Close();
            con.Close();
        }
    }
}
