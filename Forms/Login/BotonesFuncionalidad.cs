using FrbaHotel.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Forms.Login
{
    public abstract class BotonesFuncionalidad
    {
        public static int top = 5;

        public static Button obtenerBoton(Funcionalidad func)
        {
            Button boton = new Button();
            boton.Top = top;
            boton.Text = func.nombre;
            boton.Width += 3;
            boton.Width += 3;
            boton.Width += 3;
            top += boton.Height + 2;

            return boton;
        }
    }
}
