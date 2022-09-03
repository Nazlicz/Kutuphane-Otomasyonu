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
    public partial class YeniUye : Form
    {
        public YeniUye()
        {
            InitializeComponent();
        }
        Baglanti adr = new Baglanti(); //Baglantı sınıfında çağrılan değişkeni adr atama

        private void İptal_Click(object sender, EventArgs e) //Sayfayı siler
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e) //İnsert into ile üye kaydı yapma
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres); //Çağrılan sınıfa ulaşma
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Uye values(@tc,@isim,@soyisim,@yas,@cinsiyet,@telefon,@eposta,@adres)", baglanti);
            komut.Parameters.AddWithValue("@tc", TcTxt.Text);
            komut.Parameters.AddWithValue("@isim", İsimTxt.Text);
            komut.Parameters.AddWithValue("@soyisim", SoyisimTxt.Text);
            komut.Parameters.AddWithValue("@yas", YasTxt.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
            komut.Parameters.AddWithValue("@telefon", TelTxt.Text);
            komut.Parameters.AddWithValue("@eposta", EpostaTxt.Text);
            komut.Parameters.AddWithValue("@adres", AdresTxt.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Üye kaydı yapıldı!");

            TcTxt.Text = ""; //Textbox ın içini siler
            İsimTxt.Text = "";
            SoyisimTxt.Text = "";
            YasTxt.Text = "";
            comboBox1.Text = "";
            TelTxt.Text = "";
            EpostaTxt.Text = "";
            AdresTxt.Text = "";
        }

        private void YeniUye_Load(object sender, EventArgs e)
        {

        }
    }
}
