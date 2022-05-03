using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane_Yonetim_Otomasyon_Sistemi
{
    class S
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=KOBOOM\\SQLEXPRESS;Initial Catalog=HastaneProjeYeni;Integrated Security=True");
            baglan.Open();

            return baglan;
        }
    }
}
