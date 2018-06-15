using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrbaHotel.Forms.Login;
using FrbaHotel.Modelos;
using FrbaHotel.Utils;

namespace FrbaHotel.Login
{
    public partial class LoginMenu : Form
    {
        private static LoginMenu instancia = null;

        public object SystemParameters { get; }

        public static LoginMenu obtenerInstancia()
        {
            if( instancia == null)
            {
                instancia = new LoginMenu();
            }
            return instancia;
        }

        public void agregarFuncionalidades(List<Funcionalidad> funcionalidades)
        {
            Panel panelFuncionalidades = new Panel();
            panelFuncionalidades.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            
            panelFuncionalidades.Top = 5;
            panelFuncionalidades.Left = 5;
           
            foreach (Funcionalidad f in funcionalidades)
            {
                panelFuncionalidades.Controls.Add(BotonesFuncionalidad.obtenerBoton(f));
            }
            this.Controls.Add(panelFuncionalidades);
            Button boton = BotonesFuncionalidad.obtenerBoton(new Funcionalidad(0, "Salir"));
                boton.Click += obtenerEventHandler("Salir");
            this.Controls.Add(boton);
            this.Refresh();
        }

        private LoginMenu()
        {
            this.Height = 0;
            this.Width = 0;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            InitializeComponent();
        }

        private void btnLoginMenuSalir_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this.Hide();
            Login login = (Login) FormsFactory.obtenerFormulario("Login");
            login.refrescar();
            login.Show();
        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUtils.cambiarFormulario(this, "Usuarios");
        }

        private void btnLoginMenuClientes_Click(object sender, EventArgs e)
        {
            FormUtils.cambiarFormulario(this, "Clientes");
        }

        private void btnLoginMenuRoles_Click(object sender, EventArgs e)
        {
            FormUtils.cambiarFormulario(this, "Roles");
        }

        private void btnLoginMenuHoteles_Click(object sender, EventArgs e)
        {
            FormUtils.cambiarFormulario(this, "Hoteles");
        }

        private void btnLoginMenuRegimenes_Click(object sender, EventArgs e)
        {
            FormUtils.cambiarFormulario(this, "Regimenes");
        }

        private void btnLoginMenuReservas_Click(object sender, EventArgs e)
        {
            /*
             El formulario de reservas, no utiliza el FormUtils, ya que se puede acceder a el, siendo cliente
             o usuario del sistema, y se necesita saber a donde volver al salir.
             */
            this.Hide();
            Reservas.Reservas.obtenerInstancia().caller = this;
            Reservas.Reservas.obtenerInstancia().Show();
        }

        private void btnLoginMenuHabitaciones_Click(object sender, EventArgs e)
        {
            FormUtils.cambiarFormulario(this, "Habitaciones");
        }

        private void btnLoginMenuEstadisticas_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListadoEstadistico.ListadoEstadistico.obtenerInstancia().Show();
        }

        private EventHandler obtenerEventHandler(String nombre)
        {
            switch (nombre)
            {
                case "Salir":
                    return new EventHandler(salirClick);
            }
            return null;
        }

        private void salirClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this.Hide();
            Login login = (Login)FormsFactory.obtenerFormulario("Login");
            login.refrescar();
            login.Show();
        }
    }
}
