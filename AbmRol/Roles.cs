using System;
using FrbaHotel.Login;
using System.Windows.Forms;
using FrbaHotel.Modelos;

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
            instancia = null;
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
                this.showEditForm();
            }

            if (e.ColumnIndex == 4)
            {
                DialogResult borrar = MessageBox.Show("Realmente desea borrar el rol?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (borrar == DialogResult.OK)
                {
                    DataGridViewRow row = dataGridRoles.Rows[e.RowIndex];
                    Rol rol = new Rol((Int32)row.Cells[0].Value, (String)row.Cells[1].Value, (Boolean)row.Cells[2].Value);
                    if( rol.borrar() == 1)
                    {
                        MessageBox.Show("Rol eliminado con exito!");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el Rol.");
                    }
                    Roles.obtenerInstancia().Hide();
                    Roles.refrescar();
                    Roles.obtenerInstancia().Show();
                }
            }
        }

        private void btnAltaRolesCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMenu.obtenerInstancia().Show();
        }

        private void btnRolesCargar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaRol.obtenerInstancia().Show();
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
            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Editar";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Editar";
            dataGridRoles.Columns.Add(Editlink);
        }

        private void addDeleteColumn()
        {
            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Borrar";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Borrar";
            dataGridRoles.Columns.Add(Deletelink);
        }

        private void showEditForm()
        {
            EditarRol editarRolForm = EditarRol.obtenerInstancia();
            editarRolForm.Controls["txtAltaRolNombre"].Text = "Holaaa";
            this.Hide();
            editarRolForm.Show();
        }
    }
}
