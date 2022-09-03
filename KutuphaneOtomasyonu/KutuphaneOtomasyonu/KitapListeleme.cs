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
    public partial class KitapListeleme : Form
    {
        public KitapListeleme()
        {
            InitializeComponent();
        }
        Baglanti adr = new Baglanti();
        private void KitapListeleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneOtomasyonuDataSet1.Kitap' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitapTableAdapter.Fill(this.kütüphaneOtomasyonuDataSet1.Kitap);
            kitapListele();

        }
        DataSet data = new DataSet(); //Datagrid için dataset oluşturma
        private void kitapListele() //Datagridde kitap listeleme metodu
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

        private void Sil_Click(object sender, EventArgs e) //Barkod Noya göre kayıt silme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            using (SqlCommand komut = new SqlCommand("delete from Kitap where barkodNo=@barkodNo", baglanti))
            {
                komut.Parameters.AddWithValue("@barkodNo", dataGridView1.CurrentRow.Cells["barkodNoDataGridViewTextBoxColumn"].Value.ToString());
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi!");
            data.Tables["Kitap"].Clear();
            kitapListele();
        }
        private void button2_Click(object sender, EventArgs e) //Sayfayı kapatma
        {
            this.Close();
        }

        private void Guncelle_Click(object sender, EventArgs e) //Ayrı bir sayfa güncelleme sayfasını açar
        {
            using (KitapGuncelle Guncelle = new KitapGuncelle())
            {
                Guncelle.ShowDialog();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AramaTxt.Text = dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString();
        }

        private void AramaTxt_TextChanged(object sender, EventArgs e) //Barkod Noya göre kitap arama
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            data.Tables["Kitap"].Clear(); //Veriler üst üste binmesin diye önce datagridi temizleme
            baglanti.Open();
            using (SqlDataAdapter adap = new SqlDataAdapter("select * from Kitap where barkodNo like '%" + AramaTxt.Text + "%'", baglanti))
            {
                adap.Fill(data, "Kitap");
            }
            dataGridView1.DataSource = data.Tables["Kitap"];
            baglanti.Close();
        }

        private void Yenile_Click(object sender, EventArgs e) //Datagridi yeniler
        {
            data.Tables["Kitap"].Clear();
            kitapListele();
        }

        private void yeniKayit_Click(object sender, EventArgs e) //Ayrı bir sayfada yeni kayıt için sayfayı açar
        {
            YeniKitapEkleme Ekle = new YeniKitapEkleme();
            Ekle.ShowDialog();
        }
    }
}
