using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRegimenes
{
    public partial class Regimenes : ParentForm
    {
        private static Regimenes instancia = null;

        public static Regimenes obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Regimenes();
            }
            return instancia;
        }

        private Regimenes()
        {
            InitializeComponent();
        }

        private void btnRegimenesCargar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaRegimen.obtenerInstancia().Show();
        }

        private void btnRegimenesCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.LoginMenu.obtenerInstancia().Show();
        }
    }
}
