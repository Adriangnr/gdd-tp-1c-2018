using System.Data.SqlClient;
using FrbaHotel.Properties;

namespace FrbaHotel.ConectorDB
{
    public class ConectorDb
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection con = new SqlConnection(Settings.Default.FrbaHotelConnectionString);
            con.Open();
            return con;
        }
    }
}
