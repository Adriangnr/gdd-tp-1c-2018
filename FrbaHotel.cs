using System;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class FrbaHotel : ParentForm
    {
        private static FrbaHotel instancia = null;

        private FrbaHotel()
        {
            InitializeComponent();
        }

        public static FrbaHotel obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FrbaHotel();
            }
            return instancia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenerarModificacionReserva.GenerarModificarReserva.obtenerInstancia().Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.Login.obtenerInstancia().Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
