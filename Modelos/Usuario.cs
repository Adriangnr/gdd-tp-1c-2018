using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Modelos
{
    public class Usuario : FrbaModel
    {
        private int id;
        private string username;
        private string password;
        private bool habilitado;
        private byte intentos;

        public int Id
        {
            get { return id; }
        }

        public byte Intentos
        {
            get { return intentos; }
            set { intentos = value; }
        }

        public bool Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }


        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

    }
}
