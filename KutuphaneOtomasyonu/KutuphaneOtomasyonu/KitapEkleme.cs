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
    public partial class KitapEkleme : Form
    {
        public KitapEkleme()
        {
            InitializeComponent();
        }
        Baglanti adr = new Baglanti();
        private void button2_Click(object sender, EventArgs e) //Sayfayı kapatır
        {
            this.Close();
        }

        private void Ekle_Click(object sender, EventArgs e) //Çağrılan sp ile Kitap ekleme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres); 
            baglanti.Open();
            using (SqlCommand komut = new SqlCommand("up_KitapEkle", baglanti))
            {
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("barkodNo", Barkod.Text);
                komut.Parameters.AddWithValue("kitapAdi", KitapAdi.Text);
                komut.Parameters.AddWithValue("yazarAdi", Yazar.Text);
                komut.Parameters.AddWithValue("tur", comboBox1.Text);
                komut.Parameters.AddWithValue("yayinevi", Yayinevi.Text);
                komut.Parameters.AddWithValue("rafNo", Raf.Text);
                komut.Parameters.AddWithValue("aktiflik", Aktiflik.Text);
                komut.Parameters.AddWithValue("kayitTarihi", DateTime.Now.ToShortDateString());
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
            MessageBox.Show("Kitap Kaydı Yapıldı!");

            Barkod.Text = ""; //Kitap kaydı yapıldıktan sonra textboxları boşaltma
            KitapAdi.Text = "";
            Yazar.Text = "";
            comboBox1.Text = "";
            Yayinevi.Text = "";
            Raf.Text = "";
            Aktiflik.Text = "";
        }
    }
}
