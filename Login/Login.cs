using System;
using System.Linq;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class Login : ParentForm
    {
        private DbLogin dbLogin = null;

        private static Login instancia = null;

        public static Login obtenerInstancia()
        {
            if( instancia == null)
            {
                instancia = new Login();
            }
            return instancia;
        }

        private Login()
        {
            this.dbLogin = new DbLogin();
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPerfil.obtenerInstancia().Show();
        }

        private void btnLoginCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrbaHotel.obtenerInstancia().Show();
        }

        public void validar() {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if( string.IsNullOrEmpty(tb.Text) )
                {
                    
                }
            }
        }
    }
}
