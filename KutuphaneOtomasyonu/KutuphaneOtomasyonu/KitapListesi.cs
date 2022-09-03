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
    public partial class KitapListesi : Form
    {
        public KitapListesi()
        {
            InitializeComponent();
        }
        Baglanti adr = new Baglanti();
        private void KitapListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneOtomasyonuDataSet3.Kitap' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitapTableAdapter.Fill(this.kütüphaneOtomasyonuDataSet3.Kitap);
            kitapListele();

        }
        DataSet data = new DataSet();
        private void kitapListele() //Kitaplaarı datagridde listeleme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            using (SqlDataAdapter adap = new SqlDataAdapter("select * from Kitap", baglanti))
            {
                adap.Fill(data, "Kitap");
            }
            dataGridView1.DataSource = data.Tables["Kitap"];
            baglanti.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //textbox a yazılana göre kitap ismi sorgulama
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            data.Tables["Kitap"].Clear(); //Veriler üst üste binmesin diye önce datagridi temizleme
            baglanti.Open();
            using (SqlDataAdapter adap = new SqlDataAdapter("select * from Kitap where kitapAdi like '%" + textBox1.Text + "%'", baglanti))
            {
                adap.Fill(data, "Kitap");
            }
            dataGridView1.DataSource = data.Tables["Kitap"];
            baglanti.Close();
        }
    }
}
