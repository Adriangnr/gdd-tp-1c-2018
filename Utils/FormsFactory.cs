using FrbaHotel.AbmRol;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Utils
{
    public static class FormsFactory
    {
        private static Hashtable forms = new Hashtable();

        private static void llenarListaForms()
        {
            forms.Add("Roles", Roles.obtenerInstancia());
        }

        public static Form obtenerFormulario(String nombre)
        {
            if( forms.Count == 0)
            {
                llenarListaForms();
            }
            return (Form)forms[nombre];
        }
    }
}
