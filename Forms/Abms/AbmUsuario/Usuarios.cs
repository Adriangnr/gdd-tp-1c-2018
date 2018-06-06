using System;
using System.Windows.Forms;
using FrbaHotel.Login;

namespace FrbaHotel.AbmUsuario
{
    public partial class Usuarios : ParentForm
    {
        private static Usuarios instancia = null;

        public static Usuarios obtenerInstancia()
        {
            if( instancia == null)
            {
                instancia = new Usuarios();
            }
            return instancia;
        }

        private Usuarios()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMenu.obtenerInstancia().Show();
        }

        private void btnAltaUsuarioCargar_Click(object sender, EventArgs e)
        {
            AltaUsuario.obtenerInstancia().Show();
            this.Hide();
        }
    }
}
