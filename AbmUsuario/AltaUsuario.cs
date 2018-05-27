using FrbaHotel.Modelos;
using System;
using System.Windows.Forms;

namespace FrbaHotel.AbmUsuario
{
    public partial class AltaUsuario : Form
    {
        private DbUsuario dbUsuario;

        private static AltaUsuario instancia = null;

        public static AltaUsuario obtenerInstancia()
        {
            if( instancia == null)
            {
                instancia = new AltaUsuario();
            }
            return instancia;
        }

        private AltaUsuario()
        {
            InitializeComponent();
            this.dbUsuario = new DbUsuario();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnAltaUsuarioGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Username = txtAltaUsuarioUsername.Text;
            usuario.Password = txtAltaUsuarioContrasenia.Text;
            usuario.Habilitado = chckHabilitadoAltaUsuario.Checked;
            usuario.Intentos = 1;

            if (this.dbUsuario.guardarUsuario(usuario) > 0 )
            {
                MessageBox.Show("Usuario guardado con exito!");
            }
            else
            {
                MessageBox.Show("Error al guardar el usuario!");
            }
        }

        private void btnAltaUsuarioCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios.obtenerInstancia().Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
