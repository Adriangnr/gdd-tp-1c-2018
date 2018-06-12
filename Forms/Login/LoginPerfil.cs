using FrbaHotel.Modelos;
using System;
using System.Collections.Generic;

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

        public void agregarRoles(List<Rol> roles)
        {
            this.comboLoginPerfil.DataSource = roles;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelLoginPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginPerfilContinuar_Click(object sender, EventArgs e)
        {
            /*
             List<Funcionalidad> funcionalidades = DbLogin.obtenerFuncionalidadesPorRol();

             */
            this.Hide();
            FormsFactory.obtenerFormulario("LoginMenu").Show();
        }
    }
}
