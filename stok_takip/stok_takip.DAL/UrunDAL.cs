using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using stok_takip.DAL.Modeller;
using System.Collections.Generic;

namespace stok_takip.DAL
{
    public class UrunDAL : IRepository<Urun>
    {
        public List<Urun> Listele()
        {
            List<Urun> urunler = new List<Urun>();
            using (var baglan = Baglanti.BaglantiAl())
            {
                baglan.Open();
                string sorgu = "SELECT * FROM urunler";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                MySqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    urunler.Add(new Urun
                    {
                        Id = (int)oku["id"],
                        UrunAdi = oku["urun_adi"].ToString(),
                        StokMiktari = (int)oku["stok_miktari"],
                        AlisFiyati = (decimal)oku["alis_fiyati"],
                        SatisFiyati = (decimal)oku["satis_fiyati"],
                        MinStokSeviyesi = (int)oku["min_stok_seviyesi"]
                    });
                }
            }
            return urunler;
        }

        // Ürün Ekleme Sorgusu
        public void Ekle(Urun entity)
        {
            using (var baglan = Baglanti.BaglantiAl())
            {
                baglan.Open();
                string sorgu = "INSERT INTO urunler (urun_adi, stok_miktari, alis_fiyati, satis_fiyati, min_stok_seviyesi) " +
                               "VALUES (@p1, @p2, @p3, @p4, @p5)";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@p1", entity.UrunAdi);
                komut.Parameters.AddWithValue("@p2", entity.StokMiktari);
                komut.Parameters.AddWithValue("@p3", entity.AlisFiyati);
                komut.Parameters.AddWithValue("@p4", entity.SatisFiyati);
                komut.Parameters.AddWithValue("@p5", entity.MinStokSeviyesi);
                komut.ExecuteNonQuery();
            }
        }

        // Ürün Güncelleme Sorgusu
        public void Guncelle(Urun entity)
        {
            using (var baglan = Baglanti.BaglantiAl())
            {
                baglan.Open();
                string sorgu = "UPDATE urunler SET urun_adi=@p1, stok_miktari=@p2, alis_fiyati=@p3, satis_fiyati=@p4, min_stok_seviyesi=@p5 WHERE id=@p6";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@p1", entity.UrunAdi);
                komut.Parameters.AddWithValue("@p2", entity.StokMiktari);
                komut.Parameters.AddWithValue("@p3", entity.AlisFiyati);
                komut.Parameters.AddWithValue("@p4", entity.SatisFiyati);
                komut.Parameters.AddWithValue("@p5", entity.MinStokSeviyesi);
                komut.Parameters.AddWithValue("@p6", entity.Id);
                komut.ExecuteNonQuery();
            }
        }

        // Ürün Silme Sorgusu
        public void Sil(int id)
        {
            using (var baglan = Baglanti.BaglantiAl())
            {
                baglan.Open();
                string sorgu = "DELETE FROM urunler WHERE id=@p1";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@p1", id);
                komut.ExecuteNonQuery();
            }
        }
    }
}
