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
    public partial class FormRandevuListesi : Form
    {
        public FormRandevuListesi()
        {
            InitializeComponent();
        }

        S bgl = new S();
        private void FormRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular", bgl.baglanti());
            
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        public int secilen;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;

        }
    }
}
