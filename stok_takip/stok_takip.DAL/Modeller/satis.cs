using System;

namespace stok_takip.DAL.Modeller
{
    public class satis
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int KullaniciId { get; set; }
        public DateTime SatisTarihi { get; set; }
        public decimal ToplamTutar { get; set; }
    }
}