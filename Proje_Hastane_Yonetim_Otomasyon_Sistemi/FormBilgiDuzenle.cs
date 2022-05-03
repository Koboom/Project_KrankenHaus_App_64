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
    public partial class FormBilgiDuzenle : Form
    {
        public FormBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string tcno;
        S bgl = new S();
        private void FormBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskKimlikNo.Text = tcno;//1-burası hastaüyeol kısmından formlararası çekildi.
            SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            //2-hastaTc anakural olmak kaydıyla Tbl_Hastalar dan hepsini işleme alıyoruz.
            komut.Parameters.AddWithValue("@p1", MskKimlikNo.Text);//3-mskkimlikno dan gelen bilgi @p1 olmak kaydıyla
            SqlDataReader dr = komut.ExecuteReader();//4- sqlcommand larda kullanılan ana data okuyucuyu çalıştırıyoruz.
            while(dr.Read())//5- dr okuduğu müddetce;
            {
                textBoxAd.Text = dr[1].ToString();//6- dr 1. sütundaki değeri buraya yaz ama TC kimlik nosu aynı olmak kaydıyla
                textBoxSoyad.Text = dr[2].ToString();//7- dr 2. sütundaki değeri buraya yaz Tc kimlik nosu aynı olmak kaydıyla
                maskedTextBoxTelefon.Text = dr[4].ToString();//8- dr 4. sütun. çünkü 3. sütunda tc no var ve zaten otomatik yazılıyor.
                textBoxSifre.Text = dr[5].ToString();
                comboBoxCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",textBoxAd.Text);
            komut2.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", maskedTextBoxTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", textBoxSifre.Text);
            komut2.Parameters.AddWithValue("@p5", comboBoxCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", MskKimlikNo.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Bilgileriniz GÜncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
