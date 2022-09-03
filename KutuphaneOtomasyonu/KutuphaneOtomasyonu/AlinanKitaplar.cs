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
    public partial class KitapIade : Form
    {
        public KitapIade()
        {
            InitializeComponent();
        }
        Baglanti adr = new Baglanti();
        DataSet data = new DataSet();
        private void KitapIade_Load(object sender, EventArgs e)
        {
            AlinanKitapListeleme();
            comboBox1.SelectedIndex = 0;
        }

        private void AlinanKitapListeleme() // Kitapları datagridde lisleme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from AlinanKitap", baglanti);
            adap.Fill(data, "AlinanKitap");
            dataGridView1.DataSource = data.Tables["AlinanKitap"];
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Tarihi geçip geçmediğine bakma
        {
            data.Tables["AlinanKitap"].Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                AlinanKitapListeleme();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                SqlConnection baglanti = new SqlConnection(adr.Adres);
                baglanti.Open();
                var adap = new SqlDataAdapter("select * from AlinanKitap where '" + DateTime.Now.ToShortDateString() + "'> iadeTarihi", baglanti);
                adap.Fill(data, "AlinanKitap");
                dataGridView1.DataSource = data.Tables["AlinanKitap"];
                baglanti.Close();
            }
            else
            {
                SqlConnection baglanti = new SqlConnection(adr.Adres);
                baglanti.Open();
                var adap = new SqlDataAdapter("select * from AlinanKitap where '" + DateTime.Now.ToShortDateString() + "'<iadeTarihi", baglanti);
                adap.Fill(data, "AlinanKitap");
                dataGridView1.DataSource = data.Tables["AlinanKitap"];
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) //Sayfayı kapatır
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//ALınan kitap kaydını silme
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from AlinanKitap where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi!");
            data.Tables["AlinanKitap"].Clear();
            uyeListele();
        }

        DataSet date = new DataSet();
        private void uyeListele() 
        {
            SqlConnection baglanti = new SqlConnection(adr.Adres);
            baglanti.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from AlinanKitap", baglanti);
            adap.Fill(data, "AlinanKitap");
            dataGridView1.DataSource = data.Tables["AlinanKitap"];
            baglanti.Close();
        }
    } 
}
