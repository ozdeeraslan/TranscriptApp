using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranskriptUygulamasi.Data;

namespace TranskriptUygulamasi
{
    public partial class TranskriptFormu : Form
    {
        public Ogrenci Ogrenci { get; internal set; }
        public Ders Ders { get; internal set; }
        public Donem Donem { get; internal set; }
        public HarfNotu HarfNotu { get; internal set; }

        public TranskriptFormu(Ogrenci ogrenci, Donem donem)
        {
            InitializeComponent();
            Ogrenci = ogrenci;
            Donem = donem;
            dgvDersler.DataSource = donem.Dersler;
            lblDonemAd.Text = donem.DonemNo + " " + donem.DonemAd;
            lblGenelOrtalama.Text = HesaplaGenelOrtalama().ToString();
            lblDonemOrt.Text = HesaplaDönemOrtalamasi().ToString();
        }





        public double HesaplaDönemOrtalamasi()
        {
            double Dno = 0;
            foreach (var donemDersi in Donem.Dersler)
                Dno += HesaplaKrediHarfKatsayisi(donemDersi.Kredi, donemDersi.HarfNotu);

            Dno /= Donem.Dersler.Sum(d => d.Kredi);
            return Dno;

        }
        public double HesaplaGenelOrtalama()
        {
            double Gno = 0, toplamKredi = 0;


            foreach (var donem in Ogrenci.Donemler)
            {
                foreach (var donemDersi in donem.Dersler)
                {
                    Gno += HesaplaKrediHarfKatsayisi(donemDersi.Kredi, donemDersi.HarfNotu);
                    toplamKredi += donemDersi.Kredi;
                }
            }

            Gno /= toplamKredi;

            return Gno;
        }



        public double HesaplaKrediHarfKatsayisi(int kredi, HarfNotu harfNotu)
        {
            double katsayi = 0.0;
            // Harf notuna göre katsayıyı belirle
            switch (harfNotu)
            {
                case HarfNotu.AA:
                    katsayi = 4.0;
                    break;
                case HarfNotu.BA:
                    katsayi = 3.5;
                    break;
                case HarfNotu.BB:
                    katsayi = 3.0;
                    break;
                case HarfNotu.CB:
                    katsayi = 2.5;
                    break;
                case HarfNotu.CC:
                    katsayi = 2.0;
                    break;
                case HarfNotu.DC:
                    katsayi = 1.5;
                    break;
                case HarfNotu.DD:
                    katsayi = 1.0;
                    break;
                case HarfNotu.FF:
                    katsayi = 0.0;
                    break;
                default:
                    break;
            }
            // Kredi sayısı ile katsayıyı çarp
            return kredi * katsayi;
        }

        public TranskriptFormu()
        {
            InitializeComponent();
            //DersListesi = new List<Ders>(); // DersListesi'ni başlatın
            //HesaplaDönemOrtalamasi();
        }
    }
}
