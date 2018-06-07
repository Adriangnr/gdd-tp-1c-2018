using System;
using System.Collections.Generic;
using System.Data;
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

        public static List<Funcionalidad> obtenerFuncionalidadesPorRol(int id)
        {
            List<Funcionalidad> listado = new List<Funcionalidad>();
            SqlCommand comando = ConectorDB.ConectorDb.obtenerComando();
            comando.CommandText = "select id_funcionalidad from gd_esquema.Funcionalidad_Rol where id_rol = @idrol";
            comando.Parameters.AddWithValue("@idrol", id);
         
            SqlDataReader resultado = comando.ExecuteReader();

            while (resultado.Read())
            {
                listado.Add( obtenerFuncionalidadPorId(resultado.GetInt32(0)) );
            }
            return listado;
        }

        private static Funcionalidad obtenerFuncionalidadPorId(int id)
        {
            SqlCommand comando = ConectorDB.ConectorDb.obtenerComando();
            comando.CommandText = "select id, nombre from gd_esquema.Funcionalidad where id = @id";
            comando.Parameters.AddWithValue("@id", id);
            SqlDataReader resultado = comando.ExecuteReader();
            
            resultado.Read();
            return new Funcionalidad(resultado.GetInt32(0), resultado.GetString(1));
        }

        private static int guardarSoloRol(Rol rol)
        {
            SqlCommand comando = ConectorDB.ConectorDb.obtenerComando();
            comando.CommandText = "insert into gd_esquema.Rol (nombre, estado) values (@nombre, @estado); SELECT SCOPE_IDENTITY();";
            comando.Parameters.AddWithValue("@nombre", rol.nombre);
            comando.Parameters.AddWithValue("@estado", rol.estado);
            rol.id = Convert.ToInt32(comando.ExecuteScalar());
            return rol.id;
        }

        private static int guardarFuncionalidades(Rol rol)
        {
            Console.WriteLine(rol.funcionalidades[0]);
            int resultado = 0;
            try
            {
                foreach(Funcionalidad func in rol.funcionalidades)
                {
                    SqlCommand comando = ConectorDB.ConectorDb.obtenerComando();
                    comando.CommandText = "insert into gd_esquema.Funcionalidad_Rol (id_funcionalidad, id_rol) values (@id_func, @id_rol)";
                    comando.Parameters.AddWithValue("@id_func", func.id);
                    comando.Parameters.AddWithValue("@id_rol", rol.id);

                    resultado = comando.ExecuteNonQuery();
                    if ( resultado <= 0)
                    {
                        return resultado;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return resultado;
        }

        public static int guardarRol(Rol rol)
        {
            int resultado = 0;
            try
            {
                if (guardarSoloRol(rol) > 0)
                {
                    resultado = guardarFuncionalidades(rol);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return resultado;
        }

        public static int borrarRol(Rol rol)
        {
            int resultado = 0;
            try
            {
                SqlCommand comando = ConectorDB.ConectorDb.obtenerComando();

                comando.CommandText = "delete from gd_esquema.Rol where id=@id";
                comando.Parameters.AddWithValue("@id", rol.id);
                resultado = comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return resultado;
        }
    }
}
