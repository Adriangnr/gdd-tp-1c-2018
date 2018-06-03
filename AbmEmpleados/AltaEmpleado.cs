using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmEmpleados
{
    public partial class AltaEmpleado : ParentForm
    {
        private static AltaEmpleado instancia = null;

        public static AltaEmpleado obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new AltaEmpleado();
            }
            return instancia;
        }

        private AltaEmpleado()
        {
            InitializeComponent();
        }

        private void btnAltaEmpleadoCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empleados.obtenerInstancia().Show();
        }
    }
}
