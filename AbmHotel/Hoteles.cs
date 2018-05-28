using System;
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
            this.Hide();
            Login.LoginMenu.obtenerInstancia().Show();
        }

        private void btnHotelesCargar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaHotel.obtenerInstancia().Show();
        }
    }
}
