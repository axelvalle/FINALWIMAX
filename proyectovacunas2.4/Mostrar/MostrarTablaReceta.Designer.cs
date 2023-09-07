namespace proyectovacunas2._4.Mostrar
{
    partial class MostrarTablaReceta
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
            dtReceta = new System.Windows.Forms.DataGridView();
            ID_RECETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PACIENTE_CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ID_PRODUCTO_RECETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnTodo = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            txtBuscar = new System.Windows.Forms.TextBox();
            lblempleados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dtReceta).BeginInit();
            SuspendLayout();
            // 
            // btnLog
            // 
            btnLog.Location = new System.Drawing.Point(738, 518);
            btnLog.Name = "btnLog";
            btnLog.Size = new System.Drawing.Size(94, 29);
            btnLog.TabIndex = 15;
            btnLog.Text = "Abrir Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(717, 78);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(115, 29);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new System.Drawing.Point(608, 78);
            btnClean.Name = "btnClean";
            btnClean.Size = new System.Drawing.Size(94, 29);
            btnClean.TabIndex = 13;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // dtReceta
            // 
            dtReceta.AllowUserToAddRows = false;
            dtReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_RECETA, PACIENTE_CEDULA, ID_PRODUCTO_RECETA, CANTIDAD });
            dtReceta.Location = new System.Drawing.Point(75, 137);
            dtReceta.Name = "dtReceta";
            dtReceta.RowHeadersWidth = 51;
            dtReceta.RowTemplate.Height = 29;
            dtReceta.Size = new System.Drawing.Size(735, 375);
            dtReceta.TabIndex = 12;
            // 
            // ID_RECETA
            // 
            ID_RECETA.HeaderText = "ID RECETA";
            ID_RECETA.MinimumWidth = 6;
            ID_RECETA.Name = "ID_RECETA";
            ID_RECETA.Width = 170;
            // 
            // PACIENTE_CEDULA
            // 
            PACIENTE_CEDULA.HeaderText = "CEDULA DE PACIENTE";
            PACIENTE_CEDULA.MinimumWidth = 6;
            PACIENTE_CEDULA.Name = "PACIENTE_CEDULA";
            PACIENTE_CEDULA.Width = 170;
            // 
            // ID_PRODUCTO_RECETA
            // 
            ID_PRODUCTO_RECETA.HeaderText = "ID PRODUCTO RECETA";
            ID_PRODUCTO_RECETA.MinimumWidth = 6;
            ID_PRODUCTO_RECETA.Name = "ID_PRODUCTO_RECETA";
            ID_PRODUCTO_RECETA.Width = 170;
            // 
            // CANTIDAD
            // 
            CANTIDAD.HeaderText = "CANTIDAD";
            CANTIDAD.MinimumWidth = 6;
            CANTIDAD.Name = "CANTIDAD";
            CANTIDAD.Width = 170;
            // 
            // btnTodo
            // 
            btnTodo.Location = new System.Drawing.Point(495, 78);
            btnTodo.Name = "btnTodo";
            btnTodo.Size = new System.Drawing.Size(89, 29);
            btnTodo.TabIndex = 11;
            btnTodo.Text = "All";
            btnTodo.UseVisualStyleBackColor = true;
            btnTodo.Click += btnTodo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(335, 78);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(141, 29);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Search 🔎";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(26, 80);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(303, 27);
            txtBuscar.TabIndex = 9;
            // 
            // lblempleados
            // 
            lblempleados.AutoSize = true;
            lblempleados.Font = new System.Drawing.Font("Segoe UI", 29.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblempleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblempleados.Location = new System.Drawing.Point(12, 11);
            lblempleados.Name = "lblempleados";
            lblempleados.Size = new System.Drawing.Size(230, 66);
            lblempleados.TabIndex = 8;
            lblempleados.Text = "RECETAS";
            // 
            // MostrarTablaReceta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(860, 562);
            Controls.Add(btnLog);
            Controls.Add(button1);
            Controls.Add(btnClean);
            Controls.Add(dtReceta);
            Controls.Add(btnTodo);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblempleados);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "MostrarTablaReceta";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dtReceta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridView dtReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_RECETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACIENTE_CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO_RECETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblempleados;
    }
}