using System;
using System.Collections.Generic;
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

        public void refrescar()
        {
            this.txtLoginPassword.Text = "";
            this.txtLoginUsuario.Text = "";
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
                this.seleccionarPerfil(usuario);
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
        
        private void seleccionarPerfil(Usuario usuario)
        {
            List<Rol> roles = DbLogin.obtenerRolesDeUsuario(usuario);
            if( roles.Count > 1)
            {
                this.Hide();
                LoginPerfil loginPerfil = (LoginPerfil)FormsFactory.obtenerFormulario("LoginPerfil");
                loginPerfil.agregarRoles(roles);
                loginPerfil.Show();
            }
            else
            {
                if( roles.Count == 1)
                {
                    this.Hide();
                    FormsFactory.obtenerFormulario("LoginMenu");
                }
                else
                {
                    MessageBox.Show("Error: No tiene roles asignados.");
                }
            }
            
            
        }
    }
}
