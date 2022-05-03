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
    public partial class FormDoktorBilgiDuzenle : Form
    {
        public FormDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tc;
        S bgl = new S();
        private void FormDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskKimlikNo.Text = tc;

            SqlCommand komut = new SqlCommand("Select * from Tbl_Doktor where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskKimlikNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                textBoxAd.Text = dr[1].ToString();
                textBoxSoyad.Text = dr[2].ToString();
                comboBoxBrans.Text = dr[3].ToString();
                textBoxSifre.Text = dr[4].ToString();
            }
            bgl.baglanti().Close();
            
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Doktor set doktorad=@p1,doktorsoyad=@p2,doktorbrans=@p3,doktorsifre=@p4 where doktorTc=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBoxBrans.Text);
            komut.Parameters.AddWithValue("@p4", textBoxSifre.Text);
            komut.Parameters.AddWithValue("@p5", MskKimlikNo.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Hesabınız Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.baglanti().Close();
        }
    }
}
