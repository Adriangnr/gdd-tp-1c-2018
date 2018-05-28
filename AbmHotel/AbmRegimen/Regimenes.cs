using System;
using System.Windows.Forms;

namespace FrbaHotel.AbmRegimen
{
    public partial class Regimenes : Form
    {
        private static Regimenes instancia = null;

        public static Regimenes obtenerInstancia()
        {
            if( instancia == null)
            {
                instancia = new Regimenes();
            }
            return instancia;
        }

        private Regimenes()
        {
            InitializeComponent();
        }

        private void Regimenes_Load(object sender, EventArgs e)
        {

        }

        private void btnRegimenesSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.LoginMenu.obtenerInstancia().Show();
        }
    }
}
