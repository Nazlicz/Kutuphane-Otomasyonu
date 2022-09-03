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
    public partial class OdunAlinanKitaplar : Form
    {
        public OdunAlinanKitaplar()
        {
            InitializeComponent();
        }
        Baglanti adr = new Baglanti();
        private void OdunAlinanKitaplar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneOtomasyonuDataSet5.AlinanKitap' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.alinanKitapTableAdapter.Fill(this.kütüphaneOtomasyonuDataSet5.AlinanKitap);
            Listele();

        }

        DataSet data = new DataSet(); //Datagrid için dataset oluşturma

        private void Listele() //Çağrılan sp ile kitapları listeleme metdu
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            using (SqlDataAdapter adap = new SqlDataAdapter("up_KitapListeleme", baglanti))
            {
                adap.Fill(data, "AlinanKitap");
            }
            dataGridView1.DataSource = data.Tables["AlinanKitap"];
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //tcye göre alınan kitaba bakma
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            data.Tables["AlinanKitap"].Clear(); //Veriler üst üste binmesin diye önce datagridi temizleme
            baglanti.Open();
            using (SqlDataAdapter adap = new SqlDataAdapter("select * from AlinanKitap where tc like '%" + textBox1.Text + "%'", baglanti))
            {
                adap.Fill(data, "AlinanKitap");
            }
            dataGridView1.DataSource = data.Tables["AlinanKitap"];
            baglanti.Close();

        }

        private void button5_Click(object sender, EventArgs e) //Ayrı sayfada açar
        {
            this.Close();
        }

        private void yenile_Click(object sender, EventArgs e) //Datagrid i yeniler
        {
            data.Tables["AlinanKitap"].Clear(); //Veriler üst üste binmesin diye önce datagridi temizleme
            Listele();
        }

        private void Sil_Click(object sender, EventArgs e) //tcye göre kayıt silme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            using (SqlCommand komut = new SqlCommand("delete from AlinanKitap where tc=@tc", baglanti))
            {
                komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tcDataGridViewTextBoxColumn"].Value.ToString());
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
            MessageBox.Show("Kitap Silindi!");
            data.Tables["AlinanKitap"].Clear(); //Veriler üst üste binmesin diye önce datagridi temizleme
            Listele();
        }

        private void Guncelle_Click(object sender, EventArgs e) //Ayrı bir sayfada güncelleme sayfasını açar
        {
            using (GuncelleOdunc odunc = new GuncelleOdunc())
            {
                odunc.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e) //Ayrı bir sayfada ödünç sayfasını açar
        {
            using (OduncVer odunc = new OduncVer())
            {
                odunc.ShowDialog();
            }
        }
    }
}
