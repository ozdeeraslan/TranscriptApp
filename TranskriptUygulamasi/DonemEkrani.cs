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
    public partial class DonemEkrani : Form
    {
        // Dönemleri tutmak için statik bir liste oluşturulur
        public static List<Donem> DonemListesi = new List<Donem>();

        public DonemEkrani()
        {
            InitializeComponent();
            ListeGuncelle();
        }

        private void ListeGuncelle()
        {
            // Liste kutusu temizlenir
            lstDonemler.Items.Clear();

            // Her bir dönem listeye eklenir
            foreach (var donem in DonemListesi)
            {
                lstDonemler.Items.Add(donem);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Dönem numarası için kontrol yapılır
            if (!int.TryParse(txtDonemNo.Text, out int donemNo))
            {
                MessageBox.Show("Lütfen geçerli bir dönem numarası giriniz.");
                return;
            }


            // Yeni bir dönem oluşturulur
            Donem yeniDonem = new Donem
            {
                DonemAd = txtDonemAd.Text,
                DonemNo = Convert.ToInt32(txtDonemNo.Text)
            };

            // Dönem numarası tekrari kontrol edilir
            foreach (var donem in DonemListesi)
            {
                if (donem.DonemNo == yeniDonem.DonemNo)
                {
                    MessageBox.Show("Bu dönem numarası zaten kullanılıyor, lütfen farklı bir numara seçiniz.");
                    return;
                }
            }


            // Dönem listesine dönem eklenir
            DonemListesi.Add(yeniDonem);

            // Dönem listesine dönem eklenir
            TransKriptVeriTabani.DonemListesi.Add(yeniDonem);

            // Metin kutuları temizlenir
            txtDonemAd.Clear();
            txtDonemNo.Clear();

            // Liste kutusu yenilenir
            ListeGuncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Seçili dönem alınır
            Donem seciliDonem = (Donem)lstDonemler.SelectedItem;

            // Eğer seçili bir dönem varsa, dönem listesinden kaldırılır
            if (seciliDonem != null)
            {
                DonemListesi.Remove(seciliDonem);
                ListeGuncelle(); // Liste kutusu güncellenir
            }

            // Metin kutuları temizlenir
            txtDonemAd.Clear();
            txtDonemNo.Clear();
        }


        private void lstDonemler_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçili dönem alınır
            Donem seciliDonem = (Donem)lstDonemler.SelectedItem;

            // Eğer seçili bir dönem varsa, metin kutularına değerleri aktarılır
            if (seciliDonem != null)
            {
                txtDonemAd.Text = seciliDonem.DonemAd;
                txtDonemNo.Text = seciliDonem.DonemNo.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Seçili dönem alınır
            Donem seciliDonem = (Donem)lstDonemler.SelectedItem;

            // Eğer seçili bir dönem varsa, dönem bilgileri güncellenir
            if (seciliDonem != null)
            {
                // Yeni degerler ve Seçili dönemin bilgileri güncellenir
                seciliDonem.DonemAd = txtDonemAd.Text;
                seciliDonem.DonemNo = Convert.ToInt32(txtDonemNo.Text);

                // Metin kutuları temizlenir
                txtDonemAd.Clear();
                txtDonemNo.Clear();

                // Liste kutusu güncellenir
                ListeGuncelle();
            }
        }

    }
}

