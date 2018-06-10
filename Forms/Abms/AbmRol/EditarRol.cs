using FrbaHotel.Modelos;
using FrbaHotel.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace FrbaHotel.AbmRol
{
    public partial class EditarRol : ParentForm
    {
        private static EditarRol instancia = null;

        public static EditarRol obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new EditarRol();
            }
            return instancia;
        }

        private EditarRol()
        {
            InitializeComponent();
            this.cargarFuncionalidades();
        }

        public void refrescar()
        {
            this.Controls["txtEditarRolNombre"].Text = "";
            ((CheckBox) this.Controls["chkEditarRolActivo"]).Checked = false;
            foreach (int i in chkListFuncionalidades.CheckedIndices)
            {
                chkListFuncionalidades.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void cargarFuncionalidades()
        {
            foreach (Funcionalidad func in DBRol.obtenerFuncionalidades())
            {
                chkListFuncionalidades.Items.Add(func);
            }
        }

        private void EditarRol_Load(object sender, EventArgs e)
        {

        }

        private void btnEditarRolCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Roles.refrescar();
        }

        private void agregarFuncionalidades(Rol rol)
        {
            CheckedItemCollection funcionalidades = chkListFuncionalidades.CheckedItems;
            foreach (Funcionalidad funcionalidad in funcionalidades)
            {
                rol.funcionalidades.Add(funcionalidad);
            }
        }

        private void btnEditarRolGuardar_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol(Convert.ToInt32(this.Controls["labelIdValue"].Text), 
                this.Controls["txtEditarRolNombre"].Text, 
                this.chkEditarRolActivo.Checked);
            this.agregarFuncionalidades(rol);

            if (rol.actualizar() == 1)
            {
                MessageBox.Show("Rol actualizado con exito!");
            }
            else
            {
                MessageBox.Show("Error al actualizar el rol!");
            }
            this.Hide();
            Roles.refrescar();
            Roles.obtenerInstancia().Show();
        }
    }
}
