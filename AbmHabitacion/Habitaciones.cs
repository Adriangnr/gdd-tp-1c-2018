using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHabitacion
{
    public partial class Habitaciones : Form
    {
        private static Habitaciones instancia = null;

        public static Habitaciones obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Habitaciones();
            }
            return instancia;
        }

        private Habitaciones()
        {
            InitializeComponent();
        }

        private void btnHabitacionesSalir_Click(object sender, EventArgs e)
        {
            FormUtils.FormUtils.ocultarForm();
        }
    }
}
