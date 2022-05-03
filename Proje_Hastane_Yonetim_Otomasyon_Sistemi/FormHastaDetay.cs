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
    public partial class FormHastaDetay : Form
    {
        public FormHastaDetay()
        {
            InitializeComponent();
        }

        S bgl = new S();

        public string tc;

        private void FormHastaDetay_Load(object sender, EventArgs e)
        {

            labelTCNo.Text = tc;


            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", labelTCNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                labelAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_randevular where Randevudurum=1", bgl.baglanti());
            da.Fill(dt);
            dataGridViewRanGenmis.DataSource = dt;
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                comboBoxBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

           
        }

        private void comboBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktor where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", comboBoxBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())
            {
                comboBoxDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void comboBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuBrans='" + comboBoxBrans.Text + "'"+"and RandevuDoktor='"+comboBoxDoktor.Text+"'and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridViewAktifRandevular.DataSource = dt;
        }

        private void linkLabelBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBilgiDuzenle fr = new FormBilgiDuzenle();
            fr.tcno = labelTCNo.Text;
            fr.Show();
        }

        private void dataGridViewAktifRandevular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", labelTCNo.Text);
            komut.Parameters.AddWithValue("@p2", richTextBoxSikayet.Text);
            komut.Parameters.AddWithValue("@p3", textBoxid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridViewAktifRandevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewAktifRandevular.SelectedCells[0].RowIndex;
            textBoxid.Text = dataGridViewAktifRandevular.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
