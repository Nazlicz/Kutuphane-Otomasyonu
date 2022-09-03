using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void PersonelButton_Click(object sender, EventArgs e) //Ayrı bir sayfada Personel işlemlerine gider
        {
            using (PersonelIslemleri Personel = new PersonelIslemleri())
            {
                Personel.ShowDialog();
            }
        }

        private void UyeButton_Click(object sender, EventArgs e) //Ayrı bir sayfada üye ekleme sayfasını açar
        {
            using (YeniUye UyeEkleme = new YeniUye())
            {
                UyeEkleme.ShowDialog();
            }
        }

        private void KitapEkleme_Click(object sender, EventArgs e) //Ayrı bir sayfa kitapekleme sayfasını açar
        {
            using (KitapEkleme ekleme = new KitapEkleme())
            {
                ekleme.ShowDialog();
            }
        }

        private void OduncAlma_Click(object sender, EventArgs e) // Ayrı bir sayfada ödünç alma sayfasını açar
        {
            using (OduncAlma odunc = new OduncAlma())
            {
                odunc.ShowDialog();
            }
        }

        private void iade_Click(object sender, EventArgs e) //Ayrı bir sayfada iade sayfasını açar
        {
            Iade iadeSayfa = new Iade();
            iadeSayfa.ShowDialog();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
