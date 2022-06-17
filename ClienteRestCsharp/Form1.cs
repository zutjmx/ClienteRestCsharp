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
using System.Configuration;
using Newtonsoft.Json;

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
            string urlUsuarios = ConfigurationManager.AppSettings["urlUsuarios"];
            Cursor.Current = Cursors.WaitCursor;
            UsuarioServicio usuarioServicio = new UsuarioServicio();
            string respuesta = usuarioServicio.GetUsuarios(urlUsuarios, "/");
            Console.WriteLine(respuesta);
            txtUsuarios.Text = respuesta;
            Cursor.Current = Cursors.Default;
        }

        private void btnGenera20Usuarios_Click(object sender, EventArgs e)
        {
            string txtAux = "";            
            string urlUsuarios = ConfigurationManager.AppSettings["urlUsuarios"];

            Cursor.Current = Cursors.WaitCursor;
            for (int i=0; i<=20; i++)
            {
                var name = Faker.Name.FullName();
                var email = Faker.Internet.Email();
                var password = Faker.RandomNumber.Next().ToString();
                Usuario usuario = new Usuario(name,email,password);
                UsuarioServicio usuarioServicio = new UsuarioServicio();
                string respuesta = usuarioServicio.PutUsuario(urlUsuarios, "/", usuario);
                txtAux = txtAux + respuesta + ",";
            }
            Cursor.Current = Cursors.Default;

            txt20Usuarios.Text = "[" + txtAux + "]";
        }

        private void btnGenera20Cursos_Click(object sender, EventArgs e)
        {
            string txtAux = "";
            string urlCursos = ConfigurationManager.AppSettings["urlCursos"];

            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i <= 20; i++)
            {
                var name = Faker.Company.Name();
                Curso curso = new Curso(name);
                UsuarioServicio usuarioServicio = new UsuarioServicio();
                string respuesta = usuarioServicio.PutCurso(urlCursos, "/", curso);
                txtAux = txtAux + respuesta + ",";
            }
            Cursor.Current = Cursors.Default;

            txt20Cursos.Text = "[" + txtAux + "]";
        }

        private void btnGeneraDatosFake_Click(object sender, EventArgs e)
        {
            var name = Faker.Name.FullName();
            var email = Faker.Internet.Email();
            var password = Faker.RandomNumber.Next().ToString();
            txtNombre.Text = name;
            txtEmail.Text = email;
            txtPassword.Text = password;
        }

        private void btnGuardaUsuario_Click(object sender, EventArgs e)
        {
            string urlUsuarios = ConfigurationManager.AppSettings["urlUsuarios"];
            Cursor.Current = Cursors.WaitCursor;
            UsuarioServicio usuarioServicio = new UsuarioServicio();
            Usuario usuario = new Usuario(txtNombre.Text, txtEmail.Text, txtPassword.Text);
            string respuesta = usuarioServicio.PutUsuario(urlUsuarios,"/", usuario);
            Console.WriteLine(respuesta);
            txtResultado.Text = respuesta;
            Cursor.Current = Cursors.Default;
        }

        private void btnGenaraUsuarioFakeJson_Click(object sender, EventArgs e)
        {
            var name = Faker.Name.FullName();
            var email = Faker.Internet.Email();
            var password = Faker.RandomNumber.Next().ToString();
            Usuario usuario = new Usuario(name,email,password);
            string json = JsonConvert.SerializeObject(usuario);
            txtUsuarioJson.Text = json;
        }

        private void btnGeneraJsonCursoFake_Click(object sender, EventArgs e)
        {
            string nombreCurso = Faker.Company.Name();
            Curso curso = new Curso(nombreCurso);
            string json = JsonConvert.SerializeObject(curso);
            txtUsuarioJson.Text = json;
        }
    }
}
