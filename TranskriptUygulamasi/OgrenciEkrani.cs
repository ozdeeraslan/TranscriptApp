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
    public partial class OgrenciEkrani : Form
    {
        // Öğrencileri tutmak için statik bir liste oluşturulur
        public static List<Ogrenci> OgrenciListesi = new List<Ogrenci>();

        
        public OgrenciEkrani()
        {
            InitializeComponent();
            ListeGuncelle();

        }

        private void ListeGuncelle()
        {
            // Liste kutusu temizlenir
            lstOgrenciler.Items.Clear();

            // Her bir öğrenci listeye eklenir
            foreach (var ogrenci in OgrenciListesi)
            {
                lstOgrenciler.Items.Add(ogrenci);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Öğrenci adı ve soyadı için kontrol
            if (txtOgrenciAd.Text.Any(char.IsDigit) || txtOgrenciAd.Text.Any(char.IsWhiteSpace) ||
                txtOgrenciSoyad.Text.Any(char.IsDigit) || txtOgrenciSoyad.Text.Any(char.IsWhiteSpace))
            {
                MessageBox.Show("Öğrenci adı ve soyadı yalnızca harf içermelidir.");
                return;
            }

            // Öğrenci numarası için kontrol
            if (txtNumara.Text.Any(char.IsWhiteSpace) || (txtNumara.Text.Any(char.IsLetter)))
            {
                MessageBox.Show("Öğrenci numarası yalnızca rakam içermelidir.");
                return;
            }

            // Öğrenci numarası tekrar kontrolü
            foreach (var ogrenci in OgrenciListesi)
            {
                if (ogrenci.Numara == txtNumara.Text)
                {
                    MessageBox.Show("Bu numara zaten kullanılıyor, lütfen farklı bir numara seçiniz.");
                    return;
                }
            }

            // Yeni bir öğrenci oluşturulur
            Ogrenci yeniOgrenci = new Ogrenci
            {
                OgrenciAd = txtOgrenciAd.Text,
                OgrenciSoyad = txtOgrenciSoyad.Text,
                Numara = txtNumara.Text
            };

            // Öğrenci listesine öğrenci eklenir
            OgrenciListesi.Add(yeniOgrenci);

            // Veritabanı sınıfına öğrenci eklenir
            TransKriptVeriTabani.OgrenciListesi.Add(yeniOgrenci);

            // Metin kutuları temizlenir
            txtOgrenciAd.Clear();
            txtOgrenciSoyad.Clear();
            txtNumara.Clear();

            // Liste kutusu yenilenir
            ListeGuncelle();

            

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Seçili öğrenci alınır
            Ogrenci seciliOgrenci = (Ogrenci)lstOgrenciler.SelectedItem;

            // Eğer seçili bir öğrenci varsa, öğrenci listesinden kaldırılır
            if (seciliOgrenci != null)
            {
                OgrenciListesi.Remove(seciliOgrenci);
                ListeGuncelle(); // Liste kutusu güncellenir
            }

            // Metin kutuları temizlenir
            txtOgrenciAd.Clear();
            txtOgrenciSoyad.Clear();
            txtNumara.Clear();
        }


        private void lstOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçili öğrenci alınır
            Ogrenci seciliOgrenci = (Ogrenci)lstOgrenciler.SelectedItem;

            // Eğer seçili bir öğrenci varsa, metin kutularına değerleri aktarılır
            if (seciliOgrenci != null)
            {
                txtOgrenciAd.Text = seciliOgrenci.OgrenciAd;
                txtOgrenciSoyad.Text = seciliOgrenci.OgrenciSoyad;
                txtNumara.Text = seciliOgrenci.Numara;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Seçili öğrenci alınır
            Ogrenci seciliOgrenci = (Ogrenci)lstOgrenciler.SelectedItem;

            // Eğer seçili bir öğrenci varsa, öğrenci bilgileri güncellenir
            if (seciliOgrenci != null)
            {
                // Yeni değerler alınır ve Seçili öğrencinin bilgileri güncellenir
                seciliOgrenci.OgrenciAd = txtOgrenciAd.Text;
                seciliOgrenci.OgrenciSoyad = txtOgrenciSoyad.Text;
                seciliOgrenci.Numara = txtNumara.Text;

                // Metin kutuları temizlenir
                txtOgrenciAd.Clear();
                txtOgrenciSoyad.Clear();
                txtNumara.Clear();

                // Liste kutusu güncellenir
                ListeGuncelle();
            }
        }

    }
}
