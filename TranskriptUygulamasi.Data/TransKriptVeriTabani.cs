using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranskriptUygulamasi.Data
{
    public static class TransKriptVeriTabani
    {

        // Static bir sınıf tanimla 

        public static List<Ogrenci> OgrenciListesi { get; set; } = new List<Ogrenci>();
        public static List<Ders> DersListesi { get; set; } = new List<Ders>();
        public static List<Donem> DonemListesi { get; set; } = new List<Donem>();
        public static List<Transkript> TranskriptListesi { get; set; } = new List<Transkript>();

    }
}
