namespace stok_takip.DAL.Modeller
{
    public class SatisDetay
    {
        public int Id { get; set; }
        public int SatisId { get; set; } // Hangi satışa ait olduğu
        public int UrunId { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
    }
}