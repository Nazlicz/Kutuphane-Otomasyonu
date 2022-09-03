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
    public partial class PersonelPanel : Form
    {
        public PersonelPanel()
        {
            InitializeComponent();
        }

        private void UyeListeleme_Click(object sender, EventArgs e) //Üye listeleme sayfasını açar
        {
            using (UyeListeleme UyeListe = new UyeListeleme())
            {
                UyeListe.ShowDialog();
            }
        }

        private void KitapListeleme_Click_1(object sender, EventArgs e) //Kitap listeleme sayfasını açar
        {
            using (KitapListeleme KitapListe = new KitapListeleme())
            {
                KitapListe.ShowDialog();
            }
        }

        private void OduncKitap_Click(object sender, EventArgs e) //Odunç alınan kitap sayfasını açar
        {
            using (OdunAlinanKitaplar Kontrol = new OdunAlinanKitaplar())
            {
                Kontrol.ShowDialog();
            }
        }

        private void IadeKitap_Click(object sender, EventArgs e) //iade kitap sayfasını açar
        {
            using (KitapIade iade = new KitapIade())
            {
                iade.ShowDialog();
            }
        }
    }
}
