using MySql.Data.MySqlClient;
using System.Data;

namespace stok_takip.DAL
{
    public class RaporDAL
    {
        
        public DataTable KritikStokGetir()
        {

            string sorgu = "SELECT urun_adi, stok_miktari, satis_fiyati FROM urunler WHERE stok_miktari <= 20 ORDER BY stok_miktari ASC";

            using (var baglan = Baglanti.BaglantiAl())
            {
                baglan.Open();
                MySqlDataAdapter adaptor = new MySqlDataAdapter(sorgu, baglan);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
        }

        
        public DataTable EnIyiMusterileriGetir()
        {
            
            string sorgu = "SELECT m.ad, m.soyad, SUM(s.toplam_tutar) as ToplamHarcama " +
                           "FROM satislar s " +
                           "JOIN musteriler m ON s.musteri_id = m.id " +
                           "GROUP BY m.ad, m.soyad " +
                           "ORDER BY ToplamHarcama DESC";

            using (var baglan = Baglanti.BaglantiAl())
            {
                baglan.Open();
                MySqlDataAdapter adaptor = new MySqlDataAdapter(sorgu, baglan);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
        }
        public DataTable EnCokSatilanUrunler()
        {
            string sorgu = "SELECT u.urun_adi, SUM(d.adet) as ToplamSatisAdedi " +
                           "FROM satis_detay d " +
                           "JOIN urunler u ON d.urun_id = u.id " +
                           "GROUP BY u.urun_adi " +
                           "ORDER BY ToplamSatisAdedi DESC";

            using (var baglan = Baglanti.BaglantiAl())
            {
                baglan.Open();
                MySqlDataAdapter adaptor = new MySqlDataAdapter(sorgu, baglan);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
        }

        
        public DataTable ToplamCiroGetir()
        {
            string sorgu = "SELECT SUM(toplam_tutar) as ToplamCiro, COUNT(*) as ToplamSatisSayisi FROM satislar";

            using (var baglan = Baglanti.BaglantiAl())
            {
                baglan.Open();
                MySqlDataAdapter adaptor = new MySqlDataAdapter(sorgu, baglan);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
        }

        

       
        public DataTable KarZararRaporuGetir()
        {
           
            string sorgu = @"
        SELECT 
            u.urun_adi as 'Ürün Adı', 
            SUM(sd.adet) as 'Satılan Adet',
            SUM((sd.birim_fiyat - u.alis_fiyati) * sd.adet) as 'Toplam Kâr'
        FROM satis_detay sd
        JOIN urunler u ON sd.urun_id = u.id
        GROUP BY u.urun_adi
        ORDER BY 'Toplam Kâr' DESC";

            using (var baglan = Baglanti.BaglantiAl())
            {
                baglan.Open();
                MySqlDataAdapter adaptor = new MySqlDataAdapter(sorgu, baglan);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
        }

       
        public DataTable AylikSatisRaporuGetir()
        {
         
            string sorgu = @"
        SELECT 
            DATE_FORMAT(satis_tarihi, '%Y-%m') as 'Dönem', 
            COUNT(*) as 'Toplam Satış Sayısı', 
            SUM(toplam_tutar) as 'Toplam Ciro'
        FROM satislar
        GROUP BY DATE_FORMAT(satis_tarihi, '%Y-%m')
        ORDER BY 'Dönem' DESC";

            using (var baglan = Baglanti.BaglantiAl())
            {
                baglan.Open();
                MySqlDataAdapter adaptor = new MySqlDataAdapter(sorgu, baglan);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
        }
    }
}