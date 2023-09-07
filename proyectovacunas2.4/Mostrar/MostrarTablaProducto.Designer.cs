namespace proyectovacunas2._4.Mostrar
{
    partial class MostrarTablaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarTablaProducto));
            btnLog = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            btnClean = new System.Windows.Forms.Button();
            dtProducto = new System.Windows.Forms.DataGridView();
            ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NOMBRE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FECHA_VENCIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EFECTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            INFORMACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnTodo = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            txtBuscar = new System.Windows.Forms.TextBox();
            lblempleados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dtProducto).BeginInit();
            SuspendLayout();
            // 
            // btnLog
            // 
            btnLog.Location = new System.Drawing.Point(757, 518);
            btnLog.Name = "btnLog";
            btnLog.Size = new System.Drawing.Size(94, 29);
            btnLog.TabIndex = 15;
            btnLog.Text = "Abrir Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(736, 78);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(115, 29);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new System.Drawing.Point(627, 78);
            btnClean.Name = "btnClean";
            btnClean.Size = new System.Drawing.Size(94, 29);
            btnClean.TabIndex = 13;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // dtProducto
            // 
            dtProducto.AllowUserToAddRows = false;
            dtProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_PRODUCTO, NOMBRE_PRODUCTO, FECHA_VENCIMIENTO, EFECTOS, INFORMACION });
            dtProducto.Location = new System.Drawing.Point(45, 137);
            dtProducto.Name = "dtProducto";
            dtProducto.RowHeadersWidth = 51;
            dtProducto.RowTemplate.Height = 29;
            dtProducto.Size = new System.Drawing.Size(806, 375);
            dtProducto.TabIndex = 12;
            // 
            // ID_PRODUCTO
            // 
            ID_PRODUCTO.HeaderText = "ID PRODUCTO";
            ID_PRODUCTO.MinimumWidth = 6;
            ID_PRODUCTO.Name = "ID_PRODUCTO";
            ID_PRODUCTO.Width = 125;
            // 
            // NOMBRE_PRODUCTO
            // 
            NOMBRE_PRODUCTO.HeaderText = "NOMBRE DEL PRODUCTO";
            NOMBRE_PRODUCTO.MinimumWidth = 6;
            NOMBRE_PRODUCTO.Name = "NOMBRE_PRODUCTO";
            NOMBRE_PRODUCTO.Width = 125;
            // 
            // FECHA_VENCIMIENTO
            // 
            FECHA_VENCIMIENTO.HeaderText = "FECHA DE VENCIMIENTO";
            FECHA_VENCIMIENTO.MinimumWidth = 6;
            FECHA_VENCIMIENTO.Name = "FECHA_VENCIMIENTO";
            FECHA_VENCIMIENTO.Width = 125;
            // 
            // EFECTOS
            // 
            EFECTOS.HeaderText = "EFECTOS";
            EFECTOS.MinimumWidth = 6;
            EFECTOS.Name = "EFECTOS";
            EFECTOS.Width = 125;
            // 
            // INFORMACION
            // 
            INFORMACION.HeaderText = "INFORMACIÓN";
            INFORMACION.MinimumWidth = 6;
            INFORMACION.Name = "INFORMACION";
            INFORMACION.Width = 240;
            // 
            // btnTodo
            // 
            btnTodo.Location = new System.Drawing.Point(514, 78);
            btnTodo.Name = "btnTodo";
            btnTodo.Size = new System.Drawing.Size(89, 29);
            btnTodo.TabIndex = 11;
            btnTodo.Text = "All";
            btnTodo.UseVisualStyleBackColor = true;
            btnTodo.Click += btnTodo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(354, 78);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(141, 29);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Search 🔎";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(45, 80);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(303, 27);
            txtBuscar.TabIndex = 9;
            // 
            // lblempleados
            // 
            lblempleados.AutoSize = true;
            lblempleados.Font = new System.Drawing.Font("Segoe UI", 29.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblempleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblempleados.Location = new System.Drawing.Point(31, 11);
            lblempleados.Name = "lblempleados";
            lblempleados.Size = new System.Drawing.Size(320, 66);
            lblempleados.TabIndex = 8;
            lblempleados.Text = "PRODUCTOS";
            // 
            // MostrarTablaProducto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(899, 572);
            Controls.Add(btnLog);
            Controls.Add(button1);
            Controls.Add(btnClean);
            Controls.Add(dtProducto);
            Controls.Add(btnTodo);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblempleados);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MostrarTablaProducto";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dtProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridView dtProducto;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblempleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_VENCIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EFECTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn INFORMACION;
    }
}