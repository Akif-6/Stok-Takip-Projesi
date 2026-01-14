using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stok_takip.DAL.Modeller
{
    
    public class Urun : BaseEntity
    {
        public string UrunAdi { get; set; }
        public int StokMiktari { get; set; }
        public decimal AlisFiyati { get; set; } 
        public decimal SatisFiyati { get; set; }
        public int MinStokSeviyesi { get; set; } 
    }
}
