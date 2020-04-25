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
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_central = new System.Windows.Forms.Panel();
            this.iconbtn_paciente = new FontAwesome.Sharp.IconButton();
            this.iconbtn_estudios = new FontAwesome.Sharp.IconButton();
            this.iconbtn_reportes = new FontAwesome.Sharp.IconButton();
            this.iconbtn_inicio = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_MenuLateral.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_MenuLateral
            // 
            this.panel_MenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(137)))), ((int)(((byte)(155)))));
            this.panel_MenuLateral.Controls.Add(this.iconbtn_paciente);
            this.panel_MenuLateral.Controls.Add(this.iconbtn_estudios);
            this.panel_MenuLateral.Controls.Add(this.iconbtn_reportes);
            this.panel_MenuLateral.Controls.Add(this.iconbtn_inicio);
            this.panel_MenuLateral.Controls.Add(this.panel_logo);
            this.panel_MenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_MenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panel_MenuLateral.Name = "panel_MenuLateral";
            this.panel_MenuLateral.Size = new System.Drawing.Size(255, 761);
            this.panel_MenuLateral.TabIndex = 0;
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(137)))), ((int)(((byte)(155)))));
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(255, 127);
            this.panel_logo.TabIndex = 0;
            // 
            // panel_central
            // 
            this.panel_central.BackColor = System.Drawing.SystemColors.Control;
            this.panel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_central.Location = new System.Drawing.Point(255, 0);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(1229, 761);
            this.panel_central.TabIndex = 1;
            // 
            // iconbtn_paciente
            // 
            this.iconbtn_paciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtn_paciente.FlatAppearance.BorderSize = 0;
            this.iconbtn_paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtn_paciente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtn_paciente.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.iconbtn_paciente.IconColor = System.Drawing.Color.White;
            this.iconbtn_paciente.IconSize = 30;
            this.iconbtn_paciente.Location = new System.Drawing.Point(0, 277);
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
            this.iconbtn_estudios.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtn_estudios.FlatAppearance.BorderSize = 0;
            this.iconbtn_estudios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtn_estudios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtn_estudios.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.iconbtn_estudios.IconColor = System.Drawing.Color.White;
            this.iconbtn_estudios.IconSize = 30;
            this.iconbtn_estudios.Location = new System.Drawing.Point(0, 227);
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
            this.iconbtn_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtn_reportes.FlatAppearance.BorderSize = 0;
            this.iconbtn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtn_reportes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtn_reportes.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.iconbtn_reportes.IconColor = System.Drawing.Color.White;
            this.iconbtn_reportes.IconSize = 30;
            this.iconbtn_reportes.Location = new System.Drawing.Point(0, 177);
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
            this.iconbtn_inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtn_inicio.FlatAppearance.BorderSize = 0;
            this.iconbtn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtn_inicio.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtn_inicio.IconChar = FontAwesome.Sharp.IconChar.ClinicMedical;
            this.iconbtn_inicio.IconColor = System.Drawing.Color.White;
            this.iconbtn_inicio.IconSize = 30;
            this.iconbtn_inicio.Location = new System.Drawing.Point(0, 127);
            this.iconbtn_inicio.Name = "iconbtn_inicio";
            this.iconbtn_inicio.Rotation = 0D;
            this.iconbtn_inicio.Size = new System.Drawing.Size(255, 50);
            this.iconbtn_inicio.TabIndex = 0;
            this.iconbtn_inicio.Text = "Inicio";
            this.iconbtn_inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtn_inicio.UseVisualStyleBackColor = true;
            this.iconbtn_inicio.Click += new System.EventHandler(this.iconbtn_inicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Presentacion.Properties.Resources.logo_imss;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_MenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_MenuLateral.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_MenuLateral;
        private System.Windows.Forms.Panel panel_central;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconbtn_inicio;
        private FontAwesome.Sharp.IconButton iconbtn_paciente;
        private FontAwesome.Sharp.IconButton iconbtn_estudios;
        private FontAwesome.Sharp.IconButton iconbtn_reportes;
    }
}