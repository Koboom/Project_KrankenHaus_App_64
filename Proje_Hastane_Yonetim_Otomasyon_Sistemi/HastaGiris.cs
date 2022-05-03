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
    public partial class HastaGiris : Form
    {
        public HastaGiris()
        {
            InitializeComponent();
        }

        S bgl = new S();

        private void linkLabelUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaUyeOl fr = new HastaUyeOl();
            
            fr.Show();
            
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * From TBL_Hastalar Where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", MskKimlikNo.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                FormHastaDetay fr = new FormHastaDetay(); 
                fr.tc = MskKimlikNo.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC ve Şifre No girildi");
            }
            bgl.baglanti().Close();



        }

        private void HastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
