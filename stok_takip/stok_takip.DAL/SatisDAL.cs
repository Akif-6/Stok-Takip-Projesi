using MySql.Data.MySqlClient;
using stok_takip.DAL.Modeller;
using System;
using System.Data;

namespace stok_takip.DAL
{
    public class SatisDAL
    {
        public DataTable SatislariGetir()
        {
            
            string sorgu = "SELECT * FROM satislar ORDER BY id DESC";

            using (var baglan = Baglanti.BaglantiAl())
            {
                baglan.Open();
                MySqlDataAdapter adaptor = new MySqlDataAdapter(sorgu, baglan);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
        }
        
        public void SatisYap(satis satis, SatisDetay detay)
        {
            using (var baglan = Baglanti.BaglantiAl()) // Senin Baglanti sınıfını kullanıyoruz
            {
                baglan.Open();

                // 1. ADIM: Ana Satışı (Fiş Başlığını) Kaydet
                // 'satislar' tablosuna ekleme yapıyoruz ve eklenen ID'yi istiyoruz (SELECT LAST_INSERT_ID)
                string sorguBaslik = "INSERT INTO satislar (musteri_id, kullanici_id, satis_tarihi, toplam_tutar) " +
                                     "VALUES (@p1, @p2, @p3, @p4); " +
                                     "SELECT LAST_INSERT_ID();";

                MySqlCommand komut = new MySqlCommand(sorguBaslik, baglan);
                komut.Parameters.AddWithValue("@p1", satis.MusteriId);
                komut.Parameters.AddWithValue("@p2", satis.KullaniciId); // Kullanıcı ID (varsayılan 1 gönderiyoruz)
                komut.Parameters.AddWithValue("@p3", satis.SatisTarihi);
                komut.Parameters.AddWithValue("@p4", satis.ToplamTutar);

                // ExecuteScalar bize sorgudan dönen ilk değeri (yani yeni oluşan ID'yi) verir
                int yeniSatisId = Convert.ToInt32(komut.ExecuteScalar());

                // 2. ADIM: Satış Detayını (Ürünü) Kaydet
                // Yukarıda aldığımız 'yeniSatisId'yi burada kullanıyoruz
                string sorguDetay = "INSERT INTO satis_detay (satis_id, urun_id, adet, birim_fiyat) " +
                                    "VALUES (@d1, @d2, @d3, @d4)";

                MySqlCommand komutDetay = new MySqlCommand(sorguDetay, baglan);
                komutDetay.Parameters.AddWithValue("@d1", yeniSatisId);
                komutDetay.Parameters.AddWithValue("@d2", detay.UrunId);
                komutDetay.Parameters.AddWithValue("@d3", detay.Adet);
                komutDetay.Parameters.AddWithValue("@d4", detay.BirimFiyat);

                komutDetay.ExecuteNonQuery();
            }
        }
    }
}