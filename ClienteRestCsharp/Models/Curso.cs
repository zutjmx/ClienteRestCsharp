using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteRestCsharp.Models
{
    class Curso
    {
        public string nombre { get; set; }
        public Curso(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
