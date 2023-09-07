namespace proyectovacunas2._4.Mostrar
{
    partial class FrameCita
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
            dtCitas = new System.Windows.Forms.DataGridView();
            ID_CITA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EMPLEADO_CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PACIENTE_CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            REGISTRO_CITA_DESDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            REGISTRO_CITA_HASTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnTodo = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            txtBuscar = new System.Windows.Forms.TextBox();
            btnVolver = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            cbEmpleado = new System.Windows.Forms.ComboBox();
            cbPaciente = new System.Windows.Forms.ComboBox();
            dtpCitadesde = new System.Windows.Forms.DateTimePicker();
            dtpCitahasta = new System.Windows.Forms.DateTimePicker();
            btncitanew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dtCitas).BeginInit();
            SuspendLayout();
            // 
            // btnLog
            // 
            btnLog.Location = new System.Drawing.Point(880, 573);
            btnLog.Name = "btnLog";
            btnLog.Size = new System.Drawing.Size(94, 29);
            btnLog.TabIndex = 15;
            btnLog.Text = "Abrir Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(858, 340);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(115, 29);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new System.Drawing.Point(758, 340);
            btnClean.Name = "btnClean";
            btnClean.Size = new System.Drawing.Size(94, 29);
            btnClean.TabIndex = 13;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // dtCitas
            // 
            dtCitas.AllowUserToAddRows = false;
            dtCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_CITA, EMPLEADO_CEDULA, PACIENTE_CEDULA, REGISTRO_CITA_DESDE, REGISTRO_CITA_HASTA });
            dtCitas.Location = new System.Drawing.Point(168, 388);
            dtCitas.Name = "dtCitas";
            dtCitas.RowHeadersWidth = 51;
            dtCitas.RowTemplate.Height = 29;
            dtCitas.Size = new System.Drawing.Size(814, 179);
            dtCitas.TabIndex = 12;
            // 
            // ID_CITA
            // 
            ID_CITA.HeaderText = "ID_CITA";
            ID_CITA.MinimumWidth = 6;
            ID_CITA.Name = "ID_CITA";
            ID_CITA.Width = 125;
            // 
            // EMPLEADO_CEDULA
            // 
            EMPLEADO_CEDULA.HeaderText = "EMPLEADO_CEDULA";
            EMPLEADO_CEDULA.MinimumWidth = 6;
            EMPLEADO_CEDULA.Name = "EMPLEADO_CEDULA";
            EMPLEADO_CEDULA.Width = 125;
            // 
            // PACIENTE_CEDULA
            // 
            PACIENTE_CEDULA.HeaderText = "PACIENTE_CEDULA";
            PACIENTE_CEDULA.MinimumWidth = 6;
            PACIENTE_CEDULA.Name = "PACIENTE_CEDULA";
            PACIENTE_CEDULA.Width = 125;
            // 
            // REGISTRO_CITA_DESDE
            // 
            REGISTRO_CITA_DESDE.HeaderText = "REGISTRO_CITA_DESDE";
            REGISTRO_CITA_DESDE.MinimumWidth = 6;
            REGISTRO_CITA_DESDE.Name = "REGISTRO_CITA_DESDE";
            REGISTRO_CITA_DESDE.Width = 125;
            // 
            // REGISTRO_CITA_HASTA
            // 
            REGISTRO_CITA_HASTA.HeaderText = "REGISTRO_CITA_HASTA";
            REGISTRO_CITA_HASTA.MinimumWidth = 6;
            REGISTRO_CITA_HASTA.Name = "REGISTRO_CITA_HASTA";
            REGISTRO_CITA_HASTA.Width = 260;
            // 
            // btnTodo
            // 
            btnTodo.Location = new System.Drawing.Point(662, 340);
            btnTodo.Name = "btnTodo";
            btnTodo.Size = new System.Drawing.Size(89, 29);
            btnTodo.TabIndex = 11;
            btnTodo.Text = "All";
            btnTodo.UseVisualStyleBackColor = true;
            btnTodo.Click += btnTodo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(514, 338);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(141, 29);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Search 🔎";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(177, 340);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(330, 27);
            txtBuscar.TabIndex = 9;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.Turquoise;
            btnVolver.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnVolver.ForeColor = System.Drawing.Color.AliceBlue;
            btnVolver.Location = new System.Drawing.Point(12, 601);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(157, 45);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "Regresar";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(177, 158);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(157, 24);
            label1.TabIndex = 17;
            label1.Text = "Cedula Empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(177, 229);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(145, 24);
            label2.TabIndex = 18;
            label2.Text = "Cedula Paciente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(591, 158);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 24);
            label3.TabIndex = 19;
            label3.Text = "Cita desde";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(591, 229);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(94, 24);
            label4.TabIndex = 20;
            label4.Text = "Cita hasta";
            // 
            // cbEmpleado
            // 
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Location = new System.Drawing.Point(342, 158);
            cbEmpleado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new System.Drawing.Size(215, 28);
            cbEmpleado.TabIndex = 21;
            // 
            // cbPaciente
            // 
            cbPaciente.FormattingEnabled = true;
            cbPaciente.Location = new System.Drawing.Point(342, 229);
            cbPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbPaciente.Name = "cbPaciente";
            cbPaciente.Size = new System.Drawing.Size(215, 28);
            cbPaciente.TabIndex = 22;
            // 
            // dtpCitadesde
            // 
            dtpCitadesde.Location = new System.Drawing.Point(703, 158);
            dtpCitadesde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpCitadesde.Name = "dtpCitadesde";
            dtpCitadesde.Size = new System.Drawing.Size(270, 27);
            dtpCitadesde.TabIndex = 23;
            // 
            // dtpCitahasta
            // 
            dtpCitahasta.Location = new System.Drawing.Point(703, 229);
            dtpCitahasta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpCitahasta.Name = "dtpCitahasta";
            dtpCitahasta.Size = new System.Drawing.Size(270, 27);
            dtpCitahasta.TabIndex = 24;
            // 
            // btncitanew
            // 
            btncitanew.Location = new System.Drawing.Point(824, 281);
            btncitanew.Name = "btncitanew";
            btncitanew.Size = new System.Drawing.Size(150, 29);
            btncitanew.TabIndex = 25;
            btncitanew.Text = "Agregar Nueva Cita";
            btncitanew.UseVisualStyleBackColor = true;
            btncitanew.Click += btncitanew_Click;
            // 
            // Cita
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.citas2;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1169, 658);
            Controls.Add(btncitanew);
            Controls.Add(dtpCitahasta);
            Controls.Add(dtpCitadesde);
            Controls.Add(cbPaciente);
            Controls.Add(cbEmpleado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(btnLog);
            Controls.Add(button1);
            Controls.Add(btnClean);
            Controls.Add(dtCitas);
            Controls.Add(btnTodo);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Cita";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += Cita_Load;
            ((System.ComponentModel.ISupportInitialize)dtCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridView dtCitas;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.DateTimePicker dtpCitadesde;
        private System.Windows.Forms.DateTimePicker dtpCitahasta;
        private System.Windows.Forms.Button btncitanew;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CITA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLEADO_CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACIENTE_CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGISTRO_CITA_DESDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGISTRO_CITA_HASTA;
    }
}