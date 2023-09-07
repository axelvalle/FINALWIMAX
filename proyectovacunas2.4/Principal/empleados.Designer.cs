namespace Empleados
{
    partial class frmEmpleados
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            lbledad = new System.Windows.Forms.Label();
            lbldept = new System.Windows.Forms.Label();
            lblcargo = new System.Windows.Forms.Label();
            btnMostrar = new System.Windows.Forms.Button();
            btnreporte = new System.Windows.Forms.Button();
            Añadir = new System.Windows.Forms.Button();
            txtdepartamento = new System.Windows.Forms.TextBox();
            txtedad = new System.Windows.Forms.TextBox();
            btnVolver = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            txtnombre1 = new System.Windows.Forms.TextBox();
            txtnombre2 = new System.Windows.Forms.TextBox();
            txtapellido2 = new System.Windows.Forms.TextBox();
            txtapellido1 = new System.Windows.Forms.TextBox();
            txtcedula = new System.Windows.Forms.TextBox();
            lblnae1 = new System.Windows.Forms.Label();
            lblname2 = new System.Windows.Forms.Label();
            lblapellido1 = new System.Windows.Forms.Label();
            lblsegundoapellido = new System.Windows.Forms.Label();
            lblced = new System.Windows.Forms.Label();
            lblsex = new System.Windows.Forms.Label();
            FemRadio = new System.Windows.Forms.RadioButton();
            MascRadio = new System.Windows.Forms.RadioButton();
            lblfecha = new System.Windows.Forms.Label();
            lblarea = new System.Windows.Forms.Label();
            lblActivo = new System.Windows.Forms.Label();
            txtusuario = new System.Windows.Forms.TextBox();
            txtcontrasena = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            chkActivo = new System.Windows.Forms.CheckBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            cbCargo = new System.Windows.Forms.ComboBox();
            cbArea = new System.Windows.Forms.ComboBox();
            dtpFechadeIngreso = new System.Windows.Forms.DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbledad
            // 
            lbledad.AutoSize = true;
            lbledad.BackColor = System.Drawing.Color.Transparent;
            lbledad.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbledad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbledad.Location = new System.Drawing.Point(645, 141);
            lbledad.Name = "lbledad";
            lbledad.Size = new System.Drawing.Size(58, 28);
            lbledad.TabIndex = 2;
            lbledad.Text = "Edad";
            // 
            // lbldept
            // 
            lbldept.AutoSize = true;
            lbldept.BackColor = System.Drawing.Color.Transparent;
            lbldept.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbldept.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbldept.Location = new System.Drawing.Point(645, 205);
            lbldept.Name = "lbldept";
            lbldept.Size = new System.Drawing.Size(152, 28);
            lbldept.TabIndex = 3;
            lbldept.Text = "Departamento";
            // 
            // lblcargo
            // 
            lblcargo.AutoSize = true;
            lblcargo.BackColor = System.Drawing.Color.Transparent;
            lblcargo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblcargo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblcargo.Location = new System.Drawing.Point(235, 451);
            lblcargo.Name = "lblcargo";
            lblcargo.Size = new System.Drawing.Size(66, 28);
            lblcargo.TabIndex = 5;
            lblcargo.Text = "Cargo";
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = System.Drawing.Color.LightSeaGreen;
            btnMostrar.Location = new System.Drawing.Point(206, 4);
            btnMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new System.Drawing.Size(266, 44);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Administrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnreporte
            // 
            btnreporte.BackColor = System.Drawing.Color.LightSeaGreen;
            btnreporte.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnreporte.Location = new System.Drawing.Point(496, 4);
            btnreporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnreporte.Name = "btnreporte";
            btnreporte.Size = new System.Drawing.Size(181, 44);
            btnreporte.TabIndex = 1;
            btnreporte.Text = "Reporte";
            btnreporte.UseVisualStyleBackColor = false;
            btnreporte.Click += btnreporte_Click;
            // 
            // Añadir
            // 
            Añadir.BackColor = System.Drawing.Color.LightSeaGreen;
            Añadir.Location = new System.Drawing.Point(9, 4);
            Añadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Añadir.Name = "Añadir";
            Añadir.Size = new System.Drawing.Size(181, 44);
            Añadir.TabIndex = 0;
            Añadir.Text = "Añadir";
            Añadir.UseVisualStyleBackColor = false;
            Añadir.Click += Añadir_Click;
            // 
            // txtdepartamento
            // 
            txtdepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtdepartamento.Location = new System.Drawing.Point(801, 209);
            txtdepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtdepartamento.Name = "txtdepartamento";
            txtdepartamento.Size = new System.Drawing.Size(195, 27);
            txtdepartamento.TabIndex = 9;
            // 
            // txtedad
            // 
            txtedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtedad.Location = new System.Drawing.Point(801, 148);
            txtedad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtedad.Name = "txtedad";
            txtedad.Size = new System.Drawing.Size(195, 27);
            txtedad.TabIndex = 8;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.LightSeaGreen;
            btnVolver.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnVolver.ForeColor = System.Drawing.Color.AliceBlue;
            btnVolver.Location = new System.Drawing.Point(27, 592);
            btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(157, 61);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Regresar";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(btnreporte);
            panel1.Controls.Add(btnMostrar);
            panel1.Controls.Add(Añadir);
            panel1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            panel1.ForeColor = System.Drawing.Color.White;
            panel1.Location = new System.Drawing.Point(274, 564);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(694, 54);
            panel1.TabIndex = 14;
            // 
            // txtnombre1
            // 
            txtnombre1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            txtnombre1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtnombre1.Location = new System.Drawing.Point(427, 212);
            txtnombre1.Name = "txtnombre1";
            txtnombre1.Size = new System.Drawing.Size(180, 27);
            txtnombre1.TabIndex = 32;
            // 
            // txtnombre2
            // 
            txtnombre2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            txtnombre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtnombre2.Location = new System.Drawing.Point(427, 272);
            txtnombre2.Name = "txtnombre2";
            txtnombre2.Size = new System.Drawing.Size(180, 27);
            txtnombre2.TabIndex = 31;
            // 
            // txtapellido2
            // 
            txtapellido2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            txtapellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtapellido2.Location = new System.Drawing.Point(427, 396);
            txtapellido2.Name = "txtapellido2";
            txtapellido2.Size = new System.Drawing.Size(180, 27);
            txtapellido2.TabIndex = 30;
            // 
            // txtapellido1
            // 
            txtapellido1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            txtapellido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtapellido1.Location = new System.Drawing.Point(427, 334);
            txtapellido1.Name = "txtapellido1";
            txtapellido1.Size = new System.Drawing.Size(180, 27);
            txtapellido1.TabIndex = 29;
            // 
            // txtcedula
            // 
            txtcedula.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            txtcedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtcedula.Location = new System.Drawing.Point(427, 155);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new System.Drawing.Size(180, 27);
            txtcedula.TabIndex = 28;
            toolTip1.SetToolTip(txtcedula, "Ingrese su Cedula de identidad con este formato \"00118090031023L\".");
            // 
            // lblnae1
            // 
            lblnae1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            lblnae1.AutoSize = true;
            lblnae1.BackColor = System.Drawing.Color.Transparent;
            lblnae1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblnae1.Location = new System.Drawing.Point(235, 212);
            lblnae1.Name = "lblnae1";
            lblnae1.Size = new System.Drawing.Size(170, 29);
            lblnae1.TabIndex = 27;
            lblnae1.Text = "Primer Nombre";
            // 
            // lblname2
            // 
            lblname2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            lblname2.AutoSize = true;
            lblname2.BackColor = System.Drawing.Color.Transparent;
            lblname2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblname2.Location = new System.Drawing.Point(235, 272);
            lblname2.Name = "lblname2";
            lblname2.Size = new System.Drawing.Size(187, 29);
            lblname2.TabIndex = 26;
            lblname2.Text = "Segundo Nombre";
            // 
            // lblapellido1
            // 
            lblapellido1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            lblapellido1.AutoSize = true;
            lblapellido1.BackColor = System.Drawing.Color.Transparent;
            lblapellido1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblapellido1.Location = new System.Drawing.Point(235, 328);
            lblapellido1.Name = "lblapellido1";
            lblapellido1.Size = new System.Drawing.Size(171, 29);
            lblapellido1.TabIndex = 25;
            lblapellido1.Text = "Primer Apellido";
            // 
            // lblsegundoapellido
            // 
            lblsegundoapellido.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            lblsegundoapellido.AutoSize = true;
            lblsegundoapellido.BackColor = System.Drawing.Color.Transparent;
            lblsegundoapellido.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblsegundoapellido.Location = new System.Drawing.Point(235, 392);
            lblsegundoapellido.Name = "lblsegundoapellido";
            lblsegundoapellido.Size = new System.Drawing.Size(188, 29);
            lblsegundoapellido.TabIndex = 24;
            lblsegundoapellido.Text = "Segundo Apellido";
            // 
            // lblced
            // 
            lblced.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            lblced.AutoSize = true;
            lblced.BackColor = System.Drawing.Color.Transparent;
            lblced.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblced.Location = new System.Drawing.Point(235, 148);
            lblced.Name = "lblced";
            lblced.Size = new System.Drawing.Size(82, 29);
            lblced.TabIndex = 23;
            lblced.Text = "Cedula";
            // 
            // lblsex
            // 
            lblsex.AutoSize = true;
            lblsex.BackColor = System.Drawing.Color.Transparent;
            lblsex.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblsex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblsex.Location = new System.Drawing.Point(653, 265);
            lblsex.Name = "lblsex";
            lblsex.Size = new System.Drawing.Size(57, 28);
            lblsex.TabIndex = 33;
            lblsex.Text = "Sexo";
            // 
            // FemRadio
            // 
            FemRadio.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            FemRadio.AutoSize = true;
            FemRadio.BackColor = System.Drawing.Color.Transparent;
            FemRadio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FemRadio.Location = new System.Drawing.Point(809, 292);
            FemRadio.Name = "FemRadio";
            FemRadio.Size = new System.Drawing.Size(134, 33);
            FemRadio.TabIndex = 35;
            FemRadio.TabStop = true;
            FemRadio.Text = "Femenino";
            FemRadio.UseVisualStyleBackColor = false;
            FemRadio.CheckedChanged += FemRadio_CheckedChanged_1;
            // 
            // MascRadio
            // 
            MascRadio.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            MascRadio.AutoSize = true;
            MascRadio.BackColor = System.Drawing.Color.Transparent;
            MascRadio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            MascRadio.Location = new System.Drawing.Point(809, 253);
            MascRadio.Name = "MascRadio";
            MascRadio.Size = new System.Drawing.Size(138, 33);
            MascRadio.TabIndex = 34;
            MascRadio.TabStop = true;
            MascRadio.Text = "Masculino";
            MascRadio.UseVisualStyleBackColor = false;
            MascRadio.CheckedChanged += MascRadio_CheckedChanged_1;
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.BackColor = System.Drawing.Color.Transparent;
            lblfecha.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblfecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblfecha.Location = new System.Drawing.Point(234, 509);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new System.Drawing.Size(172, 28);
            lblfecha.TabIndex = 36;
            lblfecha.Text = "Fecha de Ingreso";
            // 
            // lblarea
            // 
            lblarea.AutoSize = true;
            lblarea.BackColor = System.Drawing.Color.Transparent;
            lblarea.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblarea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblarea.Location = new System.Drawing.Point(654, 325);
            lblarea.Name = "lblarea";
            lblarea.Size = new System.Drawing.Size(57, 28);
            lblarea.TabIndex = 38;
            lblarea.Text = "Area";
            // 
            // lblActivo
            // 
            lblActivo.AutoSize = true;
            lblActivo.BackColor = System.Drawing.Color.Transparent;
            lblActivo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblActivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblActivo.Location = new System.Drawing.Point(653, 380);
            lblActivo.Name = "lblActivo";
            lblActivo.Size = new System.Drawing.Size(72, 28);
            lblActivo.TabIndex = 40;
            lblActivo.Text = "Activo";
            // 
            // txtusuario
            // 
            txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtusuario.Location = new System.Drawing.Point(810, 427);
            txtusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new System.Drawing.Size(195, 27);
            txtusuario.TabIndex = 46;
            // 
            // txtcontrasena
            // 
            txtcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtcontrasena.Location = new System.Drawing.Point(810, 468);
            txtcontrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.Size = new System.Drawing.Size(195, 27);
            txtcontrasena.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label1.Location = new System.Drawing.Point(654, 468);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 28);
            label1.TabIndex = 44;
            label1.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Location = new System.Drawing.Point(654, 423);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 28);
            label2.TabIndex = 43;
            label2.Text = "Usuario";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.BackColor = System.Drawing.Color.Azure;
            chkActivo.Location = new System.Drawing.Point(809, 389);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new System.Drawing.Size(18, 17);
            chkActivo.TabIndex = 47;
            chkActivo.UseVisualStyleBackColor = false;
            chkActivo.CheckedChanged += chkActivo_CheckedChanged_1;
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new System.Drawing.Point(427, 454);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new System.Drawing.Size(181, 28);
            cbCargo.TabIndex = 48;
            // 
            // cbArea
            // 
            cbArea.FormattingEnabled = true;
            cbArea.Location = new System.Drawing.Point(811, 334);
            cbArea.Name = "cbArea";
            cbArea.Size = new System.Drawing.Size(195, 28);
            cbArea.TabIndex = 49;
            // 
            // dtpFechadeIngreso
            // 
            dtpFechadeIngreso.Location = new System.Drawing.Point(427, 510);
            dtpFechadeIngreso.Name = "dtpFechadeIngreso";
            dtpFechadeIngreso.Size = new System.Drawing.Size(180, 27);
            dtpFechadeIngreso.TabIndex = 50;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DeepPink;
            BackgroundImage = proyectovacunas2._4.Properties.Resources.Imagen__9_;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1223, 665);
            Controls.Add(dtpFechadeIngreso);
            Controls.Add(cbArea);
            Controls.Add(cbCargo);
            Controls.Add(chkActivo);
            Controls.Add(txtusuario);
            Controls.Add(txtcontrasena);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblActivo);
            Controls.Add(lblarea);
            Controls.Add(lblfecha);
            Controls.Add(FemRadio);
            Controls.Add(MascRadio);
            Controls.Add(lblsex);
            Controls.Add(txtnombre1);
            Controls.Add(txtnombre2);
            Controls.Add(txtapellido2);
            Controls.Add(txtapellido1);
            Controls.Add(txtcedula);
            Controls.Add(lblnae1);
            Controls.Add(lblname2);
            Controls.Add(lblapellido1);
            Controls.Add(lblsegundoapellido);
            Controls.Add(lblced);
            Controls.Add(panel1);
            Controls.Add(btnVolver);
            Controls.Add(txtdepartamento);
            Controls.Add(txtedad);
            Controls.Add(lbledad);
            Controls.Add(lblcargo);
            Controls.Add(lbldept);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEmpleados";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Empleados";
            toolTip1.SetToolTip(this, "Ingrese su cedula de identidad con este formato \"0011809031023L\"");
            Load += frmEmpleados_Load_1;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.TextBox txtdepartamento;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtnombre1;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.TextBox txtapellido2;
        private System.Windows.Forms.TextBox txtapellido1;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label lblnae1;
        private System.Windows.Forms.Label lblname2;
        private System.Windows.Forms.Label lblapellido1;
        private System.Windows.Forms.Label lblsegundoapellido;
        private System.Windows.Forms.Label lblced;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.RadioButton FemRadio;
        private System.Windows.Forms.RadioButton MascRadio;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.DateTimePicker dtpFechadeIngreso;
    }
}
