namespace proyectovacunas2._4.Mostrar
{
    partial class MostrarTablaConsulta
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
            dtConsulta = new System.Windows.Forms.DataGridView();
            ID_CONSULTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EMPLEADO_CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PACIENTE_CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            REGISTRO_CONSULTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DIADNOSTICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PRESION_SANGUINEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OXIGENO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FRECUENCIA_CARDIACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TEMPERATURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PULSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HIPOTIROIDISMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnTodo = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            txtBuscar = new System.Windows.Forms.TextBox();
            lblempleados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dtConsulta).BeginInit();
            SuspendLayout();
            // 
            // btnLog
            // 
            btnLog.Location = new System.Drawing.Point(895, 511);
            btnLog.Name = "btnLog";
            btnLog.Size = new System.Drawing.Size(94, 29);
            btnLog.TabIndex = 15;
            btnLog.Text = "Abrir Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(713, 71);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(115, 29);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new System.Drawing.Point(604, 71);
            btnClean.Name = "btnClean";
            btnClean.Size = new System.Drawing.Size(94, 29);
            btnClean.TabIndex = 13;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // dtConsulta
            // 
            dtConsulta.AllowUserToAddRows = false;
            dtConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_CONSULTA, EMPLEADO_CEDULA, PACIENTE_CEDULA, REGISTRO_CONSULTA, DIADNOSTICO, PRESION_SANGUINEA, OXIGENO, FRECUENCIA_CARDIACA, PESO, TEMPERATURA, PULSO, HIPOTIROIDISMO });
            dtConsulta.Location = new System.Drawing.Point(22, 130);
            dtConsulta.Name = "dtConsulta";
            dtConsulta.RowHeadersWidth = 51;
            dtConsulta.RowTemplate.Height = 29;
            dtConsulta.Size = new System.Drawing.Size(950, 375);
            dtConsulta.TabIndex = 12;
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
            // PACIENTE_CEDULA
            // 
            PACIENTE_CEDULA.HeaderText = "CEDULA PACIENTE";
            PACIENTE_CEDULA.MinimumWidth = 6;
            PACIENTE_CEDULA.Name = "PACIENTE_CEDULA";
            PACIENTE_CEDULA.Width = 125;
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
            // btnTodo
            // 
            btnTodo.Location = new System.Drawing.Point(491, 71);
            btnTodo.Name = "btnTodo";
            btnTodo.Size = new System.Drawing.Size(89, 29);
            btnTodo.TabIndex = 11;
            btnTodo.Text = "All";
            btnTodo.UseVisualStyleBackColor = true;
            btnTodo.Click += btnTodo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(331, 71);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(141, 29);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Search 🔎";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(22, 73);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(303, 27);
            txtBuscar.TabIndex = 9;
            // 
            // lblempleados
            // 
            lblempleados.AutoSize = true;
            lblempleados.Font = new System.Drawing.Font("Segoe UI", 29.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblempleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblempleados.Location = new System.Drawing.Point(8, 4);
            lblempleados.Name = "lblempleados";
            lblempleados.Size = new System.Drawing.Size(305, 66);
            lblempleados.TabIndex = 8;
            lblempleados.Text = "CONSULTAS";
            // 
            // MostrarTablaConsulta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1001, 571);
            Controls.Add(btnLog);
            Controls.Add(button1);
            Controls.Add(btnClean);
            Controls.Add(dtConsulta);
            Controls.Add(btnTodo);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblempleados);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "MostrarTablaConsulta";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dtConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridView dtConsulta;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblempleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONSULTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLEADO_CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACIENTE_CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGISTRO_CONSULTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIADNOSTICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRESION_SANGUINEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OXIGENO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRECUENCIA_CARDIACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMPERATURA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PULSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HIPOTIROIDISMO;
    }
}