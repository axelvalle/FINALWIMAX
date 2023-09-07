namespace proyectovacunas2._4.Mostrar
{
    partial class MostrarTablaPaciente
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
            btnLog = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            btnClean = new System.Windows.Forms.Button();
            dtPaciente = new System.Windows.Forms.DataGridView();
            PACIENTE_CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FECHA_INGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ENFERMEDAD_CRONICA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnTodo = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            txtBuscar = new System.Windows.Forms.TextBox();
            lblempleados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dtPaciente).BeginInit();
            SuspendLayout();
            // 
            // btnLog
            // 
            btnLog.Location = new System.Drawing.Point(741, 514);
            btnLog.Name = "btnLog";
            btnLog.Size = new System.Drawing.Size(94, 29);
            btnLog.TabIndex = 15;
            btnLog.Text = "Abrir Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(720, 74);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(115, 29);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnClean
            // 
            btnClean.Location = new System.Drawing.Point(611, 74);
            btnClean.Name = "btnClean";
            btnClean.Size = new System.Drawing.Size(94, 29);
            btnClean.TabIndex = 13;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click_1;
            // 
            // dtPaciente
            // 
            dtPaciente.AllowUserToAddRows = false;
            dtPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { PACIENTE_CEDULA, FECHA_INGRESO, ENFERMEDAD_CRONICA });
            dtPaciente.Location = new System.Drawing.Point(29, 133);
            dtPaciente.Name = "dtPaciente";
            dtPaciente.RowHeadersWidth = 51;
            dtPaciente.RowTemplate.Height = 29;
            dtPaciente.Size = new System.Drawing.Size(806, 375);
            dtPaciente.TabIndex = 12;
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
            // btnTodo
            // 
            btnTodo.Location = new System.Drawing.Point(498, 74);
            btnTodo.Name = "btnTodo";
            btnTodo.Size = new System.Drawing.Size(89, 29);
            btnTodo.TabIndex = 11;
            btnTodo.Text = "All";
            btnTodo.UseVisualStyleBackColor = true;
            btnTodo.Click += btnTodo_Click_1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(338, 74);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(141, 29);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Search 🔎";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(29, 76);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(303, 27);
            txtBuscar.TabIndex = 9;
            // 
            // lblempleados
            // 
            lblempleados.AutoSize = true;
            lblempleados.Font = new System.Drawing.Font("Segoe UI", 29.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblempleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblempleados.Location = new System.Drawing.Point(15, 7);
            lblempleados.Name = "lblempleados";
            lblempleados.Size = new System.Drawing.Size(282, 66);
            lblempleados.TabIndex = 8;
            lblempleados.Text = "PACIENTES";
            // 
            // MostrarTablaPaciente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(869, 556);
            Controls.Add(btnLog);
            Controls.Add(button1);
            Controls.Add(btnClean);
            Controls.Add(dtPaciente);
            Controls.Add(btnTodo);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblempleados);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "MostrarTablaPaciente";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dtPaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridView dtPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACIENTE_CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_INGRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENFERMEDAD_CRONICA;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblempleados;
    }
}