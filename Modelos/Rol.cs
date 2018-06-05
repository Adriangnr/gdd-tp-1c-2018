using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Modelos
{
    public class Rol
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public bool estado { get; set; }

        public ArrayList funcionalidades;

        public Rol(int id, string nombre, bool estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.estado = estado;

            this.funcionalidades = new ArrayList();
        }

        public int guardar()
        {
            int resultado = 0;

            try
            {
                SqlCommand comando = ConectorDB.ConectorDb.obtenerComando();

                comando.CommandText = "insert into gd_esquema.Rol (nombre, estado) values (@nombre, @estado)";
                comando.Parameters.AddWithValue("@nombre", this.nombre);
                comando.Parameters.AddWithValue("@estado", this.estado);
                resultado = comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return resultado;
        }

        public int borrar()
        {
            int resultado = 0;

            try
            {
                SqlCommand comando = ConectorDB.ConectorDb.obtenerComando();

                comando.CommandText = "delete from gd_esquema.Rol where id=@id";
                comando.Parameters.AddWithValue("@id", this.id);
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
