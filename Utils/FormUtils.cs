using System;
using System.Security.Cryptography;
using System.Text;
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

        public static void cambiarFormulario(Form origen, String destino)
        {
            origen.Hide();
            FormsFactory.obtenerFormulario(destino).Show();
        }

        public static string generarSHA256(string inputString)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha256.ComputeHash(bytes);
            return obtenerStringDesdeHash(hash);
        }

        public static string obtenerStringDesdeHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }
    }
}
