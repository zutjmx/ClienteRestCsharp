using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteRestCsharp.Models
{
    class Usuario
    {
        //public int id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public Usuario(int id, string nombre, string email, string password)
        {
            //this.id = id;
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
