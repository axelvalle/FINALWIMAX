namespace proyectovacunas2._4
{
    partial class frmproductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmproductos));
            nombre_prod = new System.Windows.Forms.Label();
            fecha_vencimiento = new System.Windows.Forms.Label();
            lblefectos = new System.Windows.Forms.Label();
            lblinfo = new System.Windows.Forms.Label();
            txtprodname = new System.Windows.Forms.TextBox();
            txtefectos = new System.Windows.Forms.TextBox();
            txtinfo = new System.Windows.Forms.TextBox();
            Salir = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            btnreporte = new System.Windows.Forms.Button();
            btnlimpiar = new System.Windows.Forms.Button();
            Añadir = new System.Windows.Forms.Button();
            dtFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nombre_prod
            // 
            nombre_prod.AutoSize = true;
            nombre_prod.BackColor = System.Drawing.Color.Transparent;
            nombre_prod.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            nombre_prod.Location = new System.Drawing.Point(322, 230);
            nombre_prod.Name = "nombre_prod";
            nombre_prod.Size = new System.Drawing.Size(216, 28);
            nombre_prod.TabIndex = 1;
            nombre_prod.Text = "Nombre del producto";
            // 
            // fecha_vencimiento
            // 
            fecha_vencimiento.AutoSize = true;
            fecha_vencimiento.BackColor = System.Drawing.Color.Transparent;
            fecha_vencimiento.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            fecha_vencimiento.Location = new System.Drawing.Point(322, 299);
            fecha_vencimiento.Name = "fecha_vencimiento";
            fecha_vencimiento.Size = new System.Drawing.Size(222, 28);
            fecha_vencimiento.TabIndex = 2;
            fecha_vencimiento.Text = "Fecha de vencimiento";
            // 
            // lblefectos
            // 
            lblefectos.AutoSize = true;
            lblefectos.BackColor = System.Drawing.Color.Transparent;
            lblefectos.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblefectos.Location = new System.Drawing.Point(322, 370);
            lblefectos.Name = "lblefectos";
            lblefectos.Size = new System.Drawing.Size(200, 28);
            lblefectos.TabIndex = 3;
            lblefectos.Text = "Efectos Secundarios";
            // 
            // lblinfo
            // 
            lblinfo.AutoSize = true;
            lblinfo.BackColor = System.Drawing.Color.Transparent;
            lblinfo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblinfo.Location = new System.Drawing.Point(322, 427);
            lblinfo.Name = "lblinfo";
            lblinfo.Size = new System.Drawing.Size(253, 28);
            lblinfo.TabIndex = 4;
            lblinfo.Text = "Información del producto";
            // 
            // txtprodname
            // 
            txtprodname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtprodname.Location = new System.Drawing.Point(598, 234);
            txtprodname.Name = "txtprodname";
            txtprodname.Size = new System.Drawing.Size(300, 27);
            txtprodname.TabIndex = 6;
            // 
            // txtefectos
            // 
            txtefectos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtefectos.Location = new System.Drawing.Point(598, 373);
            txtefectos.Name = "txtefectos";
            txtefectos.Size = new System.Drawing.Size(300, 27);
            txtefectos.TabIndex = 8;
            // 
            // txtinfo
            // 
            txtinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtinfo.Location = new System.Drawing.Point(598, 427);
            txtinfo.Multiline = true;
            txtinfo.Name = "txtinfo";
            txtinfo.Size = new System.Drawing.Size(300, 174);
            txtinfo.TabIndex = 9;
            // 
            // Salir
            // 
            Salir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            Salir.BackColor = System.Drawing.Color.CornflowerBlue;
            Salir.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            Salir.Location = new System.Drawing.Point(13, 685);
            Salir.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            Salir.Name = "Salir";
            Salir.Size = new System.Drawing.Size(188, 59);
            Salir.TabIndex = 10;
            Salir.Text = "Regresar";
            Salir.UseVisualStyleBackColor = false;
            Salir.Click += Salir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(btnreporte);
            panel1.Controls.Add(btnlimpiar);
            panel1.Controls.Add(Añadir);
            panel1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            panel1.ForeColor = System.Drawing.Color.White;
            panel1.Location = new System.Drawing.Point(365, 690);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(754, 54);
            panel1.TabIndex = 72;
            // 
            // btnreporte
            // 
            btnreporte.BackColor = System.Drawing.Color.SteelBlue;
            btnreporte.Location = new System.Drawing.Point(12, 8);
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
            btnlimpiar.Location = new System.Drawing.Point(216, 6);
            btnlimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new System.Drawing.Size(317, 46);
            btnlimpiar.TabIndex = 2;
            btnlimpiar.Text = "Administrar";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // Añadir
            // 
            Añadir.BackColor = System.Drawing.Color.SteelBlue;
            Añadir.Location = new System.Drawing.Point(549, 6);
            Añadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Añadir.Name = "Añadir";
            Añadir.Size = new System.Drawing.Size(181, 46);
            Añadir.TabIndex = 0;
            Añadir.Text = "Añadir";
            Añadir.UseVisualStyleBackColor = false;
            Añadir.Click += Añadir_Click;
            // 
            // dtFechaVencimiento
            // 
            dtFechaVencimiento.Location = new System.Drawing.Point(598, 300);
            dtFechaVencimiento.Name = "dtFechaVencimiento";
            dtFechaVencimiento.Size = new System.Drawing.Size(300, 27);
            dtFechaVencimiento.TabIndex = 73;
            // 
            // frmproductos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.productos;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1366, 766);
            Controls.Add(dtFechaVencimiento);
            Controls.Add(panel1);
            Controls.Add(Salir);
            Controls.Add(txtinfo);
            Controls.Add(txtefectos);
            Controls.Add(txtprodname);
            Controls.Add(lblinfo);
            Controls.Add(lblefectos);
            Controls.Add(fecha_vencimiento);
            Controls.Add(nombre_prod);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmproductos";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Productos";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label nombre_prod;
        private System.Windows.Forms.Label fecha_vencimiento;
        private System.Windows.Forms.Label lblefectos;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.TextBox txtprodname;
        private System.Windows.Forms.TextBox txtefectos;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.DateTimePicker dtFechaVencimiento;
    }
}