
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGenera20Usuarios = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGenera20Cursos = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(646, 55);
            this.textBox1.TabIndex = 3;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 152);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(646, 55);
            this.textBox2.TabIndex = 5;
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
            // ClienteRespCsharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnGenera20Cursos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGenera20Usuarios);
            this.Controls.Add(this.txtUsuarios);
            this.Controls.Add(this.btnGetUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClienteRespCsharp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteRespCsharp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetUsuarios;
        private System.Windows.Forms.TextBox txtUsuarios;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGenera20Usuarios;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnGenera20Cursos;
    }
}

