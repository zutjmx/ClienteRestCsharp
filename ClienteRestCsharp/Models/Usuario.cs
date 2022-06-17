using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteRestCsharp.Models
{
    class Usuario
    {
        public string nombre { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public Usuario(string nombre, string email, string password)
        {
            this.nombre = nombre;
            this.email = email;
            this.password = password;
        }

        public override string ToString()
        {
            //return "Usuario {" + this.password + "," + this.nombre + "," + this.email + "," + this.id + "}";
            return "Usuario {" + this.password + "," + this.nombre + "," + this.email + "}";
        }
        
    }
}
