namespace proyectovacunas2._4.Mostrar
{
    partial class MostrarTablaSalarios_cargo
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
            dtSalarioCargo = new System.Windows.Forms.DataGridView();
            ID_SALARIOS_CARGOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CARGO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            VALIDO_DESDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SALARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnTodo = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            txtBuscar = new System.Windows.Forms.TextBox();
            lblempleados = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            cbCargo = new System.Windows.Forms.ComboBox();
            dtRegistroSalario = new System.Windows.Forms.DateTimePicker();
            txtSalario = new System.Windows.Forms.TextBox();
            lblnombredearea = new System.Windows.Forms.Label();
            lbltipodearea = new System.Windows.Forms.Label();
            lblregistro = new System.Windows.Forms.Label();
            Añadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dtSalarioCargo).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLog
            // 
            btnLog.Location = new System.Drawing.Point(807, 256);
            btnLog.Name = "btnLog";
            btnLog.Size = new System.Drawing.Size(94, 29);
            btnLog.TabIndex = 15;
            btnLog.Text = "Abrir Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(786, 22);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(115, 29);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new System.Drawing.Point(686, 22);
            btnClean.Name = "btnClean";
            btnClean.Size = new System.Drawing.Size(94, 29);
            btnClean.TabIndex = 13;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // dtSalarioCargo
            // 
            dtSalarioCargo.AllowUserToAddRows = false;
            dtSalarioCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtSalarioCargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_SALARIOS_CARGOS, CARGO_ID, VALIDO_DESDE, SALARIO });
            dtSalarioCargo.Location = new System.Drawing.Point(48, 71);
            dtSalarioCargo.Name = "dtSalarioCargo";
            dtSalarioCargo.RowHeadersWidth = 51;
            dtSalarioCargo.RowTemplate.Height = 29;
            dtSalarioCargo.Size = new System.Drawing.Size(853, 179);
            dtSalarioCargo.TabIndex = 12;
            // 
            // ID_SALARIOS_CARGOS
            // 
            ID_SALARIOS_CARGOS.HeaderText = "ID CARGOS SALARIOS";
            ID_SALARIOS_CARGOS.MinimumWidth = 6;
            ID_SALARIOS_CARGOS.Name = "ID_SALARIOS_CARGOS";
            ID_SALARIOS_CARGOS.Width = 200;
            // 
            // CARGO_ID
            // 
            CARGO_ID.HeaderText = "ID CARGO";
            CARGO_ID.MinimumWidth = 6;
            CARGO_ID.Name = "CARGO_ID";
            CARGO_ID.Width = 200;
            // 
            // VALIDO_DESDE
            // 
            VALIDO_DESDE.HeaderText = "VALIDO DESDE";
            VALIDO_DESDE.MinimumWidth = 6;
            VALIDO_DESDE.Name = "VALIDO_DESDE";
            VALIDO_DESDE.Width = 200;
            // 
            // SALARIO
            // 
            SALARIO.HeaderText = "SALARIO";
            SALARIO.MinimumWidth = 6;
            SALARIO.Name = "SALARIO";
            SALARIO.Width = 200;
            // 
            // btnTodo
            // 
            btnTodo.Location = new System.Drawing.Point(591, 22);
            btnTodo.Name = "btnTodo";
            btnTodo.Size = new System.Drawing.Size(89, 29);
            btnTodo.TabIndex = 11;
            btnTodo.Text = "All";
            btnTodo.UseVisualStyleBackColor = true;
            btnTodo.Click += btnTodo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(444, 22);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(141, 29);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Search 🔎";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(48, 23);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(390, 27);
            txtBuscar.TabIndex = 9;
            // 
            // lblempleados
            // 
            lblempleados.AutoSize = true;
            lblempleados.Font = new System.Drawing.Font("Segoe UI", 29.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblempleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblempleados.Location = new System.Drawing.Point(12, 9);
            lblempleados.Name = "lblempleados";
            lblempleados.Size = new System.Drawing.Size(444, 66);
            lblempleados.TabIndex = 8;
            lblempleados.Text = "SALARIOS CARGO";
            lblempleados.Click += lblempleados_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnLog);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(btnClean);
            groupBox1.Controls.Add(btnTodo);
            groupBox1.Controls.Add(dtSalarioCargo);
            groupBox1.Location = new System.Drawing.Point(12, 235);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(946, 295);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbCargo);
            groupBox2.Controls.Add(dtRegistroSalario);
            groupBox2.Controls.Add(txtSalario);
            groupBox2.Controls.Add(lblnombredearea);
            groupBox2.Controls.Add(lbltipodearea);
            groupBox2.Controls.Add(lblregistro);
            groupBox2.Controls.Add(Añadir);
            groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(12, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(946, 151);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new System.Drawing.Point(180, 43);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new System.Drawing.Size(250, 32);
            cbCargo.TabIndex = 23;
            // 
            // dtRegistroSalario
            // 
            dtRegistroSalario.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtRegistroSalario.Location = new System.Drawing.Point(615, 36);
            dtRegistroSalario.Name = "dtRegistroSalario";
            dtRegistroSalario.Size = new System.Drawing.Size(286, 28);
            dtRegistroSalario.TabIndex = 20;
            // 
            // txtSalario
            // 
            txtSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSalario.Location = new System.Drawing.Point(180, 91);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new System.Drawing.Size(250, 32);
            txtSalario.TabIndex = 22;
            txtSalario.TextChanged += txtipodearea_TextChanged;
            // 
            // lblnombredearea
            // 
            lblnombredearea.AutoSize = true;
            lblnombredearea.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblnombredearea.Location = new System.Drawing.Point(18, 43);
            lblnombredearea.Name = "lblnombredearea";
            lblnombredearea.Size = new System.Drawing.Size(78, 23);
            lblnombredearea.TabIndex = 16;
            lblnombredearea.Text = "ID Cargo";
            // 
            // lbltipodearea
            // 
            lbltipodearea.AutoSize = true;
            lbltipodearea.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbltipodearea.Location = new System.Drawing.Point(18, 94);
            lbltipodearea.Name = "lbltipodearea";
            lbltipodearea.Size = new System.Drawing.Size(61, 23);
            lbltipodearea.TabIndex = 17;
            lbltipodearea.Text = "Salario";
            // 
            // lblregistro
            // 
            lblregistro.AutoSize = true;
            lblregistro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblregistro.Location = new System.Drawing.Point(502, 40);
            lblregistro.Name = "lblregistro";
            lblregistro.Size = new System.Drawing.Size(107, 23);
            lblregistro.TabIndex = 18;
            lblregistro.Text = "Valido desde";
            // 
            // Añadir
            // 
            Añadir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Añadir.Location = new System.Drawing.Point(502, 94);
            Añadir.Name = "Añadir";
            Añadir.Size = new System.Drawing.Size(399, 29);
            Añadir.TabIndex = 19;
            Añadir.Text = "Agregar Nuevo Salario";
            Añadir.UseVisualStyleBackColor = true;
            Añadir.Click += Añadir_Click;
            // 
            // MostrarTablaSalarios_cargo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(977, 546);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblempleados);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "MostrarTablaSalarios_cargo";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += MostrarTablaSalarios_cargo_Load;
            ((System.ComponentModel.ISupportInitialize)dtSalarioCargo).EndInit();
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
        private System.Windows.Forms.DataGridView dtSalarioCargo;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblempleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SALARIOS_CARGOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARGO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALIDO_DESDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALARIO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtRegistroSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblnombredearea;
        private System.Windows.Forms.Label lbltipodearea;
        private System.Windows.Forms.Label lblregistro;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.ComboBox cbCargo;
    }
}