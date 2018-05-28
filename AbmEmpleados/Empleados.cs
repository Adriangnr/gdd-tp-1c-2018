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
    public partial class Empleados : Form
    {
        private static Empleados instancia = null;

        public static Empleados obtenerInstancia()
        {
            if( instancia == null)
            {
                instancia = new Empleados();
            }
            return instancia;
        }

        private Empleados()
        {
            InitializeComponent();
        }

        private void btnEmpleadosCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.LoginMenu.obtenerInstancia().Show();
        }
    }
}
