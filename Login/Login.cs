using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class Login : Form
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
            LoginPerfil loginPerfil = LoginPerfil.obtenerInstancia();
            loginPerfil.Show();
            
            this.Hide();
        }

        private void btnLoginCancelar_Click(object sender, EventArgs e)
        {
            FrbaHotel.obtenerInstancia().Show();
            this.Hide();
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
