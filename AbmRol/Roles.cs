using System;
using FrbaHotel.Login;
using System.Windows.Forms;

namespace FrbaHotel.AbmRol
{
    public partial class Roles : Form
    {
        private static Roles instancia = null;

        public static Roles obtenerInstancia()
        {
            if( instancia == null)
            {
                instancia = new Roles();
            }
            return instancia;
        }

        private Roles()
        {
            InitializeComponent();
        }

        private void dataGridRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAltaRolesCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMenu.obtenerInstancia().Show();
        }

        private void btnRolesCargar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaRol.obtenerInstancia().Show();
        }
    }
}
