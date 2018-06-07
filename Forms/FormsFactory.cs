using FrbaHotel.AbmCliente;
using FrbaHotel.AbmHabitacion;
using FrbaHotel.AbmHotel;
using FrbaHotel.AbmRegimenes;
using FrbaHotel.AbmRol;
using FrbaHotel.GenerarModificacionReserva;
using FrbaHotel.Login;
using System;
using System.Collections;
using System.Windows.Forms;

namespace FrbaHotel
{
    public static class FormsFactory
    {
        private static Hashtable forms = new Hashtable();

        private static void llenarListaForms()
        {
            forms.Add("FrbaHotel",FrbaHotel.obtenerInstancia());
            forms.Add("Roles", Roles.obtenerInstancia());
            forms.Add("AltaRol", AltaRol.obtenerInstancia());
            forms.Add("GenerarModificarReserva", GenerarModificarReserva.obtenerInstancia());
            forms.Add("Login", Login.Login.obtenerInstancia());
            forms.Add("LoginPerfil", LoginPerfil.obtenerInstancia());
            forms.Add("LoginMenu", LoginMenu.obtenerInstancia());
            forms.Add("Hoteles", Hoteles.obtenerInstancia());
            forms.Add("Habitaciones", Habitaciones.obtenerInstancia());
            forms.Add("Regimenes", Regimenes.obtenerInstancia());
            forms.Add("Clientes", Clientes.obtenerInstancia());
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
