using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System;

namespace stok_takip.DAL
{
    public class KullaniciDAL
    {
        public string GirişYap(string ad, string sifre)
        {
            using (var baglan = Baglanti.BaglantiAl())
            {
                baglan.Open();
                
                string sorgu = "SELECT role FROM users WHERE username=@p1 AND password=@p2";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@p1", ad);
                komut.Parameters.AddWithValue("@p2", sifre);

                object sonuc = komut.ExecuteScalar(); // Tek bir değer (rol) döndürür

                return sonuc != null ? sonuc.ToString() : null;
            }
        }
    }
}
