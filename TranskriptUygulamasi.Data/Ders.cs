using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranskriptUygulamasi.Data
{
    public class Ders
    {
        public string Kod { get; set; }

        public string DersAd { get; set; }

        public int Kredi { get; set; }

        public HarfNotu HarfNotu { get; set; }

        public override string ToString()
        {
            return $"{Kod} - {DersAd} ({Kredi} Kredi)";
        }
    }
}
