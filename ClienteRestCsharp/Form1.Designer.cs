
namespace ClienteRestCsharp
{
    partial class ClienteRespCsharp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetUsuarios = new System.Windows.Forms.Button();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.txt20Usuarios = new System.Windows.Forms.TextBox();
            this.btnGenera20Usuarios = new System.Windows.Forms.Button();
            this.txt20Cursos = new System.Windows.Forms.TextBox();
            this.btnGenera20Cursos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardaUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnGeneraDatosFake = new System.Windows.Forms.Button();
            this.btnGenaraUsuarioFakeJson = new System.Windows.Forms.Button();
            this.txtUsuarioJson = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetUsuarios
            // 
            this.btnGetUsuarios.Location = new System.Drawing.Point(12, 30);
            this.btnGetUsuarios.Name = "btnGetUsuarios";
            this.btnGetUsuarios.Size = new System.Drawing.Size(112, 55);
            this.btnGetUsuarios.TabIndex = 0;
            this.btnGetUsuarios.Text = "Get Usuarios";
            this.btnGetUsuarios.UseVisualStyleBackColor = true;
            this.btnGetUsuarios.Click += new System.EventHandler(this.btnGetUsuarios_Click);
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.Location = new System.Drawing.Point(130, 30);
            this.txtUsuarios.Multiline = true;
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUsuarios.Size = new System.Drawing.Size(646, 55);
            this.txtUsuarios.TabIndex = 1;
            // 
            // txt20Usuarios
            // 
            this.txt20Usuarios.Location = new System.Drawing.Point(130, 91);
            this.txt20Usuarios.Multiline = true;
            this.txt20Usuarios.Name = "txt20Usuarios";
            this.txt20Usuarios.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt20Usuarios.Size = new System.Drawing.Size(646, 55);
            this.txt20Usuarios.TabIndex = 3;
            // 
            // btnGenera20Usuarios
            // 
            this.btnGenera20Usuarios.Location = new System.Drawing.Point(12, 91);
            this.btnGenera20Usuarios.Name = "btnGenera20Usuarios";
            this.btnGenera20Usuarios.Size = new System.Drawing.Size(112, 55);
            this.btnGenera20Usuarios.TabIndex = 2;
            this.btnGenera20Usuarios.Text = "Genera 20 Usuarios";
            this.btnGenera20Usuarios.UseVisualStyleBackColor = true;
            this.btnGenera20Usuarios.Click += new System.EventHandler(this.btnGenera20Usuarios_Click);
            // 
            // txt20Cursos
            // 
            this.txt20Cursos.Location = new System.Drawing.Point(130, 152);
            this.txt20Cursos.Multiline = true;
            this.txt20Cursos.Name = "txt20Cursos";
            this.txt20Cursos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt20Cursos.Size = new System.Drawing.Size(646, 55);
            this.txt20Cursos.TabIndex = 5;
            // 
            // btnGenera20Cursos
            // 
            this.btnGenera20Cursos.Location = new System.Drawing.Point(12, 152);
            this.btnGenera20Cursos.Name = "btnGenera20Cursos";
            this.btnGenera20Cursos.Size = new System.Drawing.Size(112, 55);
            this.btnGenera20Cursos.TabIndex = 4;
            this.btnGenera20Cursos.Text = "Genera 20 Cursos";
            this.btnGenera20Cursos.UseVisualStyleBackColor = true;
            this.btnGenera20Cursos.Click += new System.EventHandler(this.btnGenera20Cursos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGeneraDatosFake);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.txtResultado);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGuardaUsuario);
            this.panel1.Location = new System.Drawing.Point(12, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 261);
            this.panel1.TabIndex = 7;
            // 
            // btnGuardaUsuario
            // 
            this.btnGuardaUsuario.Location = new System.Drawing.Point(15, 192);
            this.btnGuardaUsuario.Name = "btnGuardaUsuario";
            this.btnGuardaUsuario.Size = new System.Drawing.Size(112, 55);
            this.btnGuardaUsuario.TabIndex = 7;
            this.btnGuardaUsuario.Text = "Guarda Usuario";
            this.btnGuardaUsuario.UseVisualStyleBackColor = true;
            this.btnGuardaUsuario.Click += new System.EventHandler(this.btnGuardaUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(221, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(111, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(221, 22);
            this.txtPassword.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(111, 66);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(15, 164);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(317, 22);
            this.txtResultado.TabIndex = 14;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 144);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(76, 17);
            this.lblResultado.TabIndex = 15;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnGeneraDatosFake
            // 
            this.btnGeneraDatosFake.Location = new System.Drawing.Point(220, 192);
            this.btnGeneraDatosFake.Name = "btnGeneraDatosFake";
            this.btnGeneraDatosFake.Size = new System.Drawing.Size(112, 55);
            this.btnGeneraDatosFake.TabIndex = 16;
            this.btnGeneraDatosFake.Text = "Genera datos Fake";
            this.btnGeneraDatosFake.UseVisualStyleBackColor = true;
            this.btnGeneraDatosFake.Click += new System.EventHandler(this.btnGeneraDatosFake_Click);
            // 
            // btnGenaraUsuarioFakeJson
            // 
            this.btnGenaraUsuarioFakeJson.Location = new System.Drawing.Point(397, 247);
            this.btnGenaraUsuarioFakeJson.Name = "btnGenaraUsuarioFakeJson";
            this.btnGenaraUsuarioFakeJson.Size = new System.Drawing.Size(112, 55);
            this.btnGenaraUsuarioFakeJson.TabIndex = 17;
            this.btnGenaraUsuarioFakeJson.Text = "Genera Json Usuario Fake";
            this.btnGenaraUsuarioFakeJson.UseVisualStyleBackColor = true;
            this.btnGenaraUsuarioFakeJson.Click += new System.EventHandler(this.btnGenaraUsuarioFakeJson_Click);
            // 
            // txtUsuarioJson
            // 
            this.txtUsuarioJson.Location = new System.Drawing.Point(397, 313);
            this.txtUsuarioJson.Multiline = true;
            this.txtUsuarioJson.Name = "txtUsuarioJson";
            this.txtUsuarioJson.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUsuarioJson.Size = new System.Drawing.Size(112, 195);
            this.txtUsuarioJson.TabIndex = 18;
            // 
            // ClienteRespCsharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.txtUsuarioJson);
            this.Controls.Add(this.btnGenaraUsuarioFakeJson);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt20Cursos);
            this.Controls.Add(this.btnGenera20Cursos);
            this.Controls.Add(this.txt20Usuarios);
            this.Controls.Add(this.btnGenera20Usuarios);
            this.Controls.Add(this.txtUsuarios);
            this.Controls.Add(this.btnGetUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClienteRespCsharp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteRespCsharp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetUsuarios;
        private System.Windows.Forms.TextBox txtUsuarios;
        private System.Windows.Forms.TextBox txt20Usuarios;
        private System.Windows.Forms.Button btnGenera20Usuarios;
        private System.Windows.Forms.TextBox txt20Cursos;
        private System.Windows.Forms.Button btnGenera20Cursos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardaUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnGeneraDatosFake;
        private System.Windows.Forms.Button btnGenaraUsuarioFakeJson;
        private System.Windows.Forms.TextBox txtUsuarioJson;
    }
}

