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
    }
}
