using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    public class Usuario
    {
        private string NombreUsuario;
        private string Password;

        public string NombreDeUsuario
        {
            get => NombreUsuario;
            set => NombreUsuario = value;
        }

        public string Pass
        {
            get => Password;
            set => Password = value;
        }

        public Usuario(string nombre, string password)
        {
            this.NombreUsuario = nombre;
            this.Password = password;
        }

    }
}
