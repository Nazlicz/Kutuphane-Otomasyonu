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
    public partial class PersonelIslemleri : Form
    {
        public PersonelIslemleri()
        {
            InitializeComponent();
        }

        private void PersonelGiris_Click(object sender, EventArgs e)
        {
            string KAd = PersonelID.Text;
            string KSifre = PersonelSifre.Text;

            if (KAd == "admin" && KSifre == "1234") //Personel id ve şifrenin doğru olup olmadığını kontrol etme
            {
                using (PersonelPanel PersonelIslem = new PersonelPanel())
                {
                    PersonelIslem.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(text: "Kullanıcı ad ve şifre hatalı!");
            }
        }
    }
}
