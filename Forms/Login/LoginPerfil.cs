using System;

namespace FrbaHotel.Login
{
    public partial class LoginPerfil : ParentForm
    {
        private static LoginPerfil instancia = null;

        public static LoginPerfil obtenerInstancia()
        {
            if( instancia == null)
            {
                instancia = new LoginPerfil();
            }
            return instancia;
        }

        private LoginPerfil()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelLoginPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginPerfilContinuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormsFactory.obtenerFormulario("LoginMenu").Show();
        }
    }
}
