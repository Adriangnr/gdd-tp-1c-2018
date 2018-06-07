using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Modelos
{
    public class Funcionalidad
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Funcionalidad(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
