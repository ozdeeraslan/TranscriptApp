using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranskriptUygulamasi.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TranskriptUygulamasi
{
    public partial class DersEklemeEkrani : Form
    {
        public static List<Ogrenci> OgrenciListesi = new List<Ogrenci>();
        public static List<Ders> DersListesi = new List<Ders>();
        public static List<Donem> DonemListesi = new List<Donem>();
        public static List<TranskriptFormu> TranskriptListesi = new List<TranskriptFormu>();

        public static List<string> dersKodlari = new List<string>();
        public static List<string> dersAdlari = new List<string>();
        public static List<string> krediSayilari = new List<string>();
        public static List<string> harfNotlari = new List<string>();


        public DersEklemeEkrani()
        {
            InitializeComponent();

            // Öğrenci listesini almak için TransKriptVeriTabani'ndan veri alın
            foreach (var ogrenci in TransKriptVeriTabani.OgrenciListesi)
            {
                cmbOgrenci.Items.Add(ogrenci);
            }

            // Dönem listesini almak için TransKriptVeriTabani'ndan veri alın
            foreach (var donem in TransKriptVeriTabani.DonemListesi)
            {
                cmbDonem.Items.Add(donem);
            }

            // Ders listesini almak için TransKriptVeriTabani'ndan veri alın
            foreach (var ders in TransKriptVeriTabani.DersListesi)
            {
                cmbDers.Items.Add(ders);
            }

            // Harf notu enum'u combobox'a eklenir
            foreach (HarfNotu harfNotu in Enum.GetValues(typeof(HarfNotu)))
            {
                cmbHarfNotu.Items.Add(harfNotu);
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            //öğrencinin seçili dönemine dersi seçilen harf notu ile ata.

            Ogrenci seciliOgrenci = (Ogrenci)cmbOgrenci.SelectedItem;
            Ders seciliDers = (Ders)cmbDers.SelectedItem;
            HarfNotu seciliHarfNotu = (HarfNotu)cmbHarfNotu.SelectedItem;
            Donem seciliDonem = (Donem)cmbDonem.SelectedItem;
            Ders ders = new Ders()
            {
                DersAd = seciliDers.DersAd,
                Kredi = seciliDers.Kredi,
                HarfNotu = seciliHarfNotu,
                Kod = seciliDers.Kod
            };

            if (!seciliOgrenci.Donemler.Contains(seciliDonem))
                seciliOgrenci.Donemler.Add(seciliDonem);

            seciliOgrenci.Donemler.FirstOrDefault(d => d.DonemNo == seciliDonem.DonemNo).Dersler.Add(ders);

        }

        private void btnTranskriptGoster_Click(object sender, EventArgs e)
        {
            // Yeni bir Transkript formu oluştur
            TranskriptFormu transkriptFormu = new TranskriptFormu((Ogrenci)cmbOgrenci.SelectedItem, (Donem)cmbDonem.SelectedItem);

            // Formu göster
            transkriptFormu.Show();

        }
    }
}


