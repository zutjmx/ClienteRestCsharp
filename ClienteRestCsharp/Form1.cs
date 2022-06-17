using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteRestCsharp.Services;
using ClienteRestCsharp.Models;

namespace ClienteRestCsharp
{
    public partial class ClienteRespCsharp : Form
    {
        public ClienteRespCsharp()
        {
            InitializeComponent();
        }

        private void btnGetUsuarios_Click(object sender, EventArgs e)
        {
            UsuarioServicio usuarioServicio = new UsuarioServicio();
            string respuesta = usuarioServicio.GetUsuarios("http://localhost:8001","/");
            Console.WriteLine(respuesta);
            txtUsuarios.Text = respuesta;
        }

        private void btnGenera20Usuarios_Click(object sender, EventArgs e)
        {
            for(int i=0; i<=20; i++)
            {
                var name = Faker.Name.FullName();
                var email = Faker.Internet.Email();
                var password = Faker.RandomNumber.Next().ToString();
                Usuario usuario = new Usuario(0,name,email,password);
                UsuarioServicio usuarioServicio = new UsuarioServicio();
                string respuesta = usuarioServicio.PutUsuario("http://localhost:8001", "/", usuario);
            }
        }

        private void btnGenera20Cursos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 20; i++)
            {
                var name = Faker.Company.Name();
                Curso curso = new Curso(name);
                UsuarioServicio usuarioServicio = new UsuarioServicio();
                string respuesta = usuarioServicio.PutCurso("http://localhost:8002", "/", curso);
            }
        }
    }
}
