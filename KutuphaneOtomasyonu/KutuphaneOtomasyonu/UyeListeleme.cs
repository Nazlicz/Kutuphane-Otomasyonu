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
    public partial class UyeListeleme : Form
    {
        public UyeListeleme()
        {
            InitializeComponent();
        }

        private void UyeListeleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneOtomasyonuDataSet.Uye' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uyeTableAdapter.Fill(this.kütüphaneOtomasyonuDataSet.Uye);
            uyeListele();

        }

        private void İptal_Click(object sender, EventArgs e) //Sayfayı kapatır
        {
            this.Close();
        }
        Baglanti adr = new Baglanti();

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) 
        {
            AramaTxt.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }

        DataSet data = new DataSet();
        private void AramaTxt_TextChanged(object sender, EventArgs e) // textbox a yazılan sayıyla veritabanından tc'ye göre kayıt arama
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            data.Tables["Uye"].Clear(); //Veriler üst üste binmesin diye önce datagridi temizleme
            baglanti.Open();
            var adap = new SqlDataAdapter("select * from uye where tc like '%" + AramaTxt.Text + "%'", baglanti);
            adap.Fill(data, "Uye");
            DataTable dataTable = data.Tables["Uye"];
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
        }

        private void Sil_Click(object sender, EventArgs e) // Çağrılan sp ile üyeleri silme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("up_Sil", baglanti);
            komut.Parameters.AddWithValue("tc", dataGridView1.CurrentRow.Cells["tcDataGridViewTextBoxColumn"].Value.ToString());
            komut.CommandType = CommandType.StoredProcedure;
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi!");
            data.Tables["Uye"].Clear(); //Veriler üst üste binmesin diye önce datagridi temizleme
            uyeListele();
        }

        private void uyeListele()
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            SqlDataAdapter adap = new SqlDataAdapter("up_Listeleme", baglanti);
            adap.Fill(data, "Uye");
            dataGridView1.DataSource = data.Tables["Uye"];
            baglanti.Close();
        }

        private void Guncelle_Click(object sender, EventArgs e) //Güncelleme sekmesini açar
        {
            using (GüncellemeSekmesi Sekme = new GüncellemeSekmesi())
            {
                Sekme.ShowDialog();
            }

        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            NewMethod();
            uyeListele();
        }
         
        private void NewMethod() //Veriler üst üste binmesin diye önce datagridi temizleme
        {
            data.Tables["Uye"].Clear();
        }

        private void YeniKayit_Click(object sender, EventArgs e) //Kayıt sayfasını açar
        {
            using (var kayit = new YeniKayit())
            {
                kayit.ShowDialog();
            }
        }
    }
}
