namespace proyectovacunas2._4.Mostrar
{
    partial class MostrarTablaPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarTablaPersona));
            btnClean = new System.Windows.Forms.Button();
            btnTodo = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            txtBuscar = new System.Windows.Forms.TextBox();
            lblPersona = new System.Windows.Forms.Label();
            dtPersona = new System.Windows.Forms.DataGridView();
            CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NOMBRE_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NOMBRE_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            APELLIDO_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            APELLIDO_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtPersona).BeginInit();
            SuspendLayout();
            // 
            // btnClean
            // 
            btnClean.Location = new System.Drawing.Point(738, 77);
            btnClean.Name = "btnClean";
            btnClean.Size = new System.Drawing.Size(94, 29);
            btnClean.TabIndex = 13;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnTodo
            // 
            btnTodo.Location = new System.Drawing.Point(643, 77);
            btnTodo.Name = "btnTodo";
            btnTodo.Size = new System.Drawing.Size(89, 29);
            btnTodo.TabIndex = 11;
            btnTodo.Text = "All";
            btnTodo.UseVisualStyleBackColor = true;
            btnTodo.Click += btnTodo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(496, 77);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(141, 29);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Search 🔎";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(29, 79);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(461, 27);
            txtBuscar.TabIndex = 9;
            // 
            // lblPersona
            // 
            lblPersona.AutoSize = true;
            lblPersona.Font = new System.Drawing.Font("Segoe UI", 29.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPersona.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblPersona.Location = new System.Drawing.Point(15, 10);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new System.Drawing.Size(280, 66);
            lblPersona.TabIndex = 8;
            lblPersona.Text = "PERSONAS";
            // 
            // dtPersona
            // 
            dtPersona.AllowUserToAddRows = false;
            dtPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { CEDULA, NOMBRE_1, NOMBRE_2, APELLIDO_1, APELLIDO_2, EDAD, SEXO, DEPARTAMENTO });
            dtPersona.Location = new System.Drawing.Point(29, 134);
            dtPersona.Name = "dtPersona";
            dtPersona.ReadOnly = true;
            dtPersona.RowHeadersWidth = 51;
            dtPersona.RowTemplate.Height = 29;
            dtPersona.Size = new System.Drawing.Size(803, 357);
            dtPersona.TabIndex = 16;
            // 
            // CEDULA
            // 
            CEDULA.HeaderText = "CEDULA";
            CEDULA.MinimumWidth = 6;
            CEDULA.Name = "CEDULA";
            CEDULA.ReadOnly = true;
            CEDULA.Width = 125;
            // 
            // NOMBRE_1
            // 
            NOMBRE_1.HeaderText = "NOMBRE_1";
            NOMBRE_1.MinimumWidth = 6;
            NOMBRE_1.Name = "NOMBRE_1";
            NOMBRE_1.ReadOnly = true;
            NOMBRE_1.Width = 125;
            // 
            // NOMBRE_2
            // 
            NOMBRE_2.HeaderText = "NOMBRE_2";
            NOMBRE_2.MinimumWidth = 6;
            NOMBRE_2.Name = "NOMBRE_2";
            NOMBRE_2.ReadOnly = true;
            NOMBRE_2.Width = 125;
            // 
            // APELLIDO_1
            // 
            APELLIDO_1.HeaderText = "APELLIDO_1";
            APELLIDO_1.MinimumWidth = 6;
            APELLIDO_1.Name = "APELLIDO_1";
            APELLIDO_1.ReadOnly = true;
            APELLIDO_1.Width = 125;
            // 
            // APELLIDO_2
            // 
            APELLIDO_2.HeaderText = "APELLIDO_2";
            APELLIDO_2.MinimumWidth = 6;
            APELLIDO_2.Name = "APELLIDO_2";
            APELLIDO_2.ReadOnly = true;
            APELLIDO_2.Width = 125;
            // 
            // EDAD
            // 
            EDAD.HeaderText = "EDAD";
            EDAD.MinimumWidth = 6;
            EDAD.Name = "EDAD";
            EDAD.ReadOnly = true;
            EDAD.Width = 125;
            // 
            // SEXO
            // 
            SEXO.HeaderText = "SEXO";
            SEXO.MinimumWidth = 6;
            SEXO.Name = "SEXO";
            SEXO.ReadOnly = true;
            SEXO.Width = 125;
            // 
            // DEPARTAMENTO
            // 
            DEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            DEPARTAMENTO.MinimumWidth = 6;
            DEPARTAMENTO.Name = "DEPARTAMENTO";
            DEPARTAMENTO.ReadOnly = true;
            DEPARTAMENTO.Width = 125;
            // 
            // MostrarTablaPersona
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(862, 522);
            Controls.Add(dtPersona);
            Controls.Add(btnClean);
            Controls.Add(btnTodo);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblPersona);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MostrarTablaPersona";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dtPersona).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.DataGridView dtPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTAMENTO;
    }
}