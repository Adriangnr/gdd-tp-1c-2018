using System.Windows.Forms;

namespace FrbaHotel.ListadoEstadistico
{
    public partial class ListadoEstadistico : Form
    {
        private static ListadoEstadistico instancia = null;

        public static ListadoEstadistico obtenerInstancia()
        {
            if( instancia == null)
            {
                instancia = new ListadoEstadistico();
            }
            return instancia;
        }
        private ListadoEstadistico()
        {
            InitializeComponent();
        }

        private void btnListadoEstadisticoCancelar_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Login.LoginMenu.obtenerInstancia().Show();
        }
    }
}
