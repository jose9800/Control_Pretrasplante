namespace Capa_Presentacion
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel_MenuLateral = new System.Windows.Forms.Panel();
            this.submenu_paciente = new System.Windows.Forms.Panel();
            this.nuevo_paciente = new System.Windows.Forms.Button();
            this.lista_paciente = new System.Windows.Forms.Button();
            this.iconbtn_paciente = new FontAwesome.Sharp.IconButton();
            this.iconbtn_estudios = new FontAwesome.Sharp.IconButton();
            this.iconbtn_reportes = new FontAwesome.Sharp.IconButton();
            this.iconbtn_inicio = new FontAwesome.Sharp.IconButton();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.panel_central = new System.Windows.Forms.Panel();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.pnl_superior = new System.Windows.Forms.Panel();
            this.pnl_liston = new System.Windows.Forms.Panel();
            this.btn_CerrarTodo = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.panel_MenuLateral.SuspendLayout();
            this.submenu_paciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.pnl_superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_MenuLateral
            // 
            this.panel_MenuLateral.AutoScroll = true;
            this.panel_MenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(102)))), ((int)(((byte)(87)))));
            this.panel_MenuLateral.Controls.Add(this.submenu_paciente);
            this.panel_MenuLateral.Controls.Add(this.ptb_logo);
            this.panel_MenuLateral.Controls.Add(this.iconbtn_paciente);
            this.panel_MenuLateral.Controls.Add(this.btn_CerrarSesion);
            this.panel_MenuLateral.Controls.Add(this.iconbtn_estudios);
            this.panel_MenuLateral.Controls.Add(this.iconbtn_reportes);
            this.panel_MenuLateral.Controls.Add(this.iconbtn_inicio);
            this.panel_MenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panel_MenuLateral.Name = "panel_MenuLateral";
            this.panel_MenuLateral.Size = new System.Drawing.Size(255, 799);
            this.panel_MenuLateral.TabIndex = 0;
            // 
            // submenu_paciente
            // 
            this.submenu_paciente.Controls.Add(this.nuevo_paciente);
            this.submenu_paciente.Controls.Add(this.lista_paciente);
            this.submenu_paciente.Location = new System.Drawing.Point(2, 384);
            this.submenu_paciente.Margin = new System.Windows.Forms.Padding(2);
            this.submenu_paciente.Name = "submenu_paciente";
            this.submenu_paciente.Size = new System.Drawing.Size(250, 81);
            this.submenu_paciente.TabIndex = 0;
            this.submenu_paciente.Visible = false;
            // 
            // nuevo_paciente
            // 
            this.nuevo_paciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.nuevo_paciente.FlatAppearance.BorderSize = 0;
            this.nuevo_paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevo_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nuevo_paciente.Location = new System.Drawing.Point(0, 37);
            this.nuevo_paciente.Margin = new System.Windows.Forms.Padding(2);
            this.nuevo_paciente.Name = "nuevo_paciente";
            this.nuevo_paciente.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.nuevo_paciente.Size = new System.Drawing.Size(250, 37);
            this.nuevo_paciente.TabIndex = 1;
            this.nuevo_paciente.Text = "Nuevo Paciente +";
            this.nuevo_paciente.UseVisualStyleBackColor = true;
            this.nuevo_paciente.Click += new System.EventHandler(this.nuevo_paciente_Click);
            // 
            // lista_paciente
            // 
            this.lista_paciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lista_paciente.FlatAppearance.BorderSize = 0;
            this.lista_paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lista_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lista_paciente.Location = new System.Drawing.Point(0, 0);
            this.lista_paciente.Margin = new System.Windows.Forms.Padding(2);
            this.lista_paciente.Name = "lista_paciente";
            this.lista_paciente.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.lista_paciente.Size = new System.Drawing.Size(250, 37);
            this.lista_paciente.TabIndex = 0;
            this.lista_paciente.Text = "Lista de Pacientes";
            this.lista_paciente.UseVisualStyleBackColor = true;
            this.lista_paciente.Click += new System.EventHandler(this.lista_paciente_Click);
            // 
            // iconbtn_paciente
            // 
            this.iconbtn_paciente.FlatAppearance.BorderSize = 0;
            this.iconbtn_paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtn_paciente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtn_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtn_paciente.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.iconbtn_paciente.IconColor = System.Drawing.Color.White;
            this.iconbtn_paciente.IconSize = 30;
            this.iconbtn_paciente.Location = new System.Drawing.Point(0, 338);
            this.iconbtn_paciente.Name = "iconbtn_paciente";
            this.iconbtn_paciente.Rotation = 0D;
            this.iconbtn_paciente.Size = new System.Drawing.Size(255, 50);
            this.iconbtn_paciente.TabIndex = 3;
            this.iconbtn_paciente.Text = "Paciente";
            this.iconbtn_paciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtn_paciente.UseVisualStyleBackColor = true;
            this.iconbtn_paciente.Click += new System.EventHandler(this.iconbtn_paciente_Click);
            // 
            // iconbtn_estudios
            // 
            this.iconbtn_estudios.FlatAppearance.BorderSize = 0;
            this.iconbtn_estudios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtn_estudios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtn_estudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtn_estudios.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.iconbtn_estudios.IconColor = System.Drawing.Color.White;
            this.iconbtn_estudios.IconSize = 30;
            this.iconbtn_estudios.Location = new System.Drawing.Point(0, 170);
            this.iconbtn_estudios.Name = "iconbtn_estudios";
            this.iconbtn_estudios.Rotation = 0D;
            this.iconbtn_estudios.Size = new System.Drawing.Size(255, 50);
            this.iconbtn_estudios.TabIndex = 2;
            this.iconbtn_estudios.Text = "Estudios";
            this.iconbtn_estudios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtn_estudios.UseVisualStyleBackColor = true;
            this.iconbtn_estudios.Click += new System.EventHandler(this.iconbtn_estudios_Click);
            // 
            // iconbtn_reportes
            // 
            this.iconbtn_reportes.FlatAppearance.BorderSize = 0;
            this.iconbtn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtn_reportes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtn_reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtn_reportes.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.iconbtn_reportes.IconColor = System.Drawing.Color.White;
            this.iconbtn_reportes.IconSize = 30;
            this.iconbtn_reportes.Location = new System.Drawing.Point(0, 226);
            this.iconbtn_reportes.Name = "iconbtn_reportes";
            this.iconbtn_reportes.Rotation = 0D;
            this.iconbtn_reportes.Size = new System.Drawing.Size(255, 50);
            this.iconbtn_reportes.TabIndex = 1;
            this.iconbtn_reportes.Text = "Reportes";
            this.iconbtn_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtn_reportes.UseVisualStyleBackColor = true;
            this.iconbtn_reportes.Click += new System.EventHandler(this.iconbtn_reportes_Click);
            // 
            // iconbtn_inicio
            // 
            this.iconbtn_inicio.FlatAppearance.BorderSize = 0;
            this.iconbtn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtn_inicio.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtn_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtn_inicio.IconChar = FontAwesome.Sharp.IconChar.ClinicMedical;
            this.iconbtn_inicio.IconColor = System.Drawing.Color.White;
            this.iconbtn_inicio.IconSize = 30;
            this.iconbtn_inicio.Location = new System.Drawing.Point(0, 282);
            this.iconbtn_inicio.Name = "iconbtn_inicio";
            this.iconbtn_inicio.Rotation = 0D;
            this.iconbtn_inicio.Size = new System.Drawing.Size(255, 50);
            this.iconbtn_inicio.TabIndex = 0;
            this.iconbtn_inicio.Text = "Inicio";
            this.iconbtn_inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtn_inicio.UseVisualStyleBackColor = true;
            this.iconbtn_inicio.Click += new System.EventHandler(this.iconbtn_inicio_Click);
            // 
            // ptb_logo
            // 
            this.ptb_logo.BackColor = System.Drawing.Color.Transparent;
            this.ptb_logo.Image = global::Capa_Presentacion.Properties.Resources.logo_imss;
            this.ptb_logo.Location = new System.Drawing.Point(3, 44);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(249, 120);
            this.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_logo.TabIndex = 0;
            this.ptb_logo.TabStop = false;
            // 
            // panel_central
            // 
            this.panel_central.AutoScroll = true;
            this.panel_central.BackColor = System.Drawing.SystemColors.Control;
            this.panel_central.Location = new System.Drawing.Point(258, 55);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(1230, 732);
            this.panel_central.TabIndex = 1;
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_CerrarSesion.FlatAppearance.BorderSize = 0;
            this.btn_CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btn_CerrarSesion.Location = new System.Drawing.Point(0, 738);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(255, 61);
            this.btn_CerrarSesion.TabIndex = 0;
            this.btn_CerrarSesion.Text = "Cerrar sesión";
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // pnl_superior
            // 
            this.pnl_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(102)))), ((int)(((byte)(87)))));
            this.pnl_superior.Controls.Add(this.btn_minimizar);
            this.pnl_superior.Controls.Add(this.btn_CerrarTodo);
            this.pnl_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_superior.Name = "pnl_superior";
            this.pnl_superior.Size = new System.Drawing.Size(1500, 38);
            this.pnl_superior.TabIndex = 2;
            // 
            // pnl_liston
            // 
            this.pnl_liston.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(162)))), ((int)(((byte)(110)))));
            this.pnl_liston.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_liston.Location = new System.Drawing.Point(0, 38);
            this.pnl_liston.Name = "pnl_liston";
            this.pnl_liston.Size = new System.Drawing.Size(1500, 11);
            this.pnl_liston.TabIndex = 3;
            // 
            // btn_CerrarTodo
            // 
            this.btn_CerrarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CerrarTodo.FlatAppearance.BorderSize = 0;
            this.btn_CerrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CerrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CerrarTodo.ForeColor = System.Drawing.Color.White;
            this.btn_CerrarTodo.Location = new System.Drawing.Point(1462, 0);
            this.btn_CerrarTodo.Name = "btn_CerrarTodo";
            this.btn_CerrarTodo.Size = new System.Drawing.Size(35, 35);
            this.btn_CerrarTodo.TabIndex = 0;
            this.btn_CerrarTodo.Text = "X";
            this.btn_CerrarTodo.UseVisualStyleBackColor = true;
            this.btn_CerrarTodo.Click += new System.EventHandler(this.btn_CerrarTodo_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizar.ForeColor = System.Drawing.Color.White;
            this.btn_minimizar.Location = new System.Drawing.Point(1421, 0);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(35, 35);
            this.btn_minimizar.TabIndex = 1;
            this.btn_minimizar.Text = "__";
            this.btn_minimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1500, 799);
            this.Controls.Add(this.pnl_liston);
            this.Controls.Add(this.pnl_superior);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_MenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 799);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_MenuLateral.ResumeLayout(false);
            this.submenu_paciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.pnl_superior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_MenuLateral;
        private System.Windows.Forms.Panel panel_central;
        private System.Windows.Forms.PictureBox ptb_logo;
        private FontAwesome.Sharp.IconButton iconbtn_inicio;
        private FontAwesome.Sharp.IconButton iconbtn_paciente;
        private FontAwesome.Sharp.IconButton iconbtn_estudios;
        private FontAwesome.Sharp.IconButton iconbtn_reportes;
        private System.Windows.Forms.Panel submenu_paciente;
        private System.Windows.Forms.Button nuevo_paciente;
        private System.Windows.Forms.Button lista_paciente;
        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.Panel pnl_superior;
        private System.Windows.Forms.Panel pnl_liston;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_CerrarTodo;
    }
}