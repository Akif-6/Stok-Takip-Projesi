using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using stok_takip.DAL;
using stok_takip.DAL.Modeller;
using System;
using System.Collections.Generic; 

namespace stok_takip.BLL
{
    public class UrunBLL
    {
       
        UrunDAL _urunDal = new UrunDAL();

       
        public List<Urun> TumUrunleriGetir()
        {
        
            return _urunDal.Listele();
        }

     
        public void UrunEkle(Urun urun)
        {
            
            if (string.IsNullOrEmpty(urun.UrunAdi))
                throw new Exception("Ürün adı boş bırakılamaz!");

            
            if (urun.StokMiktari < 0)
                throw new Exception("Stok miktarı 0'dan küçük olamaz!");

            _urunDal.Ekle(urun);
        }
        public void UrunGuncelle(Urun urun)
        {
            
            if (urun.StokMiktari < 0) throw new Exception("Stok miktarı 0'dan az olamaz!");
            _urunDal.Guncelle(urun);
        }

        public void UrunSil(int id)
        {
            _urunDal.Sil(id);
        }
    }
}
