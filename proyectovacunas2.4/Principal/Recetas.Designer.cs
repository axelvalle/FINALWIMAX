namespace proyectovacunas2._4
{
    partial class Recetas
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
            lblcodreceta = new System.Windows.Forms.Label();
            lblprodreceta = new System.Windows.Forms.Label();
            lblcantidad = new System.Windows.Forms.Label();
            cbIDProducto = new System.Windows.Forms.ComboBox();
            cbPacienteCedula = new System.Windows.Forms.ComboBox();
            splitter1 = new System.Windows.Forms.Splitter();
            numUpDowCantidad = new System.Windows.Forms.NumericUpDown();
            btnregresar = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            btnreporte = new System.Windows.Forms.Button();
            btnlimpiar = new System.Windows.Forms.Button();
            Añadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numUpDowCantidad).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblcodreceta
            // 
            lblcodreceta.AutoSize = true;
            lblcodreceta.BackColor = System.Drawing.Color.Transparent;
            lblcodreceta.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblcodreceta.Location = new System.Drawing.Point(679, 274);
            lblcodreceta.Name = "lblcodreceta";
            lblcodreceta.Size = new System.Drawing.Size(122, 35);
            lblcodreceta.TabIndex = 0;
            lblcodreceta.Text = "Producto";
            // 
            // lblprodreceta
            // 
            lblprodreceta.AutoSize = true;
            lblprodreceta.BackColor = System.Drawing.Color.Transparent;
            lblprodreceta.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblprodreceta.Location = new System.Drawing.Point(679, 376);
            lblprodreceta.Name = "lblprodreceta";
            lblprodreceta.Size = new System.Drawing.Size(201, 35);
            lblprodreceta.TabIndex = 2;
            lblprodreceta.Text = "Paciente Cedula";
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.BackColor = System.Drawing.Color.Transparent;
            lblcantidad.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblcantidad.Location = new System.Drawing.Point(679, 324);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new System.Drawing.Size(119, 35);
            lblcantidad.TabIndex = 3;
            lblcantidad.Text = "Cantidad";
            // 
            // cbIDProducto
            // 
            cbIDProducto.FormattingEnabled = true;
            cbIDProducto.Location = new System.Drawing.Point(986, 281);
            cbIDProducto.Name = "cbIDProducto";
            cbIDProducto.Size = new System.Drawing.Size(288, 28);
            cbIDProducto.TabIndex = 4;
            // 
            // cbPacienteCedula
            // 
            cbPacienteCedula.FormattingEnabled = true;
            cbPacienteCedula.Location = new System.Drawing.Point(986, 384);
            cbPacienteCedula.Name = "cbPacienteCedula";
            cbPacienteCedula.Size = new System.Drawing.Size(288, 28);
            cbPacienteCedula.TabIndex = 6;
            // 
            // splitter1
            // 
            splitter1.Location = new System.Drawing.Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(4, 777);
            splitter1.TabIndex = 9;
            splitter1.TabStop = false;
            // 
            // numUpDowCantidad
            // 
            numUpDowCantidad.Location = new System.Drawing.Point(986, 328);
            numUpDowCantidad.Name = "numUpDowCantidad";
            numUpDowCantidad.Size = new System.Drawing.Size(288, 27);
            numUpDowCantidad.TabIndex = 10;
            // 
            // btnregresar
            // 
            btnregresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnregresar.BackColor = System.Drawing.Color.SteelBlue;
            btnregresar.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnregresar.ForeColor = System.Drawing.Color.White;
            btnregresar.Location = new System.Drawing.Point(43, 698);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new System.Drawing.Size(187, 53);
            btnregresar.TabIndex = 11;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(btnreporte);
            panel1.Controls.Add(btnlimpiar);
            panel1.Controls.Add(Añadir);
            panel1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            panel1.ForeColor = System.Drawing.Color.White;
            panel1.Location = new System.Drawing.Point(523, 646);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(754, 54);
            panel1.TabIndex = 72;
            // 
            // btnreporte
            // 
            btnreporte.BackColor = System.Drawing.Color.SteelBlue;
            btnreporte.Location = new System.Drawing.Point(3, 4);
            btnreporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnreporte.Name = "btnreporte";
            btnreporte.Size = new System.Drawing.Size(181, 44);
            btnreporte.TabIndex = 1;
            btnreporte.Text = "Reporte";
            btnreporte.UseVisualStyleBackColor = false;
            btnreporte.Click += btnreporte_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = System.Drawing.Color.SteelBlue;
            btnlimpiar.Location = new System.Drawing.Point(196, 3);
            btnlimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new System.Drawing.Size(368, 46);
            btnlimpiar.TabIndex = 2;
            btnlimpiar.Text = "Administrar";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // Añadir
            // 
            Añadir.BackColor = System.Drawing.Color.SteelBlue;
            Añadir.Location = new System.Drawing.Point(570, 3);
            Añadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Añadir.Name = "Añadir";
            Añadir.Size = new System.Drawing.Size(181, 46);
            Añadir.TabIndex = 0;
            Añadir.Text = "Añadir";
            Añadir.UseVisualStyleBackColor = false;
            Añadir.Click += Añadir_Click;
            // 
            // Recetas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Empleados;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1411, 777);
            Controls.Add(panel1);
            Controls.Add(btnregresar);
            Controls.Add(numUpDowCantidad);
            Controls.Add(splitter1);
            Controls.Add(cbPacienteCedula);
            Controls.Add(cbIDProducto);
            Controls.Add(lblcantidad);
            Controls.Add(lblprodreceta);
            Controls.Add(lblcodreceta);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            HelpButton = true;
            Name = "Recetas";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Recetas";
            Load += Recetas_Load;
            ((System.ComponentModel.ISupportInitialize)numUpDowCantidad).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblcodreceta;
        private System.Windows.Forms.Label lblprodreceta;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.ComboBox cbIDProducto;
        private System.Windows.Forms.ComboBox cbPacienteCedula;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.NumericUpDown numUpDowCantidad;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button Añadir;
    }
}