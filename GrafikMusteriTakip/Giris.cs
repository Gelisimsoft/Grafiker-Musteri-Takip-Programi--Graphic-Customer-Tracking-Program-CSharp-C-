using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GrafikMusteriTakip
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(Baglanti.BaglantiYolu);
            OleDbCommand com = new OleDbCommand("select UserName,Pass from UserTable where (((UserTable.UserName)=@U) and ((UserTable.Pass)=@P))", con);
            com.Parameters.AddWithValue("@U", textBox1.Text);
            com.Parameters.AddWithValue("@P", textBox2.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbDataReader dr = com.ExecuteReader();
            if (dr.Read() == true)
            {
                if (!dr.IsDBNull(0))
                {
                    this.Visible = false;
                    Anamenu ana = new Anamenu();
                    ana.Show();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Yanlış !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void Giris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.ExitThread();
            }
        }
    }
}

