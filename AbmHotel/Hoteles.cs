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
    public partial class Hoteles : Form
    {
        private static Hoteles instancia = null;

        public static Hoteles obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Hoteles();
            }
            return instancia;
        }

        private Hoteles()
        {
            InitializeComponent();
        }

        private void btnHotelesSalir_Click(object sender, EventArgs e)
        {
            FormUtils.FormUtils.ocultarForm();
        }
    }
}
