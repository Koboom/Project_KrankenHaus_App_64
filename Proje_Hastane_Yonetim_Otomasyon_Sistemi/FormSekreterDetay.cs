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
    public partial class FormSekreterDetay : Form
    {
        public FormSekreterDetay()
        {
            InitializeComponent();
        }
        public string tc;
        S bgl = new S();
        private void FormSekreterDetay_Load(object sender, EventArgs e)
        {
            labelTCNo.Text = tc;
            SqlCommand komut = new SqlCommand("Select SekreteradSoyad from Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", labelTCNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                labelAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları Datagride Aktarma

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Doktorları Datagride Aktarma

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad) as Doktorlar,DoktorBrans as Branşlar from Tbl_Doktor", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            //Branşı Comboboxa Aktarma

            SqlCommand komut2 = new SqlCommand("Select Bransad From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                comboBoxBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

           

           

        }

       

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", maskedTextBoxTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", maskedTextBoxSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", comboBoxBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", comboBoxDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            
        }

        private void comboBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komutbrans = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktor where DoktorBrans=@p1", bgl.baglanti());
            komutbrans.Parameters.AddWithValue("@p1", comboBoxBrans.Text);
            SqlDataReader drbrans = komutbrans.ExecuteReader();
            while(drbrans.Read())
            {
                comboBoxDoktor.Items.Add(drbrans[0] + " " + drbrans[1]);
            }
            bgl.baglanti().Close();
        }

        private void buttonRandevuListesi_Click(object sender, EventArgs e)
        {
            FormRandevuListesi rl = new FormRandevuListesi();
            rl.Show();
            
            
        }

        private void buttonOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", richTextBoxDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void buttonDoktorPaneli_Click(object sender, EventArgs e)
        {
            FormDoktorPaneli dp = new FormDoktorPaneli();
            dp.Show();
            
        }

        private void buttonBransPaneli_Click(object sender, EventArgs e)
        {
            FormDoktorBrans db = new FormDoktorBrans();
            db.Show();
            
        }

        private void buttonBransPaneli_Click_1(object sender, EventArgs e)
        {
            FormDoktorBrans db = new FormDoktorBrans();
            db.Show();
            
        }

        private void buttonDoktorPaneli_Click_1(object sender, EventArgs e)
        {
            FormDoktorPaneli dp = new FormDoktorPaneli();
            dp.Show();
            
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoktorDuyurular dd = new DoktorDuyurular();
            dd.Show();
        }
    }
}
