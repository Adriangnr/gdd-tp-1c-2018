using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRol
{
    public partial class AltaRol : Form
    {
        private static AltaRol instancia = null;

        public static AltaRol obtenerInstancia()
        {
            if( instancia == null)
            {
                instancia = new AltaRol();
            }
            return instancia;
        }

        private AltaRol()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAltaUsuarioCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Roles.obtenerInstancia().Show();
        }
    }
}
