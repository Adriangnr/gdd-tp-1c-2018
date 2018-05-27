using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.FormUtils
{
    public static class FormUtils
    {
        private static Form anterior { get; set; }
        private static Form actual { get; set; }

        public static void mostarForm(Form caller, Form called)
        {
            anterior = caller;
            actual = called;
            caller.Hide();
            called.Show();
        }

        public static void ocultarForm()
        {
            actual.Hide();
            anterior.Show();
        }
    }
}
