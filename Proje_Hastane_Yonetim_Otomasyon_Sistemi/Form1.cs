using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane_Yonetim_Otomasyon_Sistemi
{
    public partial class FormGirisler : Form
    {
        public FormGirisler()
        {
            InitializeComponent();
        }

        private void buttonHastaGİris_Click(object sender, EventArgs e)
        {
            HastaGiris fr = new HastaGiris();
            fr.Show();

            this.Hide();
        }

        private void buttonDoktorGiris_Click(object sender, EventArgs e)
        {
            DoktorGiris fr = new DoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void buttonSekreterGiris_Click(object sender, EventArgs e)
        {
            SekreterGiris fr = new SekreterGiris();
            fr.Show();
            this.Hide();

            
        }

        private void FormGirisler_Load(object sender, EventArgs e)
        {

        }
    }
}
