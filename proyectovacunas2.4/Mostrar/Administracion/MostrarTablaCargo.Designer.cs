namespace proyectovacunas2._4.Mostrar
{
    partial class MostrarTablaCargo
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
            dtCargo = new System.Windows.Forms.DataGridView();
            ID_CARGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NOMBRE_CARGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ESPECIALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnTodo = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            txtBuscar = new System.Windows.Forms.TextBox();
            lblempleados = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            dtRegistroCargo = new System.Windows.Forms.DateTimePicker();
            txtespecialidad = new System.Windows.Forms.TextBox();
            lblnombredearea = new System.Windows.Forms.Label();
            txtnombrecargo = new System.Windows.Forms.TextBox();
            lbltipodearea = new System.Windows.Forms.Label();
            lblregistro = new System.Windows.Forms.Label();
            Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dtCargo).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLog
            // 
            btnLog.Location = new System.Drawing.Point(693, 260);
            btnLog.Name = "btnLog";
            btnLog.Size = new System.Drawing.Size(94, 29);
            btnLog.TabIndex = 15;
            btnLog.Text = "Abrir Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click_1;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(639, 32);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(115, 29);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new System.Drawing.Point(539, 32);
            btnClean.Name = "btnClean";
            btnClean.Size = new System.Drawing.Size(94, 29);
            btnClean.TabIndex = 13;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // dtCargo
            // 
            dtCargo.AllowUserToAddRows = false;
            dtCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtCargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_CARGO, NOMBRE_CARGO, ESPECIALIDAD, REGISTRO });
            dtCargo.Location = new System.Drawing.Point(21, 77);
            dtCargo.Name = "dtCargo";
            dtCargo.RowHeadersWidth = 51;
            dtCargo.RowTemplate.Height = 29;
            dtCargo.Size = new System.Drawing.Size(733, 177);
            dtCargo.TabIndex = 12;
            // 
            // ID_CARGO
            // 
            ID_CARGO.HeaderText = "ID CARGO";
            ID_CARGO.MinimumWidth = 6;
            ID_CARGO.Name = "ID_CARGO";
            ID_CARGO.Width = 170;
            // 
            // NOMBRE_CARGO
            // 
            NOMBRE_CARGO.HeaderText = "NOMBRE DE CARGO";
            NOMBRE_CARGO.MinimumWidth = 6;
            NOMBRE_CARGO.Name = "NOMBRE_CARGO";
            NOMBRE_CARGO.Width = 170;
            // 
            // ESPECIALIDAD
            // 
            ESPECIALIDAD.HeaderText = "ESPECIALIDAD";
            ESPECIALIDAD.MinimumWidth = 6;
            ESPECIALIDAD.Name = "ESPECIALIDAD";
            ESPECIALIDAD.Width = 170;
            // 
            // REGISTRO
            // 
            REGISTRO.HeaderText = "REGISTRO";
            REGISTRO.MinimumWidth = 6;
            REGISTRO.Name = "REGISTRO";
            REGISTRO.Width = 170;
            // 
            // btnTodo
            // 
            btnTodo.Location = new System.Drawing.Point(444, 32);
            btnTodo.Name = "btnTodo";
            btnTodo.Size = new System.Drawing.Size(89, 29);
            btnTodo.TabIndex = 11;
            btnTodo.Text = "All";
            btnTodo.UseVisualStyleBackColor = true;
            btnTodo.Click += btnTodo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(297, 31);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(141, 29);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Search 🔎";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(21, 32);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(270, 27);
            txtBuscar.TabIndex = 9;
            // 
            // lblempleados
            // 
            lblempleados.AutoSize = true;
            lblempleados.Font = new System.Drawing.Font("Segoe UI", 29.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblempleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblempleados.Location = new System.Drawing.Point(7, 5);
            lblempleados.Name = "lblempleados";
            lblempleados.Size = new System.Drawing.Size(197, 66);
            lblempleados.TabIndex = 8;
            lblempleados.Text = "CARGO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtCargo);
            groupBox1.Controls.Add(btnLog);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(btnClean);
            groupBox1.Controls.Add(btnTodo);
            groupBox1.Location = new System.Drawing.Point(29, 218);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(793, 301);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtRegistroCargo);
            groupBox2.Controls.Add(txtespecialidad);
            groupBox2.Controls.Add(lblnombredearea);
            groupBox2.Controls.Add(txtnombrecargo);
            groupBox2.Controls.Add(lbltipodearea);
            groupBox2.Controls.Add(lblregistro);
            groupBox2.Controls.Add(Agregar);
            groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(29, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(793, 151);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            // 
            // dtRegistroCargo
            // 
            dtRegistroCargo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtRegistroCargo.Location = new System.Drawing.Point(452, 43);
            dtRegistroCargo.Name = "dtRegistroCargo";
            dtRegistroCargo.Size = new System.Drawing.Size(286, 28);
            dtRegistroCargo.TabIndex = 20;
            // 
            // txtespecialidad
            // 
            txtespecialidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtespecialidad.Location = new System.Drawing.Point(180, 91);
            txtespecialidad.Name = "txtespecialidad";
            txtespecialidad.Size = new System.Drawing.Size(152, 32);
            txtespecialidad.TabIndex = 22;
            // 
            // lblnombredearea
            // 
            lblnombredearea.AutoSize = true;
            lblnombredearea.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblnombredearea.Location = new System.Drawing.Point(18, 43);
            lblnombredearea.Name = "lblnombredearea";
            lblnombredearea.Size = new System.Drawing.Size(148, 23);
            lblnombredearea.TabIndex = 16;
            lblnombredearea.Text = "Nombre de Cargo";
            // 
            // txtnombrecargo
            // 
            txtnombrecargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtnombrecargo.Location = new System.Drawing.Point(180, 40);
            txtnombrecargo.Name = "txtnombrecargo";
            txtnombrecargo.Size = new System.Drawing.Size(152, 32);
            txtnombrecargo.TabIndex = 21;
            // 
            // lbltipodearea
            // 
            lbltipodearea.AutoSize = true;
            lbltipodearea.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbltipodearea.Location = new System.Drawing.Point(18, 94);
            lbltipodearea.Name = "lbltipodearea";
            lbltipodearea.Size = new System.Drawing.Size(103, 23);
            lbltipodearea.TabIndex = 17;
            lbltipodearea.Text = "Especialidad";
            // 
            // lblregistro
            // 
            lblregistro.AutoSize = true;
            lblregistro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblregistro.Location = new System.Drawing.Point(374, 45);
            lblregistro.Name = "lblregistro";
            lblregistro.Size = new System.Drawing.Size(72, 23);
            lblregistro.TabIndex = 18;
            lblregistro.Text = "Registro";
            // 
            // Agregar
            // 
            Agregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Agregar.Location = new System.Drawing.Point(374, 98);
            Agregar.Name = "Agregar";
            Agregar.Size = new System.Drawing.Size(364, 29);
            Agregar.TabIndex = 19;
            Agregar.Text = "Agregar Nuevo Cargo";
            Agregar.UseVisualStyleBackColor = true;
            Agregar.Click += Agregar_Click;
            // 
            // MostrarTablaCargo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(834, 524);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblempleados);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "MostrarTablaCargo";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += MostrarTablaCargo_Load;
            ((System.ComponentModel.ISupportInitialize)dtCargo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridView dtCargo;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblempleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CARGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_CARGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESPECIALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGISTRO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtRegistroCargo;
        private System.Windows.Forms.TextBox txtespecialidad;
        private System.Windows.Forms.Label lblnombredearea;
        private System.Windows.Forms.TextBox txtnombrecargo;
        private System.Windows.Forms.Label lbltipodearea;
        private System.Windows.Forms.Label lblregistro;
        private System.Windows.Forms.Button Agregar;
    }
}