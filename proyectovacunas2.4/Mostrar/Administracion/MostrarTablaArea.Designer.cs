namespace proyectovacunas2._4.Mostrar
{
    partial class MostrarTablaArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarTablaArea));
            btnLog = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            btnClean = new System.Windows.Forms.Button();
            dtArea = new System.Windows.Forms.DataGridView();
            ID_AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NOMBRE_AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TIPO_AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnTodo = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            txtBuscar = new System.Windows.Forms.TextBox();
            lblempleados = new System.Windows.Forms.Label();
            lblnombredearea = new System.Windows.Forms.Label();
            lbltipodearea = new System.Windows.Forms.Label();
            lblregistro = new System.Windows.Forms.Label();
            Añadir = new System.Windows.Forms.Button();
            dtFechaRegistro = new System.Windows.Forms.DateTimePicker();
            txtnombrearea = new System.Windows.Forms.TextBox();
            txttipodearea = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtArea).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLog
            // 
            btnLog.Location = new System.Drawing.Point(656, 282);
            btnLog.Name = "btnLog";
            btnLog.Size = new System.Drawing.Size(94, 29);
            btnLog.TabIndex = 15;
            btnLog.Text = "Abrir Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(623, 50);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(115, 29);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new System.Drawing.Point(525, 49);
            btnClean.Name = "btnClean";
            btnClean.Size = new System.Drawing.Size(94, 29);
            btnClean.TabIndex = 13;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // dtArea
            // 
            dtArea.AllowUserToAddRows = false;
            dtArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_AREA, NOMBRE_AREA, TIPO_AREA, REGISTRO });
            dtArea.Location = new System.Drawing.Point(35, 94);
            dtArea.Name = "dtArea";
            dtArea.RowHeadersWidth = 51;
            dtArea.RowTemplate.Height = 29;
            dtArea.Size = new System.Drawing.Size(703, 182);
            dtArea.TabIndex = 12;
            // 
            // ID_AREA
            // 
            ID_AREA.HeaderText = "ID AREA";
            ID_AREA.MinimumWidth = 6;
            ID_AREA.Name = "ID_AREA";
            ID_AREA.Width = 160;
            // 
            // NOMBRE_AREA
            // 
            NOMBRE_AREA.HeaderText = "NOMBRE AREA";
            NOMBRE_AREA.MinimumWidth = 6;
            NOMBRE_AREA.Name = "NOMBRE_AREA";
            NOMBRE_AREA.Width = 160;
            // 
            // TIPO_AREA
            // 
            TIPO_AREA.HeaderText = "TIPO DE AREA";
            TIPO_AREA.MinimumWidth = 6;
            TIPO_AREA.Name = "TIPO_AREA";
            TIPO_AREA.Width = 160;
            // 
            // REGISTRO
            // 
            REGISTRO.HeaderText = "REGISTRO";
            REGISTRO.MinimumWidth = 6;
            REGISTRO.Name = "REGISTRO";
            REGISTRO.Width = 160;
            // 
            // btnTodo
            // 
            btnTodo.Location = new System.Drawing.Point(430, 49);
            btnTodo.Name = "btnTodo";
            btnTodo.Size = new System.Drawing.Size(89, 29);
            btnTodo.TabIndex = 11;
            btnTodo.Text = "All";
            btnTodo.UseVisualStyleBackColor = true;
            btnTodo.Click += btnTodo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(283, 49);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(141, 29);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Search 🔎";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(34, 51);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(243, 27);
            txtBuscar.TabIndex = 9;
            // 
            // lblempleados
            // 
            lblempleados.AutoSize = true;
            lblempleados.Font = new System.Drawing.Font("Segoe UI", 29.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblempleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblempleados.Location = new System.Drawing.Point(21, -12);
            lblempleados.Name = "lblempleados";
            lblempleados.Size = new System.Drawing.Size(135, 66);
            lblempleados.TabIndex = 8;
            lblempleados.Text = "Area";
            // 
            // lblnombredearea
            // 
            lblnombredearea.AutoSize = true;
            lblnombredearea.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblnombredearea.Location = new System.Drawing.Point(18, 43);
            lblnombredearea.Name = "lblnombredearea";
            lblnombredearea.Size = new System.Drawing.Size(137, 23);
            lblnombredearea.TabIndex = 16;
            lblnombredearea.Text = "Nombre de Area";
            // 
            // lbltipodearea
            // 
            lbltipodearea.AutoSize = true;
            lbltipodearea.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbltipodearea.Location = new System.Drawing.Point(18, 94);
            lbltipodearea.Name = "lbltipodearea";
            lbltipodearea.Size = new System.Drawing.Size(107, 23);
            lbltipodearea.TabIndex = 17;
            lbltipodearea.Text = "Tipo de Area";
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
            // Añadir
            // 
            Añadir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Añadir.Location = new System.Drawing.Point(374, 98);
            Añadir.Name = "Añadir";
            Añadir.Size = new System.Drawing.Size(364, 29);
            Añadir.TabIndex = 19;
            Añadir.Text = "Agregar Nueva Area";
            Añadir.UseVisualStyleBackColor = true;
            Añadir.Click += Añadir_Click;
            // 
            // dtFechaRegistro
            // 
            dtFechaRegistro.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtFechaRegistro.Location = new System.Drawing.Point(452, 43);
            dtFechaRegistro.Name = "dtFechaRegistro";
            dtFechaRegistro.Size = new System.Drawing.Size(286, 28);
            dtFechaRegistro.TabIndex = 20;
            // 
            // txtnombrearea
            // 
            txtnombrearea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtnombrearea.Location = new System.Drawing.Point(180, 40);
            txtnombrearea.Name = "txtnombrearea";
            txtnombrearea.Size = new System.Drawing.Size(152, 32);
            txtnombrearea.TabIndex = 21;
            // 
            // txttipodearea
            // 
            txttipodearea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txttipodearea.Location = new System.Drawing.Point(180, 91);
            txttipodearea.Name = "txttipodearea";
            txttipodearea.Size = new System.Drawing.Size(152, 32);
            txttipodearea.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtFechaRegistro);
            groupBox1.Controls.Add(txttipodearea);
            groupBox1.Controls.Add(lblnombredearea);
            groupBox1.Controls.Add(txtnombrearea);
            groupBox1.Controls.Add(lbltipodearea);
            groupBox1.Controls.Add(lblregistro);
            groupBox1.Controls.Add(Añadir);
            groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(33, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(769, 151);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLog);
            groupBox2.Controls.Add(dtArea);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btnTodo);
            groupBox2.Controls.Add(btnClean);
            groupBox2.Controls.Add(txtBuscar);
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Location = new System.Drawing.Point(33, 214);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(769, 335);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            // 
            // MostrarTablaArea
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(829, 578);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblempleados);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MostrarTablaArea";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += MostrarTablaArea_Load;
            ((System.ComponentModel.ISupportInitialize)dtArea).EndInit();
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
        private System.Windows.Forms.DataGridView dtArea;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblempleados;
        private System.Windows.Forms.Label lblnombredearea;
        private System.Windows.Forms.Label lbltipodearea;
        private System.Windows.Forms.Label lblregistro;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.DateTimePicker dtFechaRegistro;
        private System.Windows.Forms.TextBox txtnombrearea;
        private System.Windows.Forms.TextBox txttipodearea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_AREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_AREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_AREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGISTRO;
    }
}