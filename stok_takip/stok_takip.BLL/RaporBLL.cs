using stok_takip.DAL;
using System.Data;

namespace stok_takip.BLL
{
    public class RaporBLL
    {
        RaporDAL _raporDal = new RaporDAL();

        public DataTable KritikStokListele()
        {
            return _raporDal.KritikStokGetir();
        }

        public DataTable EnIyiMusterilerListele()
        {
            return _raporDal.EnIyiMusterileriGetir();
        }

        public DataTable KarZararRaporu()
        {
            return _raporDal.KarZararRaporuGetir();
        }

        public DataTable AylikSatisRaporu()
        {
            return _raporDal.AylikSatisRaporuGetir();
        }

        public DataTable EnCokSatanlarListele()
        {
            return _raporDal.EnCokSatilanUrunler();
        }

        public DataTable CiroListele()
        {
            return _raporDal.ToplamCiroGetir();
        }


    }
}