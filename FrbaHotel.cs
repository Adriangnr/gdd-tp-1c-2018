using System;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class FrbaHotel : Form
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
            FormUtils.FormUtils.mostarForm(this, 
                GenerarModificacionReserva.GenerarModificarReserva.obtenerInstancia());
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormUtils.FormUtils.mostarForm(this, Login.Login.obtenerInstancia());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
