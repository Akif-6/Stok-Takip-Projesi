using stok_takip.DAL;
using stok_takip.DAL.Modeller;
using System;
using System.Collections.Generic;
using System.Data;
namespace stok_takip.BLL
{
    public class SatisBLL
    {
       
        SatisDAL _satisDal = new SatisDAL();
        UrunDAL _urunDal = new UrunDAL();


        
        public DataTable Listele()
        {
            return _satisDal.SatislariGetir();
        }

        public void SatisYap(int musteriId, int urunId, int adet, decimal satisFiyati)
        {
            // 1. ADIM: Önce ürünü bulalım ve STOK KONTROLÜ yapalım
            List<Urun> urunler = _urunDal.Listele();
            // Eğer UrunDAL'da metodun adı "TumUrunleriGetir" ise üstteki satırı ona göre değiştir.

            Urun satilacakUrun = urunler.Find(u => u.Id == urunId);

            // Ürün hiç yoksa hata ver
            if (satilacakUrun == null)
                throw new Exception("Hata: Seçilen ürün veritabanında bulunamadı!");

            // Stok, istenen adetten azsa hata ver (Satışı durdur)
            if (satilacakUrun.StokMiktari < adet)
                throw new Exception("Yetersiz Stok! Mevcut stok: " + satilacakUrun.StokMiktari);

            // 2. ADIM: Her şey tamamsa Satış Modellerini hazırla
            satis yeniSatis = new satis
            {
                MusteriId = musteriId,
                KullaniciId = 1, // Şimdilik varsayılan kullanıcı ID'si 1 olsun
                ToplamTutar = adet * satisFiyati,
                SatisTarihi = DateTime.Now
            };

            SatisDetay yeniDetay = new SatisDetay
            {
                UrunId = urunId,
                Adet = adet,
                BirimFiyat = satisFiyati
            };

            // 3. ADIM: Satışı Veritabanına Kaydet (SatisDAL üzerinden)
            _satisDal.SatisYap(yeniSatis, yeniDetay);

            // 4. ADIM: Stoğu Düş ve Güncelle (En önemli kısım)
            satilacakUrun.StokMiktari = satilacakUrun.StokMiktari - adet;

            _urunDal.Guncelle(satilacakUrun);
            // Eğer UrunDAL'da metodun adı "UrunGuncelle" ise üstteki satırı ona göre değiştir.
        }
    }
}