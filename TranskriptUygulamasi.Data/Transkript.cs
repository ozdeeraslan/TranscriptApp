using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranskriptUygulamasi.Data
{
    public class Transkript
    {
        public Ogrenci Ogrenci { get;  set; }

        public Donem Donem { get; set; }

    

        public HarfNotu HarfNotu { get; set; }

        //public override string ToString()
        //{
        //    return $"{Ogrenci.Numara} - {Ogrenci.OgrenciAd} {Ogrenci.OgrenciSoyad} - {Donem.DonemNo}.Dönem, {Donem.DonemAd} Dönemi, {Ders.DersAd} - {Ders.Kod} - {Ders.Kredi} Kredi - Harf Notu: {HarfNotu}";
        //}
    }
}
