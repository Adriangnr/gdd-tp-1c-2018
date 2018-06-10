using FrbaHotel.AbmRol;
using System.Collections.Generic;

namespace FrbaHotel.Modelos
{
    public class Rol : FrbaModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public bool estado { get; set; }

        public List<Funcionalidad> funcionalidades;

        public Rol(int id, string nombre, bool estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.estado = estado;

            this.funcionalidades = new List<Funcionalidad>();
        }

        public int guardar() //debe usar un store procedure.
        {
            return DBRol.guardarRol(this);
        }

        public int borrar()
        {
            return DBRol.borrarRol(this);
        }

        public int actualizar()
        {
            return DBRol.actualizarRol(this);
        }
    }
}
