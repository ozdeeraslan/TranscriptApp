using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranskriptUygulamasi.Data
{
    public class Donem
    {
        public string DonemAd { get; set; }

        public int DonemNo { get; set; }


        public List<Ders> Dersler { get; set; } = new List<Ders>(); 


        public override string ToString()
        {
            return $"{DonemNo} - {DonemAd}";
        }
    }
}
