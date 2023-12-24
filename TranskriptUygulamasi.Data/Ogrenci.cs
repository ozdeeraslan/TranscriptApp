using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranskriptUygulamasi.Data
{
    public class Ogrenci
    {
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }
        public string Numara { get; set; }


        public List<Donem> Donemler { get; set; } = new List<Donem>();

        public override string ToString()
        {
            return $"{Numara} - {OgrenciAd} {OgrenciSoyad}"; 
        }

    }
}
