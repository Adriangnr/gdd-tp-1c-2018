using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Utils
{
    public static class FormUtils
    {
        public static DataGridViewLinkColumn generarBotonDataGrid
            (Boolean linkValue, String headerText, String nombreProperty, LinkBehavior comportamiento, String texto)
        {
            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.UseColumnTextForLinkValue = linkValue;
            link.HeaderText = headerText;
            link.DataPropertyName = nombreProperty;
            link.LinkBehavior = comportamiento;
            link.Text = texto;

            return link;
        }
    }
}
