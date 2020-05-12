namespace Capa_Presentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel_IniciarSesion = new System.Windows.Forms.Panel();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.lbl_InicioSesion = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contrasena = new System.Windows.Forms.Label();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_IniciarSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_IniciarSesion
            // 
            this.panel_IniciarSesion.Controls.Add(this.btn_Entrar);
            this.panel_IniciarSesion.Controls.Add(this.lbl_InicioSesion);
            this.panel_IniciarSesion.Controls.Add(this.lbl_usuario);
            this.panel_IniciarSesion.Controls.Add(this.lbl_contrasena);
            this.panel_IniciarSesion.Controls.Add(this.txt_contra);
            this.panel_IniciarSesion.Controls.Add(this.txt_usuario);
            this.panel_IniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_IniciarSesion.Location = new System.Drawing.Point(206, 189);
            this.panel_IniciarSesion.Name = "panel_IniciarSesion";
            this.panel_IniciarSesion.Size = new System.Drawing.Size(517, 248);
            this.panel_IniciarSesion.TabIndex = 1;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(102)))), ((int)(((byte)(87)))));
            this.btn_Entrar.FlatAppearance.BorderSize = 0;
            this.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrar.ForeColor = System.Drawing.Color.White;
            this.btn_Entrar.Location = new System.Drawing.Point(206, 200);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(118, 34);
            this.btn_Entrar.TabIndex = 5;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // lbl_InicioSesion
            // 
            this.lbl_InicioSesion.AutoSize = true;
            this.lbl_InicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InicioSesion.Location = new System.Drawing.Point(187, 9);
            this.lbl_InicioSesion.Name = "lbl_InicioSesion";
            this.lbl_InicioSesion.Size = new System.Drawing.Size(154, 29);
            this.lbl_InicioSesion.TabIndex = 2;
            this.lbl_InicioSesion.Text = "Iniciar sesión";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(142, 70);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(173, 24);
            this.lbl_usuario.TabIndex = 3;
            this.lbl_usuario.Text = "Nombre de usuario";
            // 
            // lbl_contrasena
            // 
            this.lbl_contrasena.AutoSize = true;
            this.lbl_contrasena.Location = new System.Drawing.Point(142, 129);
            this.lbl_contrasena.Name = "lbl_contrasena";
            this.lbl_contrasena.Size = new System.Drawing.Size(106, 24);
            this.lbl_contrasena.TabIndex = 4;
            this.lbl_contrasena.Text = "Contraseña";
            // 
            // txt_contra
            // 
            this.txt_contra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_contra.Location = new System.Drawing.Point(146, 156);
            this.txt_contra.MaxLength = 20;
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.PasswordChar = '*';
            this.txt_contra.Size = new System.Drawing.Size(238, 29);
            this.txt_contra.TabIndex = 1;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(146, 97);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(238, 29);
            this.txt_usuario.TabIndex = 0;
            // 
            // ptb_logo
            // 
            this.ptb_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptb_logo.Image = global::Capa_Presentacion.Properties.Resources.encabezado;
            this.ptb_logo.Location = new System.Drawing.Point(0, 0);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(884, 119);
            this.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_logo.TabIndex = 0;
            this.ptb_logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(162)))), ((int)(((byte)(110)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 544);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 17);
            this.panel1.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_IniciarSesion);
            this.Controls.Add(this.ptb_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.panel_IniciarSesion.ResumeLayout(false);
            this.panel_IniciarSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_logo;
        private System.Windows.Forms.Panel panel_IniciarSesion;
        private System.Windows.Forms.Label lbl_InicioSesion;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_contrasena;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Panel panel1;
    }
}

