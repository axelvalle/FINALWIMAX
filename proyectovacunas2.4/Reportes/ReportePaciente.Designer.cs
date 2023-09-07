namespace proyectovacunas2._4.Reportes
{
    partial class ReportePaciente
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
            btnpdf = new System.Windows.Forms.Button();
            btnactualizar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            lblfecha = new System.Windows.Forms.Label();
            lbltelf = new System.Windows.Forms.Label();
            lbldireccion = new System.Windows.Forms.Label();
            lblwimax = new System.Windows.Forms.Label();
            logo = new System.Windows.Forms.PictureBox();
            dtPaciente = new System.Windows.Forms.DataGridView();
            PACIENTE_CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FECHA_INGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ENFERMEDAD_CRONICA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtPaciente).BeginInit();
            SuspendLayout();
            // 
            // btnpdf
            // 
            btnpdf.Location = new System.Drawing.Point(745, 614);
            btnpdf.Name = "btnpdf";
            btnpdf.Size = new System.Drawing.Size(225, 29);
            btnpdf.TabIndex = 17;
            btnpdf.Text = "Generar Archivo PDF";
            btnpdf.UseVisualStyleBackColor = true;
            btnpdf.Click += btnpdf_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new System.Drawing.Point(164, 614);
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
            label1.Location = new System.Drawing.Point(317, 172);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(461, 62);
            label1.TabIndex = 14;
            label1.Text = "REPORTE PACIENTE";
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblfecha.Location = new System.Drawing.Point(941, 81);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new System.Drawing.Size(115, 25);
            lblfecha.TabIndex = 13;
            lblfecha.Text = "Fecha y Hora";
            // 
            // lbltelf
            // 
            lbltelf.AutoSize = true;
            lbltelf.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbltelf.Location = new System.Drawing.Point(432, 132);
            lbltelf.Name = "lbltelf";
            lbltelf.Size = new System.Drawing.Size(222, 25);
            lbltelf.TabIndex = 12;
            lbltelf.Text = "Teléfono: +505 2250-6845";
            // 
            // lbldireccion
            // 
            lbldireccion.AutoSize = true;
            lbldireccion.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbldireccion.Location = new System.Drawing.Point(268, 107);
            lbldireccion.Name = "lbldireccion";
            lbldireccion.Size = new System.Drawing.Size(580, 25);
            lbldireccion.TabIndex = 11;
            lbldireccion.Text = "Dirección: Av. Universitaria, frente a la Academia de Danza Nicaragüense";
            // 
            // lblwimax
            // 
            lblwimax.AutoSize = true;
            lblwimax.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblwimax.Location = new System.Drawing.Point(268, 45);
            lblwimax.Name = "lblwimax";
            lblwimax.Size = new System.Drawing.Size(594, 62);
            lblwimax.TabIndex = 10;
            lblwimax.Text = "WIMAX CENTRO MEDICO";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.Imagen__25_;
            logo.Location = new System.Drawing.Point(23, 17);
            logo.Name = "logo";
            logo.Size = new System.Drawing.Size(184, 173);
            logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 9;
            logo.TabStop = false;
            // 
            // dtPaciente
            // 
            dtPaciente.AllowUserToAddRows = false;
            dtPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { PACIENTE_CEDULA, FECHA_INGRESO, ENFERMEDAD_CRONICA });
            dtPaciente.Location = new System.Drawing.Point(164, 263);
            dtPaciente.Name = "dtPaciente";
            dtPaciente.RowHeadersWidth = 51;
            dtPaciente.RowTemplate.Height = 29;
            dtPaciente.Size = new System.Drawing.Size(806, 312);
            dtPaciente.TabIndex = 18;
            // 
            // PACIENTE_CEDULA
            // 
            PACIENTE_CEDULA.HeaderText = "CEDULA PACIENTE";
            PACIENTE_CEDULA.MinimumWidth = 6;
            PACIENTE_CEDULA.Name = "PACIENTE_CEDULA";
            PACIENTE_CEDULA.Width = 250;
            // 
            // FECHA_INGRESO
            // 
            FECHA_INGRESO.HeaderText = "FECHA DE INGRESO";
            FECHA_INGRESO.MinimumWidth = 6;
            FECHA_INGRESO.Name = "FECHA_INGRESO";
            FECHA_INGRESO.Width = 250;
            // 
            // ENFERMEDAD_CRONICA
            // 
            ENFERMEDAD_CRONICA.HeaderText = "ENFERMEDAD CRONICA";
            ENFERMEDAD_CRONICA.MinimumWidth = 6;
            ENFERMEDAD_CRONICA.Name = "ENFERMEDAD_CRONICA";
            ENFERMEDAD_CRONICA.Width = 250;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // ReportePaciente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1080, 672);
            Controls.Add(dtPaciente);
            Controls.Add(btnpdf);
            Controls.Add(btnactualizar);
            Controls.Add(label1);
            Controls.Add(lblfecha);
            Controls.Add(lbltelf);
            Controls.Add(lbldireccion);
            Controls.Add(lblwimax);
            Controls.Add(logo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "ReportePaciente";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += ReportePaciente_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtPaciente).EndInit();
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
        private System.Windows.Forms.DataGridView dtPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACIENTE_CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_INGRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENFERMEDAD_CRONICA;
        private System.Windows.Forms.Timer timer1;
    }
}