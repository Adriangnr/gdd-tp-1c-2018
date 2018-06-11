using FrbaHotel.Modelos;
using FrbaHotel.Utils;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace FrbaHotel.Login
{
    public class DbLogin
    {
        public static Boolean existeUsuario(Usuario usuario)
        {
            SqlCommand comando = ConectorDB.ConectorDb.obtenerComando();
            comando.CommandText = "select username, password from gd_esquema.Usuario where username = @username";
            comando.Parameters.AddWithValue("@username", usuario.Username);
            SqlDataReader resultado = comando.ExecuteReader();
            resultado.Read();
            byte[] outByte = new byte[32];
            resultado.GetBytes(1, 0, outByte, 0, 32);
            String pass = FormUtils.obtenerStringDesdeHash(outByte);
            Console.WriteLine(FormUtils.generarSHA256(usuario.Password));
            Console.WriteLine(pass);
            return resultado.HasRows && pass.Equals(FormUtils.generarSHA256(usuario.Password));
        }
    }
}
