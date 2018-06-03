using System;
using System.Data.SqlClient;
using FrbaHotel.Modelos;

namespace FrbaHotel.AbmUsuario
{

    public class DbUsuario
    {
        public int guardarUsuario(Usuario usr) 
        {
            int resultado = 0;

            try
            {
                SqlCommand comando = ConectorDB.ConectorDb.obtenerComando();
                
                comando.CommandText = "insert into Usuarios (username, upassword, habilitado, intentos) values (@username, @password, @hab, @intentos)";
                comando.Parameters.AddWithValue("@username", usr.Username);
                comando.Parameters.AddWithValue("@password", usr.Password);
                comando.Parameters.AddWithValue("@hab", usr.Habilitado);
                comando.Parameters.AddWithValue("@intentos", usr.Intentos);
                resultado = comando.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return resultado;
        }
    }
}
