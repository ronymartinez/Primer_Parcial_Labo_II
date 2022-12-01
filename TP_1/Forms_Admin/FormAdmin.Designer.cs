namespace TP_1
{
    partial class form_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_crearUsuario = new System.Windows.Forms.Button();
            this.btn_crearMateria = new System.Windows.Forms.Button();
            this.btn_verUsuarios = new System.Windows.Forms.Button();
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.lbl_pregunta = new System.Windows.Forms.Label();
            this.btn_verMaterias = new System.Windows.Forms.Button();
            this.btn_gestionarAlumnos = new System.Windows.Forms.Button();
            this.btn_gestionarProfesores = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_inscribir = new System.Windows.Forms.Button();
            this.btn_estadisticas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_crearUsuario
            // 
            this.btn_crearUsuario.BackColor = System.Drawing.Color.DarkRed;
            this.btn_crearUsuario.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_crearUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_crearUsuario.Location = new System.Drawing.Point(412, 26);
            this.btn_crearUsuario.Name = "btn_crearUsuario";
            this.btn_crearUsuario.Size = new System.Drawing.Size(150, 78);
            this.btn_crearUsuario.TabIndex = 0;
            this.btn_crearUsuario.Text = "Crear Usuario";
            this.btn_crearUsuario.UseVisualStyleBackColor = false;
            this.btn_crearUsuario.Click += new System.EventHandler(this.btn_crearUsuario_Click);
            // 
            // btn_crearMateria
            // 
            this.btn_crearMateria.BackColor = System.Drawing.Color.DarkRed;
            this.btn_crearMateria.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_crearMateria.ForeColor = System.Drawing.Color.White;
            this.btn_crearMateria.Location = new System.Drawing.Point(411, 147);
            this.btn_crearMateria.Name = "btn_crearMateria";
            this.btn_crearMateria.Size = new System.Drawing.Size(150, 78);
            this.btn_crearMateria.TabIndex = 0;
            this.btn_crearMateria.Text = "Crear Materia";
            this.btn_crearMateria.UseVisualStyleBackColor = false;
            this.btn_crearMateria.Click += new System.EventHandler(this.btn_crearMateria_Click);
            // 
            // btn_verUsuarios
            // 
            this.btn_verUsuarios.BackColor = System.Drawing.Color.DarkRed;
            this.btn_verUsuarios.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_verUsuarios.ForeColor = System.Drawing.Color.White;
            this.btn_verUsuarios.Location = new System.Drawing.Point(604, 26);
            this.btn_verUsuarios.Name = "btn_verUsuarios";
            this.btn_verUsuarios.Size = new System.Drawing.Size(150, 78);
            this.btn_verUsuarios.TabIndex = 0;
            this.btn_verUsuarios.Text = "Ver lista de usuarios";
            this.btn_verUsuarios.UseVisualStyleBackColor = false;
            this.btn_verUsuarios.Click += new System.EventHandler(this.btn_verUsuarios_Click);
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.AutoSize = true;
            this.lbl_bienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bienvenida.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_bienvenida.ForeColor = System.Drawing.Color.White;
            this.lbl_bienvenida.Location = new System.Drawing.Point(27, 54);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(243, 35);
            this.lbl_bienvenida.TabIndex = 1;
            this.lbl_bienvenida.Text = "¡Hola, Nombre!";
            // 
            // lbl_pregunta
            // 
            this.lbl_pregunta.AutoSize = true;
            this.lbl_pregunta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pregunta.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pregunta.ForeColor = System.Drawing.Color.White;
            this.lbl_pregunta.Location = new System.Drawing.Point(27, 266);
            this.lbl_pregunta.Name = "lbl_pregunta";
            this.lbl_pregunta.Size = new System.Drawing.Size(256, 26);
            this.lbl_pregunta.TabIndex = 2;
            this.lbl_pregunta.Text = "¿Qué deseas realizar?";
            // 
            // btn_verMaterias
            // 
            this.btn_verMaterias.BackColor = System.Drawing.Color.DarkRed;
            this.btn_verMaterias.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_verMaterias.ForeColor = System.Drawing.Color.White;
            this.btn_verMaterias.Location = new System.Drawing.Point(603, 147);
            this.btn_verMaterias.Name = "btn_verMaterias";
            this.btn_verMaterias.Size = new System.Drawing.Size(150, 78);
            this.btn_verMaterias.TabIndex = 3;
            this.btn_verMaterias.Text = "Ver lista de materias";
            this.btn_verMaterias.UseVisualStyleBackColor = false;
            this.btn_verMaterias.Click += new System.EventHandler(this.btn_verMaterias_Click);
            // 
            // btn_gestionarAlumnos
            // 
            this.btn_gestionarAlumnos.BackColor = System.Drawing.Color.DarkRed;
            this.btn_gestionarAlumnos.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_gestionarAlumnos.ForeColor = System.Drawing.Color.White;
            this.btn_gestionarAlumnos.Location = new System.Drawing.Point(412, 264);
            this.btn_gestionarAlumnos.Name = "btn_gestionarAlumnos";
            this.btn_gestionarAlumnos.Size = new System.Drawing.Size(150, 78);
            this.btn_gestionarAlumnos.TabIndex = 4;
            this.btn_gestionarAlumnos.Text = "Gestionar Alumnos";
            this.btn_gestionarAlumnos.UseVisualStyleBackColor = false;
            this.btn_gestionarAlumnos.Click += new System.EventHandler(this.btn_gestionarAlumnos_Click);
            // 
            // btn_gestionarProfesores
            // 
            this.btn_gestionarProfesores.BackColor = System.Drawing.Color.DarkRed;
            this.btn_gestionarProfesores.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_gestionarProfesores.ForeColor = System.Drawing.Color.White;
            this.btn_gestionarProfesores.Location = new System.Drawing.Point(604, 267);
            this.btn_gestionarProfesores.Name = "btn_gestionarProfesores";
            this.btn_gestionarProfesores.Size = new System.Drawing.Size(150, 75);
            this.btn_gestionarProfesores.TabIndex = 5;
            this.btn_gestionarProfesores.Text = "Gestionar Profesores";
            this.btn_gestionarProfesores.UseVisualStyleBackColor = false;
            this.btn_gestionarProfesores.Click += new System.EventHandler(this.btn_gestionarProfesores_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_salir.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(85, 384);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(151, 71);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_inscribir
            // 
            this.btn_inscribir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_inscribir.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_inscribir.ForeColor = System.Drawing.Color.White;
            this.btn_inscribir.Location = new System.Drawing.Point(602, 384);
            this.btn_inscribir.Name = "btn_inscribir";
            this.btn_inscribir.Size = new System.Drawing.Size(151, 78);
            this.btn_inscribir.TabIndex = 6;
            this.btn_inscribir.Text = "Inscribir a Materias";
            this.btn_inscribir.UseVisualStyleBackColor = false;
            this.btn_inscribir.Click += new System.EventHandler(this.btn_inscribir_Click);
            // 
            // btn_estadisticas
            // 
            this.btn_estadisticas.BackColor = System.Drawing.Color.DarkRed;
            this.btn_estadisticas.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_estadisticas.ForeColor = System.Drawing.Color.White;
            this.btn_estadisticas.Location = new System.Drawing.Point(410, 384);
            this.btn_estadisticas.Name = "btn_estadisticas";
            this.btn_estadisticas.Size = new System.Drawing.Size(151, 78);
            this.btn_estadisticas.TabIndex = 6;
            this.btn_estadisticas.Text = "Estadísticas";
            this.btn_estadisticas.UseVisualStyleBackColor = false;
            this.btn_estadisticas.Click += new System.EventHandler(this.btn_estadisticas_Click);
            // 
            // form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP_1.Properties.Resources.fondo_admin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 495);
            this.Controls.Add(this.btn_estadisticas);
            this.Controls.Add(this.btn_inscribir);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_gestionarProfesores);
            this.Controls.Add(this.btn_gestionarAlumnos);
            this.Controls.Add(this.btn_verMaterias);
            this.Controls.Add(this.lbl_pregunta);
            this.Controls.Add(this.lbl_bienvenida);
            this.Controls.Add(this.btn_verUsuarios);
            this.Controls.Add(this.btn_crearMateria);
            this.Controls.Add(this.btn_crearUsuario);
            this.Name = "form_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_Admin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crearUsuario;
        private System.Windows.Forms.Button btn_crearMateria;
        private System.Windows.Forms.Button btn_verUsuarios;
        private System.Windows.Forms.Label lbl_bienvenida;
        private System.Windows.Forms.Label lbl_pregunta;
        private System.Windows.Forms.Button btn_verMaterias;
        private System.Windows.Forms.Button btn_gestionarAlumnos;
        private System.Windows.Forms.Button btn_gestionarProfesores;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_inscribir;
        private System.Windows.Forms.Button btn_estadisticas;
    }
}