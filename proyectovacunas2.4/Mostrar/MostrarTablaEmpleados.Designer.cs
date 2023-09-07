
namespace proyectovacunas2._4.Mostrar
{
    partial class MostrarTablaEmpleados
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
            lblempleados = new System.Windows.Forms.Label();
            txtBuscar = new System.Windows.Forms.TextBox();
            btnBuscar = new System.Windows.Forms.Button();
            btnTodo = new System.Windows.Forms.Button();
            dtEmpleado = new System.Windows.Forms.DataGridView();
            EMPLEADO_CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ID_AREA_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ID_CARGO_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FECHA_REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ACTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnClean = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            btnLog = new System.Windows.Forms.Button();
            USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtEmpleado).BeginInit();
            SuspendLayout();
            // 
            // lblempleados
            // 
            lblempleados.AutoSize = true;
            lblempleados.Font = new System.Drawing.Font("Segoe UI", 29.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblempleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblempleados.Location = new System.Drawing.Point(12, 9);
            lblempleados.Name = "lblempleados";
            lblempleados.Size = new System.Drawing.Size(317, 66);
            lblempleados.TabIndex = 0;
            lblempleados.Text = "EMPLEADOS";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(26, 78);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(303, 27);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(335, 76);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(141, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Search 🔎";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnTodo
            // 
            btnTodo.Location = new System.Drawing.Point(495, 76);
            btnTodo.Name = "btnTodo";
            btnTodo.Size = new System.Drawing.Size(89, 29);
            btnTodo.TabIndex = 3;
            btnTodo.Text = "All";
            btnTodo.UseVisualStyleBackColor = true;
            btnTodo.Click += btnTodo_Click;
            // 
            // dtEmpleado
            // 
            dtEmpleado.AllowUserToAddRows = false;
            dtEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { EMPLEADO_CEDULA, ID_AREA_EMPLEADO, ID_CARGO_EMPLEADO, FECHA_REGISTRO, ACTIVO, USUARIO });
            dtEmpleado.Location = new System.Drawing.Point(26, 135);
            dtEmpleado.Name = "dtEmpleado";
            dtEmpleado.RowHeadersWidth = 51;
            dtEmpleado.RowTemplate.Height = 29;
            dtEmpleado.Size = new System.Drawing.Size(806, 375);
            dtEmpleado.TabIndex = 4;
            // 
            // EMPLEADO_CEDULA
            // 
            EMPLEADO_CEDULA.HeaderText = "EMPLEADO CEDULA";
            EMPLEADO_CEDULA.MinimumWidth = 6;
            EMPLEADO_CEDULA.Name = "EMPLEADO_CEDULA";
            EMPLEADO_CEDULA.Width = 125;
            // 
            // ID_AREA_EMPLEADO
            // 
            ID_AREA_EMPLEADO.HeaderText = "ID AREA";
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
            FECHA_REGISTRO.HeaderText = "FECHA REGISTRO";
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
            // btnClean
            // 
            btnClean.Location = new System.Drawing.Point(608, 76);
            btnClean.Name = "btnClean";
            btnClean.Size = new System.Drawing.Size(94, 29);
            btnClean.TabIndex = 5;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(717, 76);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(115, 29);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnLog
            // 
            btnLog.Location = new System.Drawing.Point(738, 516);
            btnLog.Name = "btnLog";
            btnLog.Size = new System.Drawing.Size(94, 29);
            btnLog.TabIndex = 7;
            btnLog.Text = "Abrir Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // USUARIO
            // 
            USUARIO.HeaderText = "USUARIO";
            USUARIO.MinimumWidth = 6;
            USUARIO.Name = "USUARIO";
            USUARIO.Width = 125;
            // 
            // MostrarTablaEmpleados
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(862, 550);
            Controls.Add(btnLog);
            Controls.Add(button1);
            Controls.Add(btnClean);
            Controls.Add(dtEmpleado);
            Controls.Add(btnTodo);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblempleados);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "MostrarTablaEmpleados";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += MostrarTablaEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dtEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblempleados;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.DataGridView dtEmpleado;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLEADO_CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_AREA_EMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CARGO_EMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_REGISTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIVO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
    }
}