namespace proyectovacunas2._4.Reportes
{
    partial class ReporteReceta
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
            dtReceta = new System.Windows.Forms.DataGridView();
            ID_RECETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PACIENTE_CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ID_PRODUCTO_RECETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtReceta).BeginInit();
            SuspendLayout();
            // 
            // btnpdf
            // 
            btnpdf.Location = new System.Drawing.Point(691, 663);
            btnpdf.Name = "btnpdf";
            btnpdf.Size = new System.Drawing.Size(225, 29);
            btnpdf.TabIndex = 17;
            btnpdf.Text = "Generar Archivo PDF";
            btnpdf.UseVisualStyleBackColor = true;
            btnpdf.Click += btnpdf_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new System.Drawing.Point(181, 663);
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
            label1.Location = new System.Drawing.Point(333, 188);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(412, 62);
            label1.TabIndex = 14;
            label1.Text = "REPORTE RECETA";
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblfecha.Location = new System.Drawing.Point(896, 50);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new System.Drawing.Size(115, 25);
            lblfecha.TabIndex = 13;
            lblfecha.Text = "Fecha y Hora";
            // 
            // lbltelf
            // 
            lbltelf.AutoSize = true;
            lbltelf.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbltelf.Location = new System.Drawing.Point(407, 107);
            lbltelf.Name = "lbltelf";
            lbltelf.Size = new System.Drawing.Size(222, 25);
            lbltelf.TabIndex = 12;
            lbltelf.Text = "Teléfono: +505 2250-6845";
            // 
            // lbldireccion
            // 
            lbldireccion.AutoSize = true;
            lbldireccion.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbldireccion.Location = new System.Drawing.Point(243, 82);
            lbldireccion.Name = "lbldireccion";
            lbldireccion.Size = new System.Drawing.Size(580, 25);
            lbldireccion.TabIndex = 11;
            lbldireccion.Text = "Dirección: Av. Universitaria, frente a la Academia de Danza Nicaragüense";
            // 
            // lblwimax
            // 
            lblwimax.AutoSize = true;
            lblwimax.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblwimax.Location = new System.Drawing.Point(243, 20);
            lblwimax.Name = "lblwimax";
            lblwimax.Size = new System.Drawing.Size(594, 62);
            lblwimax.TabIndex = 10;
            lblwimax.Text = "WIMAX CENTRO MEDICO";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.Imagen__25_;
            logo.Location = new System.Drawing.Point(30, 6);
            logo.Name = "logo";
            logo.Size = new System.Drawing.Size(167, 163);
            logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 9;
            logo.TabStop = false;
            // 
            // dtReceta
            // 
            dtReceta.AllowUserToAddRows = false;
            dtReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_RECETA, PACIENTE_CEDULA, ID_PRODUCTO_RECETA, CANTIDAD });
            dtReceta.Location = new System.Drawing.Point(181, 267);
            dtReceta.Name = "dtReceta";
            dtReceta.RowHeadersWidth = 51;
            dtReceta.RowTemplate.Height = 29;
            dtReceta.Size = new System.Drawing.Size(735, 375);
            dtReceta.TabIndex = 18;
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
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // ReporteReceta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1037, 704);
            Controls.Add(dtReceta);
            Controls.Add(btnpdf);
            Controls.Add(btnactualizar);
            Controls.Add(label1);
            Controls.Add(lblfecha);
            Controls.Add(lbltelf);
            Controls.Add(lbldireccion);
            Controls.Add(lblwimax);
            Controls.Add(logo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "ReporteReceta";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += ReporteReceta_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtReceta).EndInit();
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
        private System.Windows.Forms.DataGridView dtReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_RECETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACIENTE_CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO_RECETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.Timer timer1;
    }
}