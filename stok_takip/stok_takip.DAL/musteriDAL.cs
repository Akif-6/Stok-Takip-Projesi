using MySql.Data.MySqlClient;
using stok_takip.DAL.Modeller;
using System.Collections.Generic;

namespace stok_takip.DAL
{
    public class musteriDAL : IRepository<Musteri>
    {
        public List<Musteri> Listele()
        {
            List<Musteri> musteriler = new List<Musteri>();
            using (var baglan = Baglanti.BaglantiAl())
            {
                baglan.Open();
                string sorgu = "SELECT * FROM musteriler";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                MySqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    musteriler.Add(new Musteri
                    {
                        Id = (int)oku["id"],
                        Ad = oku["ad"].ToString(),
                        Soyad = oku["soyad"].ToString(),
                        MusteriTuru = oku["musteri_turu"].ToString(),
                        Telefon = oku["telefon"]?.ToString(),
                        Eposta = oku["eposta"]?.ToString()
                    });
                }
            }
            return musteriler;
        }

        public void Ekle(Musteri entity)
        {
            using (var baglan = Baglanti.BaglantiAl())
            {
                baglan.Open();
                string sorgu = "INSERT INTO musteriler (ad, soyad, musteri_turu, telefon, eposta) " +
                               "VALUES (@p1, @p2, @p3, @p4, @p5)";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@p1", entity.Ad);
                komut.Parameters.AddWithValue("@p2", entity.Soyad);
                komut.Parameters.AddWithValue("@p3", entity.MusteriTuru);
                komut.Parameters.AddWithValue("@p4", entity.Telefon);
                komut.Parameters.AddWithValue("@p5", entity.Eposta);
                komut.ExecuteNonQuery();
            }
        }

        
        public void Guncelle(Musteri entity)
        {
            using (var baglan = Baglanti.BaglantiAl())
            {
                baglan.Open();
                string sorgu = "UPDATE musteriler SET ad=@p1, soyad=@p2, musteri_turu=@p3, telefon=@p4, eposta=@p5 WHERE id=@p6";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@p1", entity.Ad);
                komut.Parameters.AddWithValue("@p2", entity.Soyad);
                komut.Parameters.AddWithValue("@p3", entity.MusteriTuru);
                komut.Parameters.AddWithValue("@p4", entity.Telefon);
                komut.Parameters.AddWithValue("@p5", entity.Eposta);
                komut.Parameters.AddWithValue("@p6", entity.Id);
                komut.ExecuteNonQuery();
            }
        }

        
        public void Sil(int id)
        {
            using (var baglan = Baglanti.BaglantiAl())
            {
                baglan.Open();
                string sorgu = "DELETE FROM musteriler WHERE id=@p1";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@p1", id);
                komut.ExecuteNonQuery();
            }
        }
    }
}