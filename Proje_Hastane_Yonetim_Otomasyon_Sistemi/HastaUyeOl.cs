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
    public partial class HastaUyeOl : Form
    {
        public HastaUyeOl()
        {
            InitializeComponent();
        }

        S bgl = new S();

        private void HastaUyeOl_Load(object sender, EventArgs e)
        {
            
        }

        

        private void buttonKayitOl_Click(object sender, EventArgs e)
        {


            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,hastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            

            komut.Parameters.AddWithValue("@p1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskKimlikNo.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBoxTelefon.Text);
            komut.Parameters.AddWithValue("@p5", textBoxSifre.Text);
            komut.Parameters.AddWithValue("@p6", comboBoxCinsiyet.Text);
            
            komut.ExecuteNonQuery();
            

            bgl.baglanti().Close();
            MessageBox.Show("Kayıt tamamlandı Şifreniz: "+textBoxSifre.Text,"Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
