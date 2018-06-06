using System;
using System.Windows.Forms;

namespace FrbaHotel.AbmHabitacion
{
    public partial class Habitaciones : ParentForm
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
            this.Hide();
            Login.LoginMenu.obtenerInstancia().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaHabitacion.obtenerInstancia().Show();
        }
    }
}
