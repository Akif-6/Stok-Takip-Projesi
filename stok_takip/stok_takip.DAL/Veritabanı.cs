using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Configuration;

namespace stok_takip.DAL
{
    public class Baglanti
    {
       
        

        public static MySqlConnection BaglantiAl()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["StokBaglantisi"].ConnectionString;
            return new MySqlConnection(connectionString);
        }
    }
}
