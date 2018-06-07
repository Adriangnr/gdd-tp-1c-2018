using System;
using FrbaHotel.Login;
using System.Windows.Forms;
using FrbaHotel.Modelos;
using FrbaHotel.Utils;

namespace FrbaHotel.AbmRol
{
    public partial class Roles : ParentForm
    {
        private static Roles instancia = null;

        public static Roles obtenerInstancia()
        {
            if( instancia == null)
            {
                instancia = new Roles();
            }

            return instancia;
        }

        public static void refrescar()
        {
            obtenerInstancia().Hide();
            instancia = null;
            obtenerInstancia().Show();
        }

        private Roles()
        {
            InitializeComponent();
            this.configureDataGrid();
        }

        private void dataGridRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                this.showEditForm(e);
            }

            if (e.ColumnIndex == 4)
            {
                this.borrarRol(e);
            }
        }

        private Rol obtenerRolSeleccionado(DataGridViewRow row)
        {
           return new Rol((Int32)row.Cells[0].Value, (String)row.Cells[1].Value, (Boolean)row.Cells[2].Value);
        }

        private void borrarRol(DataGridViewCellEventArgs e)
        {
            DialogResult borrar = MessageBox.Show("Realmente desea borrar el rol?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (borrar == DialogResult.OK)
            {
                DataGridViewRow row = dataGridRoles.Rows[e.RowIndex];
                Rol rol = this.obtenerRolSeleccionado(row);
                if (rol.borrar() == 1)
                {
                    MessageBox.Show("Rol eliminado con exito!");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el Rol.");
                }
                
                refrescar();
            }
        }

        private void btnAltaRolesCancelar_Click(object sender, EventArgs e)
        {
            FormUtils.cambiarFormulario(this, "LoginMenu");
        }

        private void btnRolesCargar_Click(object sender, EventArgs e)
        {
            FormUtils.cambiarFormulario(this, "AltaRol");
            AltaRol.obtenerInstancia().refrescar();
        }

        private void configureDataGrid()
        {
            dataGridRoles.DataSource = DBRol.buscarRoles();
            dataGridRoles.Columns[0].Visible = false;
            dataGridRoles.Columns[1].HeaderText = "Nombre";
            dataGridRoles.Columns[2].HeaderText = "Activo";
            dataGridRoles.AutoGenerateColumns = false;
            this.addEditColumn();
            this.addDeleteColumn();
        }

        private void addEditColumn()
        {
            dataGridRoles.Columns.Add(FormUtils.generarBotonDataGrid(true, "", "dgRolesEditLink", LinkBehavior.SystemDefault, "Editar"));
        }

        private void addDeleteColumn()
        {
            dataGridRoles.Columns.Add(FormUtils.generarBotonDataGrid(true, "", "dgRolesDeleteLink", LinkBehavior.SystemDefault, "Borrar"));
        }

        private void showEditForm(DataGridViewCellEventArgs e)
        {
            this.Hide();
            this.prepareEditForm(dataGridRoles.Rows[e.RowIndex]).Show();
        }

        private Rol obtenerRolDeFila(DataGridViewRow row)
        {
            Rol rol = new Rol(Convert.ToInt32(row.Cells[0].Value), (String)row.Cells[1].Value, (Boolean)row.Cells[2].Value);
            rol.funcionalidades = DBRol.obtenerFuncionalidadesPorRol(rol.id);
            return rol;
        }

        private EditarRol prepareEditForm(DataGridViewRow row)
        {
            Rol rol = this.obtenerRolDeFila(row);
            EditarRol editarRolForm = EditarRol.obtenerInstancia();
            editarRolForm.Controls["txtAltaRolNombre"].Text = rol.nombre;
            ((CheckBox)editarRolForm.Controls["chkAltaRolActivo"]).Checked = rol.estado;

            foreach (Funcionalidad func in rol.funcionalidades)
            {
                for(int index = 0; index <= ((CheckedListBox)editarRolForm.Controls["chkListFuncionalidades"]).Items.Count; index++)
                {
                    Funcionalidad itemFunc = (Funcionalidad)((CheckedListBox)editarRolForm.Controls["chkListFuncionalidades"]).Items[index];
                    if( itemFunc.id == func.id)
                    {
                        ((CheckedListBox)editarRolForm.Controls["chkListFuncionalidades"]).SetItemChecked(index, true);
                        break;
                    }
                }
            }

            return editarRolForm;
        }
    }
}
