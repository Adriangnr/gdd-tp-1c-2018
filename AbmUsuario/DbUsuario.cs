using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaHotel.Modelos;

namespace FrbaHotel.AbmUsuario
{

    public class DbUsuario
    {
        public int guardarUsuario(Usuario usr)
        {
            SqlCommand comando = ConectorDB.ConectorDb.obtenerComando();
            comando.Connection = ConectorDB.ConectorDb.ObtenerConexion();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "insert into Usuarios (username, upassword, habilitado, intentos) values (@username, @password, @hab, @intentos)";
            comando.Parameters.AddWithValue("@username", usr.Username);
            comando.Parameters.AddWithValue("@password", usr.Password);
            comando.Parameters.AddWithValue("@hab", usr.Habilitado);
            comando.Parameters.AddWithValue("@intentos", usr.Intentos);

            return comando.ExecuteNonQuery();
        }
    }
}
