using System;

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
            FormsFactory.obtenerFormulario("GenerarModificarReserva").Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormsFactory.obtenerFormulario("Login").Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
