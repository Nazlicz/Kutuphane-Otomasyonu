using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class GüncellemeSekmesi : Form
    {
        public GüncellemeSekmesi()
        {
            InitializeComponent();
        }
        Baglanti adr = new Baglanti();
        private void İptal_Click(object sender, EventArgs e) //Sayfayı kapatır
        {
            this.Close();
        }

        private void TcTxt_TextChanged(object sender, EventArgs e) //Tcye göre bilgileri getirme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            using (SqlCommand komut = new SqlCommand("select * from uye where tc like '" + TcTxt.Text + "'", baglanti))
            {
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    İsimTxt.Text = read["isim"].ToString();
                    SoyisimTxt.Text = read["soyisim"].ToString();
                    YasTxt.Text = read["yas"].ToString();
                    comboBox1.Text = read["cinsiyet"].ToString();
                    TelTxt.Text = read["telefon"].ToString();
                    EpostaTxt.Text = read["eposta"].ToString();
                    AdresTxt.Text = read["adres"].ToString();
                }
            }
            baglanti.Close();
        }
        private void Guncelle_Click(object sender, EventArgs e) //Tcye göre bilgileri güncelleme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres); 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("up_Guncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("tc", TcTxt.Text);
            komut.Parameters.AddWithValue("isim", İsimTxt.Text);
            komut.Parameters.AddWithValue("soyisim", SoyisimTxt.Text);
            komut.Parameters.AddWithValue("yas", YasTxt.Text);
            komut.Parameters.AddWithValue("cinsiyet", comboBox1.Text);
            komut.Parameters.AddWithValue("telefon", TelTxt.Text);
            komut.Parameters.AddWithValue("eposta", EpostaTxt.Text);
            komut.Parameters.AddWithValue("adres", AdresTxt.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.Close();
        }

        private void GüncellemeSekmesi_Load(object sender, EventArgs e)
        {

        }
    }

}

