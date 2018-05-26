using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class LoginPerfil : Form
    {
        private static LoginPerfil instancia = null;

        public static LoginPerfil obtenerInstancia()
        {
            if( instancia == null)
            {
                instancia = new LoginPerfil();
            }
            return instancia;
        }

        private LoginPerfil()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelLoginPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginPerfilContinuar_Click(object sender, EventArgs e)
        {
            LoginMenu loginMenu = LoginMenu.obtenerInstancia();
            this.Hide();
            loginMenu.Show();
        }
    }
}
