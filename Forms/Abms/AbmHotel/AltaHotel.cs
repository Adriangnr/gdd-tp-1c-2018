using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class AltaHotel : ParentForm
    {
        private static AltaHotel instancia = null;

        public static AltaHotel obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new AltaHotel();
            }
            return instancia;
        }

        private AltaHotel()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAltaHotelCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hoteles.obtenerInstancia().Show();
        }
    }
}
