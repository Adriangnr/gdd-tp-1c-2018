using System;
using FrbaHotel.Login;
using System.Windows.Forms;

namespace FrbaHotel.AbmCliente
{
    public partial class Clientes : Form
    {
        private static Clientes instancia = null;

        public static Clientes obtenerInstancia()
        {
            if( instancia == null)
            {
                instancia = new Clientes();
            }
            return instancia;
        }

        private Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void btnClientesSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.LoginMenu.obtenerInstancia().Show();
        }

        private void btnClientesCargar_Click(object sender, EventArgs e)
        {
            this.Hide();
            txtAltaClienteApellido.obtenerInstancia().Show();
        }
    }
}
