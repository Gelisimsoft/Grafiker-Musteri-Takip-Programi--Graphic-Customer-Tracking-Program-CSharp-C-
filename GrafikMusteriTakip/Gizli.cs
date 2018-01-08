using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GrafikMusteriTakip
{
    public partial class Gizli : Form
    {
        public Gizli()
        {
            InitializeComponent();
        }
        private void GelEklemusteri()
        {
            OleDbDataAdapter dap = new OleDbDataAdapter("select MusteriID,Ad from Musteriler where ((Musteriler.IsActive)=True)", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            if (dt != null)
            {
                musterieklecombo.DisplayMember = "Ad";
                musterieklecombo.ValueMember = "MusteriID";
                musterieklecombo.DataSource = dt;
            }
        }
        private void Gelguncellemusteri()
        {
            OleDbDataAdapter dap = new OleDbDataAdapter("select MusteriID,Ad from Musteriler where ((Musteriler.IsActive)=True)", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            if (dt != null)
            {
                musteriguncombo.DisplayMember = "Ad";
                musteriguncombo.ValueMember = "MusteriID";
                musteriguncombo.DataSource = dt;
            }
        }
        OleDbConnection con = new OleDbConnection(Baglanti.BaglantiYolu);
        private void Gizli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Not Sisteme Kaydedilsin mi?", "Kaydetme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                OleDbCommand com = new OleDbCommand("Insert Into Notlar(MusteriID,Notlar) values(@M,@N)", con);
                com.Parameters.AddWithValue("@M", Convert.ToInt32(musterieklecombo.SelectedValue));
                com.Parameters.AddWithValue("@N", notEktxt.Text);
                try
                {
                    if (com.ExecuteNonQuery() > 0)
                    {
                        mesajekle.Text = "Eklendi.";
                        Temizlik();
                        Gelguncellemusteri();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
                finally { con.Close(); }
            }
        }
        private void Temizlik()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Not Sisteme Güncellensin mi?", "Güncelleme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                OleDbCommand com = new OleDbCommand("Update Notlar set Notlar=@N where ((Notlar.MusteriID)=@ID)", con);
                com.Parameters.AddWithValue("@N", NotGuntxt.Text);
                com.Parameters.AddWithValue("@ID", Convert.ToInt32(musteriguncombo.SelectedValue));
                try
                {
                    if (com.ExecuteNonQuery() > 0)
                    {
                        mesajgun.Text = "Güncellendi.";
                        Temizlik();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
                finally { con.Close(); }
            }
        }
        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 576;
            this.Height = 489;
        }
        private void Gizli_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            GelEklemusteri();
            Gelguncellemusteri();
        }
        private void musteriguncombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            NotGuntxt.Text = string.Empty;
            int GelmisID = Convert.ToInt32(musteriguncombo.SelectedValue);
            OleDbCommand comgun = new OleDbCommand("select Notlar from Notlar where ((Notlar.MusteriID)=@ID)", con);
            comgun.Parameters.AddWithValue("@ID", GelmisID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbDataReader dr = comgun.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        NotGuntxt.Text = dr["Notlar"].ToString();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            finally { con.Close(); }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OleDbCommand comgelsifre = new OleDbCommand("select Log.LogNo from Log where (((Log.LogID)=1) and ((Log.LogNo)=@No))", con);
            comgelsifre.Parameters.AddWithValue("@No", textBox1.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbDataReader drer = comgelsifre.ExecuteReader();
            if (drer.Read())
            {
                if (drer.HasRows == true)
                {
                    sifregroup.Visible = false;
                    musterigroup.Visible = true;
                    this.Height = 412;
                }
            }
            else
            {
                MessageBox.Show("Şifre Yanlış !!!");
                textBox1.Text = string.Empty;
            }
            con.Close();
        }
        private void sifrebtn_Click(object sender, EventArgs e)
        {
            OleDbCommand comgelsifre = new OleDbCommand("Update Log set LogNo=@Log where ((Log.LogID)=True)", con);
            comgelsifre.Parameters.AddWithValue("@Log", textBox1.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                if (comgelsifre.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Şifre Değiştirildi !!!", "Şifre Değişim");
                    this.Height = 412;
                    sifretxt.Text = string.Empty;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            finally { con.Close(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Not Sistemden Silinsin mi?", "Silme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                OleDbCommand com = new OleDbCommand("delete from Notlar where ((Notlar.MusteriID)=@ID)", con);
                com.Parameters.AddWithValue("@ID", Convert.ToInt32(musteriguncombo.SelectedValue));
                try
                {
                    if (com.ExecuteNonQuery() > 0)
                    {
                        mesajgun.Text = "Silindi.";
                        Temizlik();
                        Gelguncellemusteri();
                        GelEklemusteri();
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
