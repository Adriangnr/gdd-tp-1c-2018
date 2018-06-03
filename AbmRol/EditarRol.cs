using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRol
{
    public partial class EditarRol : AltaRol
    {
        private static EditarRol instancia = null;

        public new static EditarRol obtenerInstancia()
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

        }

        private void EditarRol_Load(object sender, EventArgs e)
        {

        }
    }
}
