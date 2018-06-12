using System;
using FrbaHotel.Utils;

namespace FrbaHotel.Login
{
    public partial class LoginMenu : ParentForm
    {
        private static LoginMenu instancia = null;

        public static LoginMenu obtenerInstancia()
        {
            if( instancia == null)
            {
                instancia = new LoginMenu();
            }
            return instancia;
        }

        private LoginMenu()
        {
            InitializeComponent();
        }

        private void btnLoginMenuSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = (Login) FormsFactory.obtenerFormulario("Login");
            login.refrescar();
            login.Show();
        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUtils.cambiarFormulario(this, "Usuarios");
        }

        private void btnLoginMenuClientes_Click(object sender, EventArgs e)
        {
            FormUtils.cambiarFormulario(this, "Clientes");
        }

        private void btnLoginMenuRoles_Click(object sender, EventArgs e)
        {
            FormUtils.cambiarFormulario(this, "Roles");
        }

        private void btnLoginMenuHoteles_Click(object sender, EventArgs e)
        {
            FormUtils.cambiarFormulario(this, "Hoteles");
        }

        private void btnLoginMenuRegimenes_Click(object sender, EventArgs e)
        {
            FormUtils.cambiarFormulario(this, "Regimenes");
        }

        private void btnLoginMenuReservas_Click(object sender, EventArgs e)
        {
            /*
             El formulario de reservas, no utiliza el FormUtils, ya que se puede acceder a el, siendo cliente
             o usuario del sistema, y se necesita saber a donde volver al salir.
             */
            this.Hide();
            Reservas.Reservas.obtenerInstancia().caller = this;
            Reservas.Reservas.obtenerInstancia().Show();
        }

        private void btnLoginMenuHabitaciones_Click(object sender, EventArgs e)
        {
            FormUtils.cambiarFormulario(this, "Habitaciones");
        }

        private void btnLoginMenuEstadisticas_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListadoEstadistico.ListadoEstadistico.obtenerInstancia().Show();
        }
    }
}
