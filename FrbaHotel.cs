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
        public FrbaHotel()
        {
            InitializeComponent();
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
            //Login.Login login = new Login.Login();
            //login.Show();
            AbmUsuario.AltaUsuario au = new AbmUsuario.AltaUsuario();
            au.Show();
            this.Hide();
        }
    }
}
