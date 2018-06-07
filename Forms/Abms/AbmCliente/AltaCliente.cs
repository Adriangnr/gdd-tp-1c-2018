using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmCliente
{
    public partial class AltaCliente : ParentForm
    {
        private static AltaCliente instancia = null;

        public static AltaCliente obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new AltaCliente();
            }
            return instancia;
        }

        private AltaCliente()
        {
            InitializeComponent();
        }

        private void dateAltaClienteFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAltaClienteCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes.obtenerInstancia().Show();
        }
    }
}
