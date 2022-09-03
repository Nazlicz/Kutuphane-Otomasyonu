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
    public partial class YeniKitapEkleme : Form
    {
        public YeniKitapEkleme()
        {
            InitializeComponent();
        }
        
        Baglanti adr = new Baglanti();
        private void Ekle_Click(object sender, EventArgs e) // insert into ile database e kitap ekleme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kitap(barkodNo,kitapAdi,yazarAdi,tur,yayinevi,rafNo,aktiflik,kayitTarihi) values(@barkodNo,@kitapAdi,@yazarAdi,@tur,@yayinevi,@rafNo,@aktiflik,@kayitTarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodNo", Barkod.Text);
            komut.Parameters.AddWithValue("@kitapAdi", KitapAdi.Text);
            komut.Parameters.AddWithValue("@yazarAdi", Yazar.Text);
            komut.Parameters.AddWithValue("@tur", comboBox1.Text);
            komut.Parameters.AddWithValue("@yayinevi", Yayinevi.Text);
            komut.Parameters.AddWithValue("@rafNo", Raf.Text);
            komut.Parameters.AddWithValue("@aktiflik", Aktiflik.Text);
            komut.Parameters.AddWithValue("@kayitTarihi", DateTime.Now.ToShortDateString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kaydı Yapıldı!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //Sayfayı kapatır
        {
            this.Close();
        }
    }
}
