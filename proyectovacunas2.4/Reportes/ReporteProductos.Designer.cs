namespace proyectovacunas2._4.Reportes
{
    partial class ReporteProductos
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
            components = new System.ComponentModel.Container();
            btnpdf = new System.Windows.Forms.Button();
            btnactualizar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            lblfecha = new System.Windows.Forms.Label();
            lbltelf = new System.Windows.Forms.Label();
            lbldireccion = new System.Windows.Forms.Label();
            lblwimax = new System.Windows.Forms.Label();
            logo = new System.Windows.Forms.PictureBox();
            dtProducto = new System.Windows.Forms.DataGridView();
            ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NOMBRE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FECHA_VENCIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EFECTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            INFORMACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtProducto).BeginInit();
            SuspendLayout();
            // 
            // btnpdf
            // 
            btnpdf.Location = new System.Drawing.Point(731, 654);
            btnpdf.Name = "btnpdf";
            btnpdf.Size = new System.Drawing.Size(225, 29);
            btnpdf.TabIndex = 17;
            btnpdf.Text = "Generar Archivo PDF";
            btnpdf.UseVisualStyleBackColor = true;
            btnpdf.Click += btnpdf_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new System.Drawing.Point(150, 654);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new System.Drawing.Size(225, 29);
            btnactualizar.TabIndex = 16;
            btnactualizar.Text = "Exportar a Excel";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(309, 208);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(526, 62);
            label1.TabIndex = 14;
            label1.Text = "REPORTE PRODUCTOS";
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblfecha.Location = new System.Drawing.Point(892, 80);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new System.Drawing.Size(115, 25);
            lblfecha.TabIndex = 13;
            lblfecha.Text = "Fecha y Hora";
            // 
            // lbltelf
            // 
            lbltelf.AutoSize = true;
            lbltelf.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbltelf.Location = new System.Drawing.Point(456, 130);
            lbltelf.Name = "lbltelf";
            lbltelf.Size = new System.Drawing.Size(222, 25);
            lbltelf.TabIndex = 12;
            lbltelf.Text = "Teléfono: +505 2250-6845";
            // 
            // lbldireccion
            // 
            lbldireccion.AutoSize = true;
            lbldireccion.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbldireccion.Location = new System.Drawing.Point(292, 105);
            lbldireccion.Name = "lbldireccion";
            lbldireccion.Size = new System.Drawing.Size(580, 25);
            lbldireccion.TabIndex = 11;
            lbldireccion.Text = "Dirección: Av. Universitaria, frente a la Academia de Danza Nicaragüense";
            // 
            // lblwimax
            // 
            lblwimax.AutoSize = true;
            lblwimax.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblwimax.Location = new System.Drawing.Point(292, 43);
            lblwimax.Name = "lblwimax";
            lblwimax.Size = new System.Drawing.Size(594, 62);
            lblwimax.TabIndex = 10;
            lblwimax.Text = "WIMAX CENTRO MEDICO";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.Imagen__25_;
            logo.Location = new System.Drawing.Point(33, 9);
            logo.Name = "logo";
            logo.Size = new System.Drawing.Size(183, 176);
            logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 9;
            logo.TabStop = false;
            // 
            // dtProducto
            // 
            dtProducto.AllowUserToAddRows = false;
            dtProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_PRODUCTO, NOMBRE_PRODUCTO, FECHA_VENCIMIENTO, EFECTOS, INFORMACION });
            dtProducto.Location = new System.Drawing.Point(150, 273);
            dtProducto.Name = "dtProducto";
            dtProducto.RowHeadersWidth = 51;
            dtProducto.RowTemplate.Height = 29;
            dtProducto.Size = new System.Drawing.Size(806, 375);
            dtProducto.TabIndex = 18;
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
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // ReporteProductos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1075, 709);
            Controls.Add(dtProducto);
            Controls.Add(btnpdf);
            Controls.Add(btnactualizar);
            Controls.Add(label1);
            Controls.Add(lblfecha);
            Controls.Add(lbltelf);
            Controls.Add(lbldireccion);
            Controls.Add(lblwimax);
            Controls.Add(logo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "ReporteProductos";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ReporteProductos";
            Load += ReporteProductos_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lbltelf;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblwimax;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.DataGridView dtProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_VENCIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EFECTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn INFORMACION;
        private System.Windows.Forms.Timer timer1;
    }
}