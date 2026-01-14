using stok_takip.DAL;
using stok_takip.DAL.Modeller;
using System;
using System.Collections.Generic;

namespace stok_takip.BLL
{
    public class musteriBLL
    {
        musteriDAL _musteriDal = new musteriDAL();

        public List<Musteri> TumMusterileriGetir() => _musteriDal.Listele();

        public void MusteriEkle(Musteri m)
        {
            if (string.IsNullOrEmpty(m.Ad) || string.IsNullOrEmpty(m.Soyad))
                throw new Exception("Müşteri adı ve soyadı boş olamaz!");

            _musteriDal.Ekle(m);
        }

        

        public void MusteriGuncelle(Musteri m)
        {
            
            if (string.IsNullOrEmpty(m.Ad) || string.IsNullOrEmpty(m.Soyad))
                throw new Exception("Ad ve Soyad boş bırakılamaz!");

            _musteriDal.Guncelle(m);
        }

        public void MusteriSil(int id)
        {
            _musteriDal.Sil(id);
        }
    }
}