using FrbaHotel.Modelos;
using System;
using FrbaHotel.Login;

namespace FrbaHotel.Validador
{
    public static class Validador
    {
        public static Boolean validar(FrbaModel modelo)
        {
            switch (modelo.GetType().ToString())
            {
                case "FrbaHotel.Modelos.Usuario":
                    return validarUsuario((Usuario)modelo);

                default: return false;            
            }
        }

        private static Boolean validarUsuario(Usuario usuario)
        {
            return DbLogin.existeUsuario(usuario);
        }
    }
}
