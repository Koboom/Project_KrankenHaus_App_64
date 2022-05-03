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
    public partial class FormDoktorDetay : Form
    {
        public FormDoktorDetay()
        {
            InitializeComponent();
        }

        S bgl = new S();
        public string tc;
        private void FormDoktorDetay_Load(object sender, EventArgs e)
        {
            labelTCNo.Text = tc;
            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktor where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                labelAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDoktor='"+labelAdSoyad.Text+"'", bgl.baglanti());            
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBoxSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBilgiDuzenle_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDuyurular_Click(object sender, EventArgs e)
        {
            DoktorDuyurular dd = new DoktorDuyurular();
            dd.Show();
        }

        
        private void buttonBilgiDuzenle_Click_1(object sender, EventArgs e)
        {
            
            FormDoktorBilgiDuzenle dbd = new FormDoktorBilgiDuzenle();
            dbd.tc = labelTCNo.Text;
            dbd.Show();
        }

        private void richTextBoxSikayet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
