using System;
using System.Windows.Forms;
using FrbaHotel.AbmUsuario;
using FrbaHotel.AbmRol;
using FrbaHotel.AbmCliente;
using FrbaHotel.AbmHotel;
using FrbaHotel.AbmRegimen;
using FrbaHotel.AbmHabitacion;

namespace FrbaHotel.Login
{
    public partial class LoginMenu : Form
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
            Login.obtenerInstancia().Show();
        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios.obtenerInstancia().Show();
        }

        private void btnLoginMenuClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes.obtenerInstancia().Show();
        }

        private void btnLoginMenuRoles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Roles.obtenerInstancia().Show();
        }

        private void btnLoginMenuHoteles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hoteles.obtenerInstancia().Show();
        }

        private void btnLoginMenuRegimenes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regimenes.obtenerInstancia().Show();
        }

        private void btnLoginMenuReservas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservas.Reservas.obtenerInstancia().caller = this;
            Reservas.Reservas.obtenerInstancia().Show();
        }

        private void btnLoginMenuHabitaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Habitaciones.obtenerInstancia().Show();
        }

        private void btnLoginMenuEstadisticas_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListadoEstadistico.ListadoEstadistico.obtenerInstancia().Show();
        }
    }
}
