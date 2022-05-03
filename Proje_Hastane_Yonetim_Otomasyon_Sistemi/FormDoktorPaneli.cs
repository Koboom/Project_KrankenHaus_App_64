using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane_Yonetim_Otomasyon_Sistemi
{
    public partial class FormDoktorPaneli : Form
    {
        public FormDoktorPaneli()
        {
            InitializeComponent();
        }

        S bgl = new S();
        private void FormDoktorPaneli_Load(object sender, EventArgs e)
        {

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbl_Doktor", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Bransları comboboxa aktarma

            SqlCommand komut2 = new SqlCommand("select Bransad from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                comboBoxBrans.Items.Add(dr2[0]);
            }
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_Doktor (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@d1", textBoxAd.Text);
            komut1.Parameters.AddWithValue("@d2", textBoxSoyad.Text);
            komut1.Parameters.AddWithValue("@d3", comboBoxBrans.Text);
            komut1.Parameters.AddWithValue("@d4", maskedTextBoxTC.Text);
            komut1.Parameters.AddWithValue("@d5", textBoxSifre.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("işlem Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktor set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTc=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBoxBrans.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBoxTC.Text);
            komut.Parameters.AddWithValue("@p5", textBoxSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBoxBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBoxTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBoxSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Doktor where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme işlemi tamamlandı","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

      
    }
}
