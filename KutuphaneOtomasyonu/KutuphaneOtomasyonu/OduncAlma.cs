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
    public partial class OduncAlma : Form
    {
        public OduncAlma()
        {
            InitializeComponent();
        }
        Baglanti adr = new Baglanti();
        private void Iptal_Click(object sender, EventArgs e) //Sayfayı kapatır
        {
            this.Close();
        }
        DataSet data = new DataSet();


        private void OduncAlma_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneOtomasyonuDataSet2.Kutuphane' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kutuphaneTableAdapter.Fill(this.kütüphaneOtomasyonuDataSet2.Kutuphane);
        }

        private void TcTxt_TextChanged(object sender, EventArgs e) // tc numarasına göre kişinin bazı bilgilerini getirme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from uye where tc like'"+TcTxt.Text+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                IsimTxt.Text = read["isim"].ToString();
                SoyisimTxt.Text = read["soyisim"].ToString();
            }

            baglanti.Close();
        }

        private void BarkodTxt_TextChanged(object sender, EventArgs e) //Barkod numarasına göre kitabın bazı bilgilerini getirme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from kitap where barkodNo like '" + BarkodTxt.Text + "'", baglanti);
            using (SqlDataReader read = komut.ExecuteReader())
            {
                while (read.Read())
                {
                    KitapTxt.Text = read["kitapAdi"].ToString();
                    YazarTxt.Text = read["yazarAdi"].ToString();

                }
            }

            baglanti.Close();
        }

        private void OduncAl_Click(object sender, EventArgs e)//Ödünç alınan kitabı tabloya girme
        {
            if ((TcTxt.Text != "") && (BarkodTxt.Text != ""))
            {
                SqlConnection baglanti = new SqlConnection(adr.Adres);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into AlinanKitap(tc,isim,soyisim,barkodNo,kitapAdi,yazarAdi, alimTarihi,iadeTarihi) values (@tc,@isim,@soyisim,@barkodNo,@kitapAdi,@yazarAdi,@alimTarihi,@iadeTarihi)", baglanti);
                komut.Parameters.AddWithValue("@tc", TcTxt.Text);
                komut.Parameters.AddWithValue("@isim", IsimTxt.Text);
                komut.Parameters.AddWithValue("@soyisim", SoyisimTxt.Text);
                komut.Parameters.AddWithValue("@barkodNo", BarkodTxt.Text);
                komut.Parameters.AddWithValue("@kitapAdi", KitapTxt.Text);
                komut.Parameters.AddWithValue("@yazarAdi", YazarTxt.Text);
                komut.Parameters.AddWithValue("@alimTarihi", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@iadeTarihi", dateTimePicker2.Value);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kitap Ödünç Alındı!");

                TcTxt.Text = ""; //Textbox ın içini boşaltma
                IsimTxt.Text = "";
                SoyisimTxt.Text = "";
                BarkodTxt.Text = "";
                KitapTxt.Text = "";
                YazarTxt.Text = "";
                dateTimePicker1.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                dateTimePicker2.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            }
            else
            {
                MessageBox.Show("Eksik ya da Hatalı Giriş Girdiniz. \nLütfen bilgileri kontrol ederek tekrar giriniz!");
            }
        }

        private void button1_Click(object sender, EventArgs e) //Ayrı bir sekmede kitapları görüntüler
        {
            using (KitapListesi liste = new KitapListesi())
            {
                liste.ShowDialog();
            }
        }




    }
}
