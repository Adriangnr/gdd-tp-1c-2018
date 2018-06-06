using System.Collections.Generic;
using System.Data.SqlClient;
using FrbaHotel.Modelos;

namespace FrbaHotel.AbmRol
{
    public class DBRol
    {
        public static List<Rol> buscarRoles()
        {
            List<Rol> listado = new List<Rol>();
            SqlCommand comando = ConectorDB.ConectorDb.obtenerComando();
            comando.CommandText = "select * from gd_esquema.Rol";
            SqlDataReader resultado = comando.ExecuteReader();

            while( resultado.Read())
            {
                Rol rol = new Rol(resultado.GetInt32(0), resultado.GetString(1), resultado.GetBoolean(resultado.GetOrdinal("estado")));
                listado.Add(rol);
            }
            return listado;
        }

        public static List<Funcionalidad> obtenerFuncionalidades()
        {
            List<Funcionalidad> listado = new List<Funcionalidad>();
            SqlCommand comando = ConectorDB.ConectorDb.obtenerComando();
            comando.CommandText = "select * from gd_esquema.Funcionalidad";
            SqlDataReader resultado = comando.ExecuteReader();

            while (resultado.Read())
            {
                Funcionalidad fun = new Funcionalidad(resultado.GetInt32(0), resultado.GetString(1));
                listado.Add(fun);
            }
            return listado;
        }
    }
}
