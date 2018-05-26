using System;
using System.Windows.Forms;
using FrbaHotel.AbmUsuario;

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
            Usuarios.obtenerInstancia().Show();
            this.Hide();
        }

        private void btnLoginMenuClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
