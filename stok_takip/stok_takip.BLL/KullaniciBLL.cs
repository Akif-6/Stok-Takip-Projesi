using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using stok_takip.DAL;

namespace stok_takip.BLL
{
    public class KullaniciBLL
    {
        KullaniciDAL kullaniciDal = new KullaniciDAL();

        public string KontrolEt(string ad, string sifre)
        {
           
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(sifre))
                return null;

            return kullaniciDal.GirişYap(ad, sifre);
        }
    }
}
