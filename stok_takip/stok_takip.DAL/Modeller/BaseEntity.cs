using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace stok_takip.DAL.Modeller
{
  
    public abstract class BaseEntity
    {
     
        public int Id { get; set; }
        public DateTime KayitTarihi { get; set; } = DateTime.Now;
    }
}
