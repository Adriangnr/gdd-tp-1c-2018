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
    public partial class AltaHabitacion : Form
    {
        private static AltaHabitacion instancia = null;

        public static AltaHabitacion obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new AltaHabitacion();
            }
            return instancia;
        }

        private AltaHabitacion()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAltaHabCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Habitaciones.obtenerInstancia().Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
