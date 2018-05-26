using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class GenerarModificarReserva : Form
    {
        public GenerarModificarReserva()
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
            FrbaHotel frbaHotel = new FrbaHotel();
            this.Hide();
            frbaHotel.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Login.Login login = new Login.Login();
            login.Show();
            this.Hide();
        }
    }
}
