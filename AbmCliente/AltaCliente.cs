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
    public partial class txtAltaClienteApellido : ParentForm
    {
        private static txtAltaClienteApellido instancia = null;

        public static txtAltaClienteApellido obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new txtAltaClienteApellido();
            }
            return instancia;
        }

        private txtAltaClienteApellido()
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
