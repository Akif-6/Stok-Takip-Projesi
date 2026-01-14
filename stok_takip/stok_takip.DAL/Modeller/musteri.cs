using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stok_takip.DAL.Modeller
{
    public class Musteri : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string MusteriTuru { get; set; } 
        public string Telefon { get; set; }
        public string Eposta { get; set; } 
    }


}
