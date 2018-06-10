using System;
using System.Linq;
using System.Windows.Forms;
using FrbaHotel.Modelos;
using FrbaHotel.Validador;

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
            Usuario usuario = new Usuario();
            usuario.Username = txtLoginUsuario.Text;
            usuario.Password = txtLoginPassword.Text;
            if ( Validador.Validador.validar(usuario) )
            {
                this.Hide();
                FormsFactory.obtenerFormulario("LoginPerfil").Show();
            }
            else
            {
                MessageBox.Show("Error. Verifique los datos ingresados");
            }
            
        }

        private void btnLoginCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormsFactory.obtenerFormulario("FrbaHotel").Show();
            
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
