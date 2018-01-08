using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GrafikMusteriTakip
{
    public partial class IsEmriRaporlama : Form
    {
        public IsEmriRaporlama()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Baglanti.BaglantiYolu);
        public static int GidenID;
        public void GelIsEmri()
        {
            listView1.Items.Clear();
            OleDbCommand dap = new OleDbCommand("SELECT IsEmri.IsEmriID, Musteriler.Unvan, YapilanIs.YapilanAd, IsEmri.Kontrol, Personel.PersonelAd, IsEmri.Baslangic, IsEmri.Bitis, Matbaa.Unvan FROM (((IsEmri INNER JOIN Musteriler ON IsEmri.MusteriID = Musteriler.MusteriID) INNER JOIN Personel ON IsEmri.PersonelID = Personel.PersonelID) INNER JOIN YapilanIs ON IsEmri.YapilanIsID = YapilanIs.YapilanIsID) INNER JOIN Matbaa ON IsEmri.MatbaaID = Matbaa.MatbaaID", con);
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
                    list.SubItems.Add(rdr["YapilanAd"].ToString());
                    list.SubItems.Add(rdr["Kontrol"].ToString());
                    list.SubItems.Add(rdr["PersonelAd"].ToString());
                    list.SubItems.Add(rdr["Baslangic"].ToString());
                    list.SubItems.Add(rdr["Bitis"].ToString());
                    list.SubItems.Add(rdr["Matbaa.Unvan"].ToString());
                    listView1.Items.Add(list);
                }
            }
            con.Close();
        }
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
        private void IsEmriRaporlama_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            GelIsEmri();
            GelYapilaKontol();
            GelYapilamusteri();
            GelYapilan();
            GelYapilaMatbaa();
            GelYapilanPersonel();
        }
        private void musteribtn_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                OleDbCommand dap = new OleDbCommand("SELECT IsEmri.IsEmriID, Musteriler.Unvan, YapilanIs.YapilanAd, IsEmri.Kontrol, Personel.PersonelAd, IsEmri.Baslangic, IsEmri.Bitis, Matbaa.Unvan FROM (((IsEmri INNER JOIN Musteriler ON IsEmri.MusteriID = Musteriler.MusteriID) INNER JOIN Personel ON IsEmri.PersonelID = Personel.PersonelID) INNER JOIN YapilanIs ON IsEmri.YapilanIsID = YapilanIs.YapilanIsID) INNER JOIN Matbaa ON IsEmri.MatbaaID = Matbaa.MatbaaID where ((IsEmri.MusteriID)=@ID)", con);
                dap.Parameters.AddWithValue("@ID", Convert.ToInt32(mustericombo.SelectedValue));
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
                        list.SubItems.Add(rdr["YapilanAd"].ToString());
                        list.SubItems.Add(rdr["Kontrol"].ToString());
                        list.SubItems.Add(rdr["PersonelAd"].ToString());
                        list.SubItems.Add(rdr["Baslangic"].ToString());
                        list.SubItems.Add(rdr["Bitis"].ToString());
                        list.SubItems.Add(rdr["Matbaa.Unvan"].ToString());
                        listView1.Items.Add(list);
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt Bulunamadı.", "Arama", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            finally
            { con.Close(); }
        }
        private void durumbtn_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                OleDbCommand dap = new OleDbCommand("SELECT IsEmri.IsEmriID, Musteriler.Unvan, YapilanIs.YapilanAd, IsEmri.Kontrol, Personel.PersonelAd, IsEmri.Baslangic, IsEmri.Bitis, Matbaa.Unvan FROM (((IsEmri INNER JOIN Musteriler ON IsEmri.MusteriID = Musteriler.MusteriID) INNER JOIN Personel ON IsEmri.PersonelID = Personel.PersonelID) INNER JOIN YapilanIs ON IsEmri.YapilanIsID = YapilanIs.YapilanIsID) INNER JOIN Matbaa ON IsEmri.MatbaaID = Matbaa.MatbaaID where ((IsEmri.Kontrol)=@ID)", con);
                dap.Parameters.AddWithValue("@ID", durumcombo.Text.ToString());
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
                        list.SubItems.Add(rdr["YapilanAd"].ToString());
                        list.SubItems.Add(rdr["Kontrol"].ToString());
                        list.SubItems.Add(rdr["PersonelAd"].ToString());
                        list.SubItems.Add(rdr["Baslangic"].ToString());
                        list.SubItems.Add(rdr["Bitis"].ToString());
                        list.SubItems.Add(rdr["Matbaa.Unvan"].ToString());
                        listView1.Items.Add(list);
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt Bulunamadı.", "Arama", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            finally
            { con.Close(); }


        }
        private void personelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                OleDbCommand dap = new OleDbCommand("SELECT IsEmri.IsEmriID, Musteriler.Unvan, YapilanIs.YapilanAd, IsEmri.Kontrol, Personel.PersonelAd, IsEmri.Baslangic, IsEmri.Bitis, Matbaa.Unvan FROM (((IsEmri INNER JOIN Musteriler ON IsEmri.MusteriID = Musteriler.MusteriID) INNER JOIN Personel ON IsEmri.PersonelID = Personel.PersonelID) INNER JOIN YapilanIs ON IsEmri.YapilanIsID = YapilanIs.YapilanIsID) INNER JOIN Matbaa ON IsEmri.MatbaaID = Matbaa.MatbaaID where ((IsEmri.PersonelID)=@ID)", con);
                dap.Parameters.AddWithValue("@ID", Convert.ToInt32(personelcombo.SelectedValue));
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
                        list.SubItems.Add(rdr["YapilanAd"].ToString());
                        list.SubItems.Add(rdr["Kontrol"].ToString());
                        list.SubItems.Add(rdr["PersonelAd"].ToString());
                        list.SubItems.Add(rdr["Baslangic"].ToString());
                        list.SubItems.Add(rdr["Bitis"].ToString());
                        list.SubItems.Add(rdr["Matbaa.Unvan"].ToString());
                        listView1.Items.Add(list);
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt Bulunamadı.", "Arama", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            finally
            { con.Close(); }
        }
        private void yapilanbtn_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                OleDbCommand dap = new OleDbCommand("SELECT IsEmri.IsEmriID, Musteriler.Unvan, YapilanIs.YapilanAd, IsEmri.Kontrol, Personel.PersonelAd, IsEmri.Baslangic, IsEmri.Bitis, Matbaa.Unvan FROM (((IsEmri INNER JOIN Musteriler ON IsEmri.MusteriID = Musteriler.MusteriID) INNER JOIN Personel ON IsEmri.PersonelID = Personel.PersonelID) INNER JOIN YapilanIs ON IsEmri.YapilanIsID = YapilanIs.YapilanIsID) INNER JOIN Matbaa ON IsEmri.MatbaaID = Matbaa.MatbaaID where ((IsEmri.YapilanIsID)=@ID)", con);
                dap.Parameters.AddWithValue("@ID", Convert.ToInt32(Yapilancombo.SelectedValue));
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
                        list.SubItems.Add(rdr["YapilanAd"].ToString());
                        list.SubItems.Add(rdr["Kontrol"].ToString());
                        list.SubItems.Add(rdr["PersonelAd"].ToString());
                        list.SubItems.Add(rdr["Baslangic"].ToString());
                        list.SubItems.Add(rdr["Bitis"].ToString());
                        list.SubItems.Add(rdr["Matbaa.Unvan"].ToString());
                        listView1.Items.Add(list);
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt Bulunamadı.", "Arama", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            finally
            { con.Close(); }
        }
        private void IsEmriRaporlama_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
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
        private void MatbaaAraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                OleDbCommand dap = new OleDbCommand("SELECT IsEmri.IsEmriID, Musteriler.Unvan, YapilanIs.YapilanAd, IsEmri.Kontrol, Personel.PersonelAd, IsEmri.Baslangic, IsEmri.Bitis, Matbaa.Unvan FROM (((IsEmri INNER JOIN Musteriler ON IsEmri.MusteriID = Musteriler.MusteriID) INNER JOIN Personel ON IsEmri.PersonelID = Personel.PersonelID) INNER JOIN YapilanIs ON IsEmri.YapilanIsID = YapilanIs.YapilanIsID) INNER JOIN Matbaa ON IsEmri.MatbaaID = Matbaa.MatbaaID where ((IsEmri.MatbaaID)=@ID)", con);
                dap.Parameters.AddWithValue("@ID", Convert.ToInt32(Matbaacombo.SelectedValue));
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
                        list.SubItems.Add(rdr["Ad"].ToString());
                        list.SubItems.Add(rdr["YapilanAd"].ToString());
                        list.SubItems.Add(rdr["Kontrol"].ToString());
                        list.SubItems.Add(rdr["PersonelAd"].ToString());
                        list.SubItems.Add(rdr["Baslangic"].ToString());
                        list.SubItems.Add(rdr["Bitis"].ToString());
                        list.SubItems.Add(rdr["Matbaa.Unvan"].ToString());
                        listView1.Items.Add(list);
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt Bulunamadı.", "Arama", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            finally
            { con.Close(); }
        }
    }
}
