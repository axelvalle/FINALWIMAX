namespace proyectovacunas2._4.Reportes
{
    partial class ReporteConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteConsulta));
            btnpdf = new System.Windows.Forms.Button();
            btnactualizar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            lblfecha = new System.Windows.Forms.Label();
            lbltelf = new System.Windows.Forms.Label();
            lbldireccion = new System.Windows.Forms.Label();
            lblwimax = new System.Windows.Forms.Label();
            logo = new System.Windows.Forms.PictureBox();
            dtConsulta = new System.Windows.Forms.DataGridView();
            ID_CONSULTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EMPLEADO_CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CEDULA_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            REGISTRO_CONSULTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DIADNOSTICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PRESION_SANGUINEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OXIGENO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FRECUENCIA_CARDIACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TEMPERATURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PULSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HIPOTIROIDISMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtConsulta).BeginInit();
            SuspendLayout();
            // 
            // btnpdf
            // 
            btnpdf.Location = new System.Drawing.Point(835, 659);
            btnpdf.Name = "btnpdf";
            btnpdf.Size = new System.Drawing.Size(225, 29);
            btnpdf.TabIndex = 17;
            btnpdf.Text = "Generar Archivo PDF";
            btnpdf.UseVisualStyleBackColor = true;
            btnpdf.Click += btnpdf_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new System.Drawing.Point(110, 659);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new System.Drawing.Size(225, 29);
            btnactualizar.TabIndex = 16;
            btnactualizar.Text = "Exportar a Excel";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(342, 180);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(510, 62);
            label1.TabIndex = 14;
            label1.Text = "REPORTE CONSULTAS";
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblfecha.Location = new System.Drawing.Point(945, 68);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new System.Drawing.Size(115, 25);
            lblfecha.TabIndex = 13;
            lblfecha.Text = "Fecha y Hora";
            // 
            // lbltelf
            // 
            lbltelf.AutoSize = true;
            lbltelf.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbltelf.Location = new System.Drawing.Point(482, 125);
            lbltelf.Name = "lbltelf";
            lbltelf.Size = new System.Drawing.Size(222, 25);
            lbltelf.TabIndex = 12;
            lbltelf.Text = "Teléfono: +505 2250-6845";
            // 
            // lbldireccion
            // 
            lbldireccion.AutoSize = true;
            lbldireccion.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbldireccion.Location = new System.Drawing.Point(303, 100);
            lbldireccion.Name = "lbldireccion";
            lbldireccion.Size = new System.Drawing.Size(580, 25);
            lbldireccion.TabIndex = 11;
            lbldireccion.Text = "Dirección: Av. Universitaria, frente a la Academia de Danza Nicaragüense";
            // 
            // lblwimax
            // 
            lblwimax.AutoSize = true;
            lblwimax.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblwimax.Location = new System.Drawing.Point(303, 38);
            lblwimax.Name = "lblwimax";
            lblwimax.Size = new System.Drawing.Size(594, 62);
            lblwimax.TabIndex = 10;
            lblwimax.Text = "WIMAX CENTRO MEDICO";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.Imagen__25_;
            logo.Location = new System.Drawing.Point(27, 4);
            logo.Name = "logo";
            logo.Size = new System.Drawing.Size(218, 208);
            logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 9;
            logo.TabStop = false;
            // 
            // dtConsulta
            // 
            dtConsulta.AllowUserToAddRows = false;
            dtConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_CONSULTA, EMPLEADO_CEDULA, CEDULA_PACIENTE, REGISTRO_CONSULTA, DIADNOSTICO, PRESION_SANGUINEA, OXIGENO, FRECUENCIA_CARDIACA, PESO, TEMPERATURA, PULSO, HIPOTIROIDISMO });
            dtConsulta.Location = new System.Drawing.Point(110, 271);
            dtConsulta.Name = "dtConsulta";
            dtConsulta.RowHeadersWidth = 51;
            dtConsulta.RowTemplate.Height = 29;
            dtConsulta.Size = new System.Drawing.Size(950, 375);
            dtConsulta.TabIndex = 18;
            // 
            // ID_CONSULTA
            // 
            ID_CONSULTA.HeaderText = "ID CONSULTA";
            ID_CONSULTA.MinimumWidth = 6;
            ID_CONSULTA.Name = "ID_CONSULTA";
            ID_CONSULTA.Width = 125;
            // 
            // EMPLEADO_CEDULA
            // 
            EMPLEADO_CEDULA.HeaderText = "CEDULA EMPLEADO";
            EMPLEADO_CEDULA.MinimumWidth = 6;
            EMPLEADO_CEDULA.Name = "EMPLEADO_CEDULA";
            EMPLEADO_CEDULA.Width = 125;
            // 
            // CEDULA_PACIENTE
            // 
            CEDULA_PACIENTE.HeaderText = "CEDULA PACIENTE";
            CEDULA_PACIENTE.MinimumWidth = 6;
            CEDULA_PACIENTE.Name = "CEDULA_PACIENTE";
            CEDULA_PACIENTE.Width = 125;
            // 
            // REGISTRO_CONSULTA
            // 
            REGISTRO_CONSULTA.HeaderText = "REGISTRO CONSULTA";
            REGISTRO_CONSULTA.MinimumWidth = 6;
            REGISTRO_CONSULTA.Name = "REGISTRO_CONSULTA";
            REGISTRO_CONSULTA.Width = 125;
            // 
            // DIADNOSTICO
            // 
            DIADNOSTICO.HeaderText = "DIAGNOSTICO";
            DIADNOSTICO.MinimumWidth = 6;
            DIADNOSTICO.Name = "DIADNOSTICO";
            DIADNOSTICO.Width = 125;
            // 
            // PRESION_SANGUINEA
            // 
            PRESION_SANGUINEA.HeaderText = "PRESION SANGUINEA";
            PRESION_SANGUINEA.MinimumWidth = 6;
            PRESION_SANGUINEA.Name = "PRESION_SANGUINEA";
            PRESION_SANGUINEA.Width = 125;
            // 
            // OXIGENO
            // 
            OXIGENO.HeaderText = "OXIGENO";
            OXIGENO.MinimumWidth = 6;
            OXIGENO.Name = "OXIGENO";
            OXIGENO.Width = 125;
            // 
            // FRECUENCIA_CARDIACA
            // 
            FRECUENCIA_CARDIACA.HeaderText = "FRECUENCIA CARDIACA";
            FRECUENCIA_CARDIACA.MinimumWidth = 6;
            FRECUENCIA_CARDIACA.Name = "FRECUENCIA_CARDIACA";
            FRECUENCIA_CARDIACA.Width = 125;
            // 
            // PESO
            // 
            PESO.HeaderText = "PESO";
            PESO.MinimumWidth = 6;
            PESO.Name = "PESO";
            PESO.Width = 125;
            // 
            // TEMPERATURA
            // 
            TEMPERATURA.HeaderText = "TEMPERATURA";
            TEMPERATURA.MinimumWidth = 6;
            TEMPERATURA.Name = "TEMPERATURA";
            TEMPERATURA.Width = 125;
            // 
            // PULSO
            // 
            PULSO.HeaderText = "PULSO";
            PULSO.MinimumWidth = 6;
            PULSO.Name = "PULSO";
            PULSO.Width = 125;
            // 
            // HIPOTIROIDISMO
            // 
            HIPOTIROIDISMO.HeaderText = "HIPOTIROIDISMO";
            HIPOTIROIDISMO.MinimumWidth = 6;
            HIPOTIROIDISMO.Name = "HIPOTIROIDISMO";
            HIPOTIROIDISMO.Width = 125;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // ReporteConsulta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1085, 700);
            Controls.Add(dtConsulta);
            Controls.Add(btnpdf);
            Controls.Add(btnactualizar);
            Controls.Add(label1);
            Controls.Add(lblfecha);
            Controls.Add(lbltelf);
            Controls.Add(lbldireccion);
            Controls.Add(lblwimax);
            Controls.Add(logo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ReporteConsulta";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += ReporteConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lbltelf;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblwimax;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.DataGridView dtConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONSULTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLEADO_CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGISTRO_CONSULTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIADNOSTICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRESION_SANGUINEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OXIGENO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRECUENCIA_CARDIACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMPERATURA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PULSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HIPOTIROIDISMO;
        private System.Windows.Forms.Timer timer1;
    }
}