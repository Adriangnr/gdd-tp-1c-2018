using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.AbmUsuario;

namespace FrbaHotel
{
    public partial class FrbaHotel : Form
    {
        private static FrbaHotel instancia = null;

        private FrbaHotel()
        {
            InitializeComponent();
        }

        public static FrbaHotel obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FrbaHotel();
            }
            return instancia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarModificacionReserva.GenerarModificarReserva gmreserva =
                new GenerarModificacionReserva.GenerarModificarReserva();
            this.Hide();
            gmreserva.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Login.Login login = Login.Login.obtenerInstancia();
            login.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
