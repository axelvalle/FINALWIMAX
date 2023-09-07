namespace proyectovacunas2._4.Reportes
{
    partial class ReporteEmpleado
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteEmpleado));
            logo = new System.Windows.Forms.PictureBox();
            lblwimax = new System.Windows.Forms.Label();
            lbldireccion = new System.Windows.Forms.Label();
            lbltelf = new System.Windows.Forms.Label();
            lblfecha = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            dtEmpleado = new System.Windows.Forms.DataGridView();
            EMPLEADO_CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ID_AREA_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ID_CARGO_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FECHA_REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ACTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnactualizar = new System.Windows.Forms.Button();
            btnpdf = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtEmpleado).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = Properties.Resources.Imagen__25_;
            logo.Location = new System.Drawing.Point(2, 6);
            logo.Name = "logo";
            logo.Size = new System.Drawing.Size(180, 169);
            logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // lblwimax
            // 
            lblwimax.AutoSize = true;
            lblwimax.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblwimax.Location = new System.Drawing.Point(236, 9);
            lblwimax.Name = "lblwimax";
            lblwimax.Size = new System.Drawing.Size(594, 62);
            lblwimax.TabIndex = 1;
            lblwimax.Text = "WIMAX CENTRO MEDICO";
            // 
            // lbldireccion
            // 
            lbldireccion.AutoSize = true;
            lbldireccion.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbldireccion.Location = new System.Drawing.Point(236, 71);
            lbldireccion.Name = "lbldireccion";
            lbldireccion.Size = new System.Drawing.Size(580, 25);
            lbldireccion.TabIndex = 2;
            lbldireccion.Text = "Dirección: Av. Universitaria, frente a la Academia de Danza Nicaragüense";
            lbldireccion.Click += lbldireccion_Click;
            // 
            // lbltelf
            // 
            lbltelf.AutoSize = true;
            lbltelf.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbltelf.Location = new System.Drawing.Point(400, 96);
            lbltelf.Name = "lbltelf";
            lbltelf.Size = new System.Drawing.Size(222, 25);
            lbltelf.TabIndex = 3;
            lbltelf.Text = "Teléfono: +505 2250-6845";
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblfecha.Location = new System.Drawing.Point(836, 46);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new System.Drawing.Size(115, 25);
            lblfecha.TabIndex = 4;
            lblfecha.Text = "Fecha y Hora";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(262, 134);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(523, 62);
            label1.TabIndex = 5;
            label1.Text = "REPORTE EMPLEADOS";
            // 
            // dtEmpleado
            // 
            dtEmpleado.AllowUserToAddRows = false;
            dtEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { EMPLEADO_CEDULA, ID_AREA_EMPLEADO, ID_CARGO_EMPLEADO, FECHA_REGISTRO, ACTIVO, USUARIO });
            dtEmpleado.Location = new System.Drawing.Point(113, 230);
            dtEmpleado.Name = "dtEmpleado";
            dtEmpleado.RowHeadersWidth = 51;
            dtEmpleado.RowTemplate.Height = 29;
            dtEmpleado.Size = new System.Drawing.Size(804, 323);
            dtEmpleado.TabIndex = 6;
            dtEmpleado.CellContentClick += dtEmpleado_CellContentClick;
            // 
            // EMPLEADO_CEDULA
            // 
            EMPLEADO_CEDULA.HeaderText = "CEDULA DEL EMPLEADO";
            EMPLEADO_CEDULA.MinimumWidth = 6;
            EMPLEADO_CEDULA.Name = "EMPLEADO_CEDULA";
            EMPLEADO_CEDULA.Width = 125;
            // 
            // ID_AREA_EMPLEADO
            // 
            ID_AREA_EMPLEADO.HeaderText = "ID AREA ";
            ID_AREA_EMPLEADO.MinimumWidth = 6;
            ID_AREA_EMPLEADO.Name = "ID_AREA_EMPLEADO";
            ID_AREA_EMPLEADO.Width = 125;
            // 
            // ID_CARGO_EMPLEADO
            // 
            ID_CARGO_EMPLEADO.HeaderText = "ID CARGO";
            ID_CARGO_EMPLEADO.MinimumWidth = 6;
            ID_CARGO_EMPLEADO.Name = "ID_CARGO_EMPLEADO";
            ID_CARGO_EMPLEADO.Width = 125;
            // 
            // FECHA_REGISTRO
            // 
            FECHA_REGISTRO.HeaderText = "FECHA DE REGISTRO";
            FECHA_REGISTRO.MinimumWidth = 6;
            FECHA_REGISTRO.Name = "FECHA_REGISTRO";
            FECHA_REGISTRO.Width = 125;
            // 
            // ACTIVO
            // 
            ACTIVO.HeaderText = "ACTIVO";
            ACTIVO.MinimumWidth = 6;
            ACTIVO.Name = "ACTIVO";
            ACTIVO.Width = 125;
            // 
            // USUARIO
            // 
            USUARIO.HeaderText = "USUARIO";
            USUARIO.MinimumWidth = 6;
            USUARIO.Name = "USUARIO";
            USUARIO.Width = 125;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new System.Drawing.Point(113, 585);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new System.Drawing.Size(225, 29);
            btnactualizar.TabIndex = 7;
            btnactualizar.Text = "Exportar a Excel";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btnpdf
            // 
            btnpdf.Location = new System.Drawing.Point(692, 585);
            btnpdf.Name = "btnpdf";
            btnpdf.Size = new System.Drawing.Size(225, 29);
            btnpdf.TabIndex = 8;
            btnpdf.Text = "Generar Archivo PDF";
            btnpdf.UseVisualStyleBackColor = true;
            btnpdf.Click += btnpdf_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // ReporteEmpleado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1037, 643);
            Controls.Add(btnpdf);
            Controls.Add(btnactualizar);
            Controls.Add(dtEmpleado);
            Controls.Add(label1);
            Controls.Add(lblfecha);
            Controls.Add(lbltelf);
            Controls.Add(lbldireccion);
            Controls.Add(lblwimax);
            Controls.Add(logo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ReporteEmpleado";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += ReporteEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblwimax;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lbltelf;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtEmpleado;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLEADO_CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_AREA_EMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CARGO_EMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_REGISTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.Timer timer1;
    }
}