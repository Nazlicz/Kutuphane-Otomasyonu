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
    public partial class GuncelleOdunc : Form
    {
        public GuncelleOdunc()
        {
            InitializeComponent();
        }
        Baglanti adr = new Baglanti();
        private void OduncAl_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres); //Tcye göre bilgileri güncelleme
            baglanti.Open();
            using (SqlCommand komut = new SqlCommand("update AlinanKitap set  isim=@isim, soyisim=@soyisim, barkodNo=@barkodNo,kitapAdi=@kitapAdi, yazarAdi=@yazarAdi, alimTarihi=@alimTarihi, iadeTarihi=@iadeTarihi where tc=@tc", baglanti))
            {
                komut.Parameters.AddWithValue("@tc", TcTxt.Text);
                komut.Parameters.AddWithValue("@isim", IsimTxt.Text);
                komut.Parameters.AddWithValue("@soyisim", SoyisimTxt.Text);
                komut.Parameters.AddWithValue("@barkodNo", BarkodTxt.Text);
                komut.Parameters.AddWithValue("@kitapAdi", KitapTxt.Text);
                komut.Parameters.AddWithValue("@yazarAdi", YazarTxt.Text);
                komut.Parameters.AddWithValue("@alimTarihi", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@iadeTarihi", dateTimePicker2.Value);
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
            MessageBox.Show("İşleminiz Güncellendi");
            this.Close();
        }

        private void Iptal_Click(object sender, EventArgs e) //Sayfayı kapatır
        {
            this.Close();
        }

        private void TcTxt_TextChanged(object sender, EventArgs e) //Tcye göre isim soyisim getirme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            using (SqlCommand komut = new SqlCommand("Select * from uye where tc like'" + TcTxt.Text + "'", baglanti))
            {
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    IsimTxt.Text = read["isim"].ToString();
                    SoyisimTxt.Text = read["soyisim"].ToString();
                }
            }

            baglanti.Close();
        }

        private void BarkodTxt_TextChanged(object sender, EventArgs e) //Barkod Noya göre kitap adı ve yazar adı getirme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            using (SqlCommand komut = new SqlCommand("Select * from AlinanKitap where barkodNo like '" + BarkodTxt.Text + "'", baglanti))
            {
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    KitapTxt.Text = read["kitapAdi"].ToString();
                    YazarTxt.Text = read["yazarAdi"].ToString();

                }
            }

            baglanti.Close();
        }
    }
}
