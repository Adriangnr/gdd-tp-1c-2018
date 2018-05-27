using System;
using System.Windows.Forms;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class GenerarModificarReserva : Form
    {
        private static GenerarModificarReserva instancia = null;

        public static GenerarModificarReserva obtenerInstancia()
        {
            if( instancia == null)
            {
                instancia = new GenerarModificarReserva();
            }
            return instancia;
        }

        private GenerarModificarReserva()
        {
            InitializeComponent();
        }

        private void GenerarModificarReserva_Load(object sender, EventArgs e)
        {

        }

        private void txtFiltros_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtHotel.Clear();
            txtHuespedes.Clear();
            txtFiltros.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormUtils.FormUtils.ocultarForm();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Login.Login login = Login.Login.obtenerInstancia();
            login.Show();
            this.Hide();
        }

        private void btnGenerarModificarReservaModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservas.Reservas reservas = Reservas.Reservas.obtenerInstancia();
            reservas.caller = this;
            reservas.Show();
        }
    }
}
