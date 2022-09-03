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
    public partial class Iade : Form
    {
        public Iade()
        {
            InitializeComponent();
        }
        Baglanti adr = new Baglanti();
        private void TcTxt_TextChanged(object sender, EventArgs e) //Tcye göre alınan kitap bilgileri getirme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from AlinanKitap where tc like'" + TcTxt.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                IsimTxt.Text = read["isim"].ToString();
                SoyİsimTxt.Text = read["soyisim"].ToString();
                BarkodNoTxt.Text = read["barkodNo"].ToString();
                KitapAdiTxt.Text = read["kitapAdi"].ToString();
                yazarAdiTxt.Text = read["yazarAdi"].ToString();
                dateTimePicker1.Text = read["alimTarihi"].ToString();
            }
            
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e) //Sayfayı kapatır
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //Tcye göre alınan kitabı silme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from AlinanKitap where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", TcTxt.Text);
            komut.Parameters.AddWithValue("@isim", IsimTxt.Text);
            komut.Parameters.AddWithValue("@soyisim", SoyİsimTxt.Text);
            komut.Parameters.AddWithValue("@barkodNo", BarkodNoTxt.Text);
            komut.Parameters.AddWithValue("@kitapAdi", KitapAdiTxt.Text);
            komut.Parameters.AddWithValue("@yazarAdi", yazarAdiTxt.Text);
            komut.Parameters.AddWithValue("@alimTarihi", dateTimePicker1.Value);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kitap iade edildi!");

            TcTxt.Text = "";    //Kitap eklendikten sonra textboxları boşaltma
            IsimTxt.Text = "";
            SoyİsimTxt.Text = "";
            BarkodNoTxt.Text = "";
            KitapAdiTxt.Text = "";
            yazarAdiTxt.Text = "";
            dateTimePicker1.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

        }
    }
}
