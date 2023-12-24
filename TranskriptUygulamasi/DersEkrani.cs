using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TranskriptUygulamasi.Data;

namespace TranskriptUygulamasi
{
    public partial class DersEkrani : Form
    {
        // Dersleri tutmak için statik bir liste oluşturulur
        public static List<Ders> DersListesi = new List<Ders>();


        public DersEkrani()
        {
            InitializeComponent();
            ListeGuncelle();
        }

        private void ListeGuncelle()
        {
            // Liste kutusu temizlenir
            lstDersler.Items.Clear();

            // Her bir ders listeye eklenir
            foreach (var ders in DersListesi)
            {
                lstDersler.Items.Add(ders);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Ders adı için kontrol yapılır
            if (txtDersAdi.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Lütfen geçerli bir ders adı giriniz.");
                return;
            }

            // Ders kodu için kontrol yapılır
            if (txtDersKodu.Text.Any(char.IsWhiteSpace))
            {
                MessageBox.Show("Lütfen geçerli bir ders kodu giriniz.");
                return;
            }

            if (txtDersKredisi.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Kredi sayisi rakam olarak girilmelidir.");
                return;
            }

            // Metin kutularından değerler alınır ve Yeni bir ders oluşturulur
            Ders yeniDers = new Ders
            {
                Kod = txtDersKodu.Text,
                DersAd = txtDersAdi.Text,
                Kredi = Convert.ToInt32(txtDersKredisi.Text)
            };

            // Ders kodu tekrari icin kontrol edilir
            foreach (var ders in DersListesi)
            {
                if (ders.Kod == yeniDers.Kod)
                {
                    MessageBox.Show("Bu ders kodu zaten kullanılıyor, lütfen farklı bir kod seçiniz.");
                    return;
                }
            }

            // Ders listesine ders eklenir
            DersListesi.Add(yeniDers);

            // Ders listesine ders eklenir
            TransKriptVeriTabani.DersListesi.Add(yeniDers);

            // Metin kutuları temizlenir
            txtDersKodu.Clear();
            txtDersAdi.Clear();
            txtDersKredisi.Clear();

            // Liste kutusu yenilenir
            ListeGuncelle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Seçili dersi alın
            Ders seciliDers = (Ders)lstDersler.SelectedItem;

            // Eğer seçili bir ders varsa, ders listesinden kaldırılır
            if (seciliDers != null)
            {
                DersListesi.Remove(seciliDers);
                ListeGuncelle(); // Liste kutusu güncellenir
            }

            // Metin kutuları temizlenir
            txtDersAdi.Clear();
            txtDersKredisi.Clear();
            txtDersKodu.Clear();
        }

        private void lstDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçili dönem alınır
            Ders seciliDers = (Ders)lstDersler.SelectedItem;

            // Eğer seçili bir dönem varsa, metin kutularına değerleri aktarılır
            if (seciliDers != null)
            {
                txtDersKodu.Text = seciliDers.Kod;
                txtDersAdi.Text = seciliDers.DersAd;
                txtDersKredisi.Text = seciliDers.Kredi.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Seçili ders alınır
            Ders seciliDers = (Ders)lstDersler.SelectedItem;

            // Eğer seçili bir ders varsa, ders bilgileri güncellenir
            if (seciliDers != null)
            {
                // Yeni değerler alınır ve Seçili dersin bilgileri güncellenir
                seciliDers.Kod = txtDersKodu.Text;
                seciliDers.DersAd = txtDersAdi.Text;
                seciliDers.Kredi = Convert.ToInt32(txtDersKredisi.Text);

                // Metin kutuları temizlenir
                txtDersKodu.Clear();
                txtDersAdi.Clear();
                txtDersKredisi.Clear();

                // Liste kutusu güncellenir
                ListeGuncelle();
            }
        }

    }
}
