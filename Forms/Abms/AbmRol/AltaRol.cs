using System;
using FrbaHotel.Modelos;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;
using FrbaHotel.Utils;

namespace FrbaHotel.AbmRol
{
    public partial class AltaRol : ParentForm
    {
        private static AltaRol instancia = null;

        public static AltaRol obtenerInstancia()
        {
            if( instancia == null)
            {
                instancia = new AltaRol();
            }
            return instancia;
        }

        public void refrescar()
        {
            this.Controls["txtAltaRolNombre"].Text = "";
            this.chkAltaRolActivo.Checked = false;
            foreach(int index in this.chkListFuncionalidades.CheckedIndices)
            {
                this.chkListFuncionalidades.SetItemCheckState(index, CheckState.Unchecked);
            }
        }

        protected AltaRol()
        {
            InitializeComponent();
            this.cargarFuncionalidades();
            
        }

        private void cargarFuncionalidades()
        {
            foreach( Funcionalidad func in DBRol.obtenerFuncionalidades())
            {
                chkListFuncionalidades.Items.Add(func);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAltaRolCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Roles.obtenerInstancia().Show();
        }

        private void chkAltaRolFuncClientes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkListFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void agregarFuncionalidades(Rol rol)
        {
            CheckedItemCollection funcionalidades = chkListFuncionalidades.CheckedItems;
            foreach(Funcionalidad funcionalidad in funcionalidades)
            {
                rol.funcionalidades.Add(funcionalidad);
            }
        }

        private void btnAltaRolGuardar_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol(0, this.Controls["txtAltaRolNombre"].Text, this.chkAltaRolActivo.Checked);
            this.agregarFuncionalidades(rol);
            if( rol.guardar() == 1 )
            {
                MessageBox.Show("Rol guardado con exito!");
            }
            else
            {
                MessageBox.Show("Error al guardar el rol!");
            }
            this.Hide();
            Roles.refrescar();
            Roles.obtenerInstancia().Show();
        }

        private void txtAltaRolNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void chkAltaRolActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelAltaRolFuncionalidades_Click(object sender, EventArgs e)
        {

        }

        private void labelAltaRolNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
