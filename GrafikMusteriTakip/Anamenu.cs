using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GrafikMusteriTakip
{
    public partial class Anamenu : Form
    {
        public Anamenu()
        {
            InitializeComponent();
        }
        public static int GidenID;
        OleDbConnection con = new OleDbConnection(Baglanti.BaglantiYolu);
        private void Anamenu_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            GelIsEmri();
            GelDurumKontol();
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int index = listView1.SelectedItems[0].Index;
                GidenID = Convert.ToInt32(listView1.Items[index].Text);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            Nottxrt gunce = new Nottxrt();
            gunce.Show();
        }
        private void Anamenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                GelIsEmri();
            }
        }
        private void GelDurumKontol()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Baglanti.BaglantiYolu);
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
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        public void GelIsEmri()
        {
            try
            {
                listView1.Items.Clear();
                OleDbCommand dap = new OleDbCommand("SELECT IsEmri.IsEmriID, Musteriler.Unvan, Personel.PersonelAd, IsEmri.Kontrol, IsEmri.Baslangic, Matbaa.Unvan FROM ((IsEmri INNER JOIN Matbaa ON IsEmri.MatbaaID = Matbaa.MatbaaID) INNER JOIN Musteriler ON IsEmri.MusteriID = Musteriler.MusteriID) INNER JOIN Personel ON IsEmri.PersonelID = Personel.PersonelID where ((IsEmri.Tamamlandi)=True)", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                OleDbDataReader rdr = dap.ExecuteReader();
                if (rdr != null)
                {
                    while (rdr.Read())
                    {
                        ListViewItem list = new ListViewItem();
                        list.Text = rdr["IsEmriID"].ToString();
                        list.SubItems.Add(rdr["Musteriler.Unvan"].ToString());
                        list.SubItems.Add(rdr["PersonelAd"].ToString());
                        list.SubItems.Add(rdr["Kontrol"].ToString());
                        list.SubItems.Add(rdr["Baslangic"].ToString());
                        list.SubItems.Add(rdr["Matbaa.Unvan"].ToString());
                        listView1.Items.Add(list);
                    }
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
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
        private void programcıHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }
        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SifreChange SC = new SifreChange();
            SC.Show();
        }
        private void müşteriKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriCari ms = new MusteriCari();
            ms.ShowDialog();
            GelIsEmri();
        }
        private void matbaaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatbaaCari mc = new MatbaaCari();
            mc.ShowDialog();
            GelIsEmri();
        }
        private void SiralaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                    OleDbCommand dap = new OleDbCommand("SELECT IsEmri.IsEmriID, Musteriler.Unvan, Personel.PersonelAd, IsEmri.Kontrol, IsEmri.Baslangic, Matbaa.Unvan FROM ((IsEmri INNER JOIN Matbaa ON IsEmri.MatbaaID = Matbaa.MatbaaID) INNER JOIN Musteriler ON IsEmri.MusteriID = Musteriler.MusteriID) INNER JOIN Personel ON IsEmri.PersonelID = Personel.PersonelID  where (((IsEmri.Tamamlandi)=True) and ((IsEmri.Kontrol)=@Ad))", con);
                dap.Parameters.AddWithValue("@Ad", durumcombo.Text.ToString());
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                OleDbDataReader rdr = dap.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        ListViewItem list = new ListViewItem();
                        list.Text = rdr["IsEmriID"].ToString();
                        list.SubItems.Add(rdr["Musteriler.Unvan"].ToString());
                        list.SubItems.Add(rdr["PersonelAd"].ToString());
                        list.SubItems.Add(rdr["Kontrol"].ToString());
                        list.SubItems.Add(rdr["Baslangic"].ToString());
                        list.SubItems.Add(rdr["Matbaa.Unvan"].ToString());
                        listView1.Items.Add(list);
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt Bulunamadı !!!");
                    listView1.Items.Clear();
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
        private void işTanımıKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YapilanIs yis = new YapilanIs();
            yis.ShowDialog();
            GelIsEmri();
        }
        private void durumKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kontrol kon = new Kontrol();
            kon.ShowDialog();
            GelDurumKontol();
            GelIsEmri();
        }
        private void işEmriGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsEmri ism = new IsEmri();
            ism.ShowDialog();
            GelIsEmri();
        }
        private void işEmriRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsEmriRaporlama IsERa = new IsEmriRaporlama();
            IsERa.ShowDialog();
            GelIsEmri();
        }
        private void personelKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel prs = new Personel();
            prs.ShowDialog();
            GelIsEmri();
        }
        private void VersiyonBilgiLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.gelisimsoft.com");
        }
    }
}
