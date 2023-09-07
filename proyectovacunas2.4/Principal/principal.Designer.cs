namespace proyectovacunas2._4
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            Salir = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panelsubmenucontable = new System.Windows.Forms.Panel();
            btnadministracion = new System.Windows.Forms.Button();
            btnproductos = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            btncontabilidad = new System.Windows.Forms.Button();
            panelsubmenuatencionmed = new System.Windows.Forms.Panel();
            btncitas = new System.Windows.Forms.Button();
            btnconsultas = new System.Windows.Forms.Button();
            btnrecetas = new System.Windows.Forms.Button();
            panelmenuatencion = new System.Windows.Forms.Panel();
            btnatencionmedica = new System.Windows.Forms.Button();
            panelsubmenu = new System.Windows.Forms.Panel();
            btnEmp = new System.Windows.Forms.Button();
            btnpacientes = new System.Windows.Forms.Button();
            btnpersonas = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblUsuarioLogeado = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panelsubmenucontable.SuspendLayout();
            panel3.SuspendLayout();
            panelsubmenuatencionmed.SuspendLayout();
            panelmenuatencion.SuspendLayout();
            panelsubmenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Salir
            // 
            Salir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            Salir.BackColor = System.Drawing.Color.CornflowerBlue;
            Salir.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            Salir.Location = new System.Drawing.Point(15, 681);
            Salir.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            Salir.Name = "Salir";
            Salir.Size = new System.Drawing.Size(188, 68);
            Salir.TabIndex = 2;
            Salir.Text = "Cerrar Sesion";
            Salir.UseVisualStyleBackColor = false;
            Salir.Click += Salir_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel1.BackColor = System.Drawing.Color.SteelBlue;
            panel1.Controls.Add(panelsubmenucontable);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panelsubmenuatencionmed);
            panel1.Controls.Add(panelmenuatencion);
            panel1.Controls.Add(panelsubmenu);
            panel1.Controls.Add(btnpersonas);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(933, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(505, 762);
            panel1.TabIndex = 6;
            // 
            // panelsubmenucontable
            // 
            panelsubmenucontable.Controls.Add(btnadministracion);
            panelsubmenucontable.Controls.Add(btnproductos);
            panelsubmenucontable.Dock = System.Windows.Forms.DockStyle.Top;
            panelsubmenucontable.Location = new System.Drawing.Point(0, 821);
            panelsubmenucontable.Name = "panelsubmenucontable";
            panelsubmenucontable.Size = new System.Drawing.Size(484, 118);
            panelsubmenucontable.TabIndex = 14;
            // 
            // btnadministracion
            // 
            btnadministracion.BackColor = System.Drawing.Color.CornflowerBlue;
            btnadministracion.Dock = System.Windows.Forms.DockStyle.Top;
            btnadministracion.FlatAppearance.BorderSize = 0;
            btnadministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnadministracion.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnadministracion.ForeColor = System.Drawing.Color.White;
            btnadministracion.Location = new System.Drawing.Point(0, 58);
            btnadministracion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            btnadministracion.Name = "btnadministracion";
            btnadministracion.Size = new System.Drawing.Size(484, 58);
            btnadministracion.TabIndex = 8;
            btnadministracion.Text = "Administración";
            btnadministracion.UseVisualStyleBackColor = false;
            btnadministracion.Click += btnadministracion_Click;
            // 
            // btnproductos
            // 
            btnproductos.BackColor = System.Drawing.Color.CornflowerBlue;
            btnproductos.Dock = System.Windows.Forms.DockStyle.Top;
            btnproductos.FlatAppearance.BorderSize = 0;
            btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnproductos.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnproductos.ForeColor = System.Drawing.Color.AliceBlue;
            btnproductos.Location = new System.Drawing.Point(0, 0);
            btnproductos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            btnproductos.Name = "btnproductos";
            btnproductos.Size = new System.Drawing.Size(484, 58);
            btnproductos.TabIndex = 2;
            btnproductos.Text = "Productos";
            btnproductos.UseVisualStyleBackColor = false;
            btnproductos.Click += btnJornadas_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            panel3.Controls.Add(btncontabilidad);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 761);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(484, 60);
            panel3.TabIndex = 13;
            // 
            // btncontabilidad
            // 
            btncontabilidad.BackColor = System.Drawing.Color.SteelBlue;
            btncontabilidad.Dock = System.Windows.Forms.DockStyle.Top;
            btncontabilidad.FlatAppearance.BorderSize = 0;
            btncontabilidad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btncontabilidad.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btncontabilidad.ForeColor = System.Drawing.Color.White;
            btncontabilidad.Location = new System.Drawing.Point(0, 0);
            btncontabilidad.Name = "btncontabilidad";
            btncontabilidad.Size = new System.Drawing.Size(484, 59);
            btncontabilidad.TabIndex = 13;
            btncontabilidad.Text = "Contabilidad";
            btncontabilidad.UseVisualStyleBackColor = false;
            btncontabilidad.Click += button1_Click_1;
            // 
            // panelsubmenuatencionmed
            // 
            panelsubmenuatencionmed.Controls.Add(btncitas);
            panelsubmenuatencionmed.Controls.Add(btnconsultas);
            panelsubmenuatencionmed.Controls.Add(btnrecetas);
            panelsubmenuatencionmed.Dock = System.Windows.Forms.DockStyle.Top;
            panelsubmenuatencionmed.Location = new System.Drawing.Point(0, 570);
            panelsubmenuatencionmed.Name = "panelsubmenuatencionmed";
            panelsubmenuatencionmed.Size = new System.Drawing.Size(484, 191);
            panelsubmenuatencionmed.TabIndex = 12;
            // 
            // btncitas
            // 
            btncitas.BackColor = System.Drawing.Color.CornflowerBlue;
            btncitas.Dock = System.Windows.Forms.DockStyle.Top;
            btncitas.FlatAppearance.BorderSize = 0;
            btncitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btncitas.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btncitas.ForeColor = System.Drawing.Color.White;
            btncitas.Location = new System.Drawing.Point(0, 123);
            btncitas.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            btncitas.Name = "btncitas";
            btncitas.Size = new System.Drawing.Size(484, 66);
            btncitas.TabIndex = 7;
            btncitas.Text = "Citas";
            btncitas.UseVisualStyleBackColor = false;
            btncitas.Click += btncitas_Click;
            // 
            // btnconsultas
            // 
            btnconsultas.BackColor = System.Drawing.Color.CornflowerBlue;
            btnconsultas.Dock = System.Windows.Forms.DockStyle.Top;
            btnconsultas.FlatAppearance.BorderSize = 0;
            btnconsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnconsultas.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnconsultas.ForeColor = System.Drawing.Color.White;
            btnconsultas.Location = new System.Drawing.Point(0, 58);
            btnconsultas.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            btnconsultas.Name = "btnconsultas";
            btnconsultas.Size = new System.Drawing.Size(484, 65);
            btnconsultas.TabIndex = 3;
            btnconsultas.Text = "Consultas";
            btnconsultas.UseVisualStyleBackColor = false;
            btnconsultas.Click += btnRegistro_Click;
            // 
            // btnrecetas
            // 
            btnrecetas.BackColor = System.Drawing.Color.CornflowerBlue;
            btnrecetas.Dock = System.Windows.Forms.DockStyle.Top;
            btnrecetas.FlatAppearance.BorderSize = 0;
            btnrecetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnrecetas.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnrecetas.ForeColor = System.Drawing.Color.AliceBlue;
            btnrecetas.Location = new System.Drawing.Point(0, 0);
            btnrecetas.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            btnrecetas.Name = "btnrecetas";
            btnrecetas.Size = new System.Drawing.Size(484, 58);
            btnrecetas.TabIndex = 5;
            btnrecetas.Text = "Recetas";
            btnrecetas.UseVisualStyleBackColor = false;
            btnrecetas.Click += btnAdminVac_Click;
            // 
            // panelmenuatencion
            // 
            panelmenuatencion.Controls.Add(btnatencionmedica);
            panelmenuatencion.Dock = System.Windows.Forms.DockStyle.Top;
            panelmenuatencion.Location = new System.Drawing.Point(0, 511);
            panelmenuatencion.Name = "panelmenuatencion";
            panelmenuatencion.Size = new System.Drawing.Size(484, 59);
            panelmenuatencion.TabIndex = 11;
            // 
            // btnatencionmedica
            // 
            btnatencionmedica.BackColor = System.Drawing.Color.SteelBlue;
            btnatencionmedica.Dock = System.Windows.Forms.DockStyle.Top;
            btnatencionmedica.FlatAppearance.BorderSize = 0;
            btnatencionmedica.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnatencionmedica.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnatencionmedica.ForeColor = System.Drawing.Color.White;
            btnatencionmedica.Location = new System.Drawing.Point(0, 0);
            btnatencionmedica.Name = "btnatencionmedica";
            btnatencionmedica.Size = new System.Drawing.Size(484, 59);
            btnatencionmedica.TabIndex = 12;
            btnatencionmedica.Text = "Atención Médica";
            btnatencionmedica.UseVisualStyleBackColor = false;
            btnatencionmedica.Click += btn_Click;
            // 
            // panelsubmenu
            // 
            panelsubmenu.Controls.Add(btnEmp);
            panelsubmenu.Controls.Add(btnpacientes);
            panelsubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            panelsubmenu.Location = new System.Drawing.Point(0, 400);
            panelsubmenu.Margin = new System.Windows.Forms.Padding(4);
            panelsubmenu.Name = "panelsubmenu";
            panelsubmenu.Size = new System.Drawing.Size(484, 111);
            panelsubmenu.TabIndex = 10;
            // 
            // btnEmp
            // 
            btnEmp.BackColor = System.Drawing.Color.CornflowerBlue;
            btnEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnEmp.Dock = System.Windows.Forms.DockStyle.Top;
            btnEmp.FlatAppearance.BorderSize = 0;
            btnEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEmp.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEmp.ForeColor = System.Drawing.Color.AliceBlue;
            btnEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnEmp.Location = new System.Drawing.Point(0, 58);
            btnEmp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            btnEmp.Name = "btnEmp";
            btnEmp.Size = new System.Drawing.Size(484, 58);
            btnEmp.TabIndex = 0;
            btnEmp.Text = "Empleados";
            btnEmp.UseVisualStyleBackColor = false;
            btnEmp.Click += btnEmp_Click;
            // 
            // btnpacientes
            // 
            btnpacientes.BackColor = System.Drawing.Color.CornflowerBlue;
            btnpacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnpacientes.Dock = System.Windows.Forms.DockStyle.Top;
            btnpacientes.FlatAppearance.BorderSize = 0;
            btnpacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnpacientes.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnpacientes.ForeColor = System.Drawing.Color.AliceBlue;
            btnpacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnpacientes.ImageKey = "(ninguna)";
            btnpacientes.Location = new System.Drawing.Point(0, 0);
            btnpacientes.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            btnpacientes.Name = "btnpacientes";
            btnpacientes.Size = new System.Drawing.Size(484, 58);
            btnpacientes.TabIndex = 1;
            btnpacientes.Text = "Pacientes";
            btnpacientes.UseVisualStyleBackColor = false;
            btnpacientes.Click += btnReporte_Click;
            // 
            // btnpersonas
            // 
            btnpersonas.BackColor = System.Drawing.Color.SteelBlue;
            btnpersonas.Dock = System.Windows.Forms.DockStyle.Top;
            btnpersonas.FlatAppearance.BorderSize = 0;
            btnpersonas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnpersonas.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnpersonas.ForeColor = System.Drawing.Color.White;
            btnpersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnpersonas.Location = new System.Drawing.Point(0, 344);
            btnpersonas.Margin = new System.Windows.Forms.Padding(4);
            btnpersonas.Name = "btnpersonas";
            btnpersonas.Size = new System.Drawing.Size(484, 56);
            btnpersonas.TabIndex = 0;
            btnpersonas.Text = "Personas";
            btnpersonas.UseVisualStyleBackColor = false;
            btnpersonas.Click += btndespleagar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(484, 344);
            panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = Properties.Resources.Imagen__25_;
            pictureBox1.Location = new System.Drawing.Point(117, 54);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(270, 258);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblUsuarioLogeado
            // 
            lblUsuarioLogeado.AutoSize = true;
            lblUsuarioLogeado.BackColor = System.Drawing.Color.Transparent;
            lblUsuarioLogeado.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblUsuarioLogeado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblUsuarioLogeado.Location = new System.Drawing.Point(12, 11);
            lblUsuarioLogeado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblUsuarioLogeado.Name = "lblUsuarioLogeado";
            lblUsuarioLogeado.Size = new System.Drawing.Size(0, 31);
            lblUsuarioLogeado.TabIndex = 7;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.SteelBlue;
            BackgroundImage = Properties.Resources.principal__3_;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1438, 762);
            Controls.Add(lblUsuarioLogeado);
            Controls.Add(panel1);
            Controls.Add(Salir);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            Name = "frmPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SISTEMA DE VACUNACION";
            Load += frmPrincipal_Load;
            panel1.ResumeLayout(false);
            panelsubmenucontable.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelsubmenuatencionmed.ResumeLayout(false);
            panelmenuatencion.ResumeLayout(false);
            panelsubmenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campañasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masSobreNosotrosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnrecetas;
        private System.Windows.Forms.Button btnconsultas;
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.Button btnpacientes;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnadministracion;
        private System.Windows.Forms.Button btncitas;
        private System.Windows.Forms.Label lblUsuarioLogeado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelsubmenu;
        private System.Windows.Forms.Button btnpersonas;
        private System.Windows.Forms.Panel panelsubmenuatencionmed;
        private System.Windows.Forms.Panel panelmenuatencion;
        private System.Windows.Forms.Button btnatencionmedica;
        private System.Windows.Forms.Panel panelsubmenucontable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btncontabilidad;
    }
}
