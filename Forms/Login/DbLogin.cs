using FrbaHotel.Modelos;
using FrbaHotel.Utils;
using System;
using System.Collections.Generic;
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
            if(!resultado.Read())
            {
                return false;
            }
            
            byte[] outByte = new byte[32];
            resultado.GetBytes(1, 0, outByte, 0, 32);

            String pass = FormUtils.obtenerStringDesdeHash(outByte);

            return resultado.HasRows && pass.Equals(FormUtils.generarSHA256(usuario.Password));
        }

        public static List<Rol> obtenerRolesDeUsuario(Usuario usuario)
        {
            List<Rol> roles = new List<Rol>();
            SqlCommand comando = ConectorDB.ConectorDb.obtenerComando();
            comando.CommandText = "select r.id, r.nombre, r.estado as estado from gd_esquema.Rol r " +
                "join gd_esquema.Rol_Usuario ru on r.id = ru.id_rol " +
                "join gd_esquema.Usuario u on u.id = ru.id_usuario " +
                "where u.username = @username";
            comando.Parameters.AddWithValue("@username", usuario.Username);
            Console.WriteLine(comando.CommandText);
            SqlDataReader resultado = comando.ExecuteReader();

            while (resultado.Read())
            {
                Rol rol = new Rol(resultado.GetInt32(0), resultado.GetString(1), resultado.GetBoolean(resultado.GetOrdinal("estado")));
                roles.Add(rol);
            }
            return roles;
        }
    }
}
