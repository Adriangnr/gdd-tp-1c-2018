using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Utils.DB
{
    public static class DBInterfaz
    {

        private static SqlCommand agregarCondiciones(SqlCommand comando, Hashtable condiciones)
        {
            comando.CommandText += " where ";
            foreach (DictionaryEntry condicion in condiciones)
            {
                comando.CommandText += condicion.Key + "=@" + condicion.Key;
                comando.Parameters.AddWithValue("@" + condicion.Key, condicion.Value);
            }

            return comando;
        }

        public static int borrar(String tabla, Hashtable condiciones)
        {
            int resultado = 0;
            try
            {
                SqlCommand comando = ConectorDB.ConectorDb.obtenerComando();
                comando.CommandText = "delete from " + tabla;
                if (condiciones.Count > 0)
                {
                    comando = agregarCondiciones(comando, condiciones);
                }
                resultado = comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return resultado;
        }

        private static SqlCommand agregarNuevosValores(SqlCommand comando, Hashtable nuevosValore)
        {
            foreach (DictionaryEntry valor in nuevosValore)
            {
                comando.CommandText += valor.Key + "=" + valor.Value + ", ";
            }
            comando.CommandText = comando.CommandText.Remove(comando.CommandText.Length - 1);
            comando.CommandText = comando.CommandText.Remove(comando.CommandText.Length - 1);

            return comando;
        }

        public static int actualizar(String tabla, Hashtable nuevosValores, Hashtable condiciones)
        {
            int resultado = 0;
            try
            {
                SqlCommand comando = ConectorDB.ConectorDb.obtenerComando();
                comando.CommandText = "update " + tabla + " set ";
                comando = agregarNuevosValores(comando, nuevosValores);
                if (condiciones.Count > 0)
                {
                    comando = agregarCondiciones(comando, condiciones);
                }
                Console.WriteLine(comando.CommandText);
                resultado = comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return resultado;
        }
    }
}
