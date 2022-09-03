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
    public partial class YeniKayit : Form
    {
        public YeniKayit()
        {
            InitializeComponent();
        }
        Baglanti adr = new Baglanti();
        private void button1_Click(object sender, EventArgs e) //Çağrılan sp ile database e üye ekleme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("up_Ekle", baglanti);
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

            MessageBox.Show("Üye kaydı yapıldı!");
            this.Close();


        }

        private void İptal_Click(object sender, EventArgs e) //Sayfayı kapatır
        {
            this.Close();
        }
    }
}
