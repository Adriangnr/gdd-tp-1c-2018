using System.Windows.Forms;

namespace FrbaHotel.Reservas
{
    public partial class Reservas : ParentForm
    {
        public Form caller { get; set; }

        private static Reservas instancia = null;

        public static Reservas obtenerInstancia()
        {
            if( instancia == null)
            {
                instancia = new Reservas();
            }
            return instancia;
        }

        private Reservas()
        {
            InitializeComponent();
        }

        private void btnReservasCancelar_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            this.caller.Show();
        }
    }
}
