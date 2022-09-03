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
    public partial class KitapGuncelle : Form
    {
        public KitapGuncelle()
        {
            InitializeComponent();
        }
        Baglanti adr = new Baglanti();
        private void button2_Click(object sender, EventArgs e) //sayfayı kapatır
        {
            this.Close();
        }

        private void Barkod_TextChanged(object sender, EventArgs e) //Barkod noya göre kitap bilgilerini getirme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kitap where barkodNo like '" + Barkod.Text + "'", baglanti);
            using (SqlDataReader read = komut.ExecuteReader())
            {
                while (read.Read())
                {
                    KitapAdi.Text = read["kitapAdi"].ToString();
                    Yazar.Text = read["yazarAdi"].ToString();
                    comboBox1.Text = read["tur"].ToString();
                    Yayinevi.Text = read["yayinevi"].ToString();
                    Raf.Text = read["rafNo"].ToString();
                    Aktiflik.Text = read["aktiflik"].ToString();
                }
            }
            baglanti.Close();
        }

        private void Guncelle_Click(object sender, EventArgs e)//Barkod noya göre bilgileri güncelleme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            using (SqlCommand komut = new SqlCommand("update Kitap set kitapAdi=@kitapadi,yazarAdi=@yazarAdi,tur=@tur,yayinevi=@yayinevi,rafNo=@rafNo, aktiflik=@aktiflik where barkodNo=@barkodNo", baglanti))
            {
                komut.Parameters.AddWithValue("@barkodNo", Barkod.Text);
                komut.Parameters.AddWithValue("@kitapAdi", KitapAdi.Text);
                komut.Parameters.AddWithValue("@yazarAdi", Yazar.Text);
                komut.Parameters.AddWithValue("@tur", comboBox1.Text);
                komut.Parameters.AddWithValue("@yayinevi", Yayinevi.Text);
                komut.Parameters.AddWithValue("@rafNo", Raf.Text);
                komut.Parameters.AddWithValue("@aktiflik", Aktiflik.Text);
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
            this.Close();
        }

    }
}
