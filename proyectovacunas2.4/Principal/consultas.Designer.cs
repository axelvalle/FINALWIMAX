using System.Windows.Forms;

namespace proyectovacunas2._4
{
    partial class frmconsultas
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
            txtoxigeno = new TextBox();
            lbloxigeno = new Label();
            txtdiagnostico = new TextBox();
            lblempleadoced = new Label();
            lblcedpatient = new Label();
            lblregconsulta = new Label();
            lbldiagnostrico = new Label();
            txtpresionsangre = new TextBox();
            txtpeso = new TextBox();
            txtemperatura = new TextBox();
            lbltemperature = new Label();
            txtfrecardiaca = new TextBox();
            lblfreccardiaca = new Label();
            lblpresionsanguinea = new Label();
            lblpeso = new Label();
            lblhipotiroidismo = new Label();
            Pulso = new Label();
            txtpulso = new TextBox();
            panel1 = new Panel();
            btnreporte = new Button();
            btnlimpiar = new Button();
            Añadir = new Button();
            btnregresar = new Button();
            rdbtnSi = new RadioButton();
            rdbtnNo = new RadioButton();
            cbEmpleado = new ComboBox();
            cbPaciente = new ComboBox();
            dtRegistroConsulta = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtoxigeno
            // 
            txtoxigeno.BorderStyle = BorderStyle.FixedSingle;
            txtoxigeno.Location = new System.Drawing.Point(998, 241);
            txtoxigeno.Margin = new Padding(3, 2, 3, 2);
            txtoxigeno.Name = "txtoxigeno";
            txtoxigeno.Size = new System.Drawing.Size(195, 32);
            txtoxigeno.TabIndex = 65;
            txtoxigeno.TextChanged += txtoxigeno_TextChanged;
            // 
            // lbloxigeno
            // 
            lbloxigeno.AutoSize = true;
            lbloxigeno.BackColor = System.Drawing.Color.Transparent;
            lbloxigeno.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbloxigeno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbloxigeno.Location = new System.Drawing.Point(792, 241);
            lbloxigeno.Name = "lbloxigeno";
            lbloxigeno.Size = new System.Drawing.Size(92, 28);
            lbloxigeno.TabIndex = 64;
            lbloxigeno.Text = "Oxigeno";
            // 
            // txtdiagnostico
            // 
            txtdiagnostico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtdiagnostico.BorderStyle = BorderStyle.FixedSingle;
            txtdiagnostico.Location = new System.Drawing.Point(512, 353);
            txtdiagnostico.Multiline = true;
            txtdiagnostico.Name = "txtdiagnostico";
            txtdiagnostico.Size = new System.Drawing.Size(254, 213);
            txtdiagnostico.TabIndex = 58;
            // 
            // lblempleadoced
            // 
            lblempleadoced.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblempleadoced.AutoSize = true;
            lblempleadoced.BackColor = System.Drawing.Color.Transparent;
            lblempleadoced.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblempleadoced.Location = new System.Drawing.Point(318, 179);
            lblempleadoced.Name = "lblempleadoced";
            lblempleadoced.Size = new System.Drawing.Size(188, 29);
            lblempleadoced.TabIndex = 55;
            lblempleadoced.Text = "Cedula Empleado";
            // 
            // lblcedpatient
            // 
            lblcedpatient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblcedpatient.AutoSize = true;
            lblcedpatient.BackColor = System.Drawing.Color.Transparent;
            lblcedpatient.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblcedpatient.Location = new System.Drawing.Point(318, 239);
            lblcedpatient.Name = "lblcedpatient";
            lblcedpatient.Size = new System.Drawing.Size(173, 29);
            lblcedpatient.TabIndex = 54;
            lblcedpatient.Text = "Cedula paciente";
            // 
            // lblregconsulta
            // 
            lblregconsulta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblregconsulta.AutoSize = true;
            lblregconsulta.BackColor = System.Drawing.Color.Transparent;
            lblregconsulta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblregconsulta.Location = new System.Drawing.Point(318, 295);
            lblregconsulta.Name = "lblregconsulta";
            lblregconsulta.Size = new System.Drawing.Size(186, 29);
            lblregconsulta.TabIndex = 53;
            lblregconsulta.Text = "Registro consulta";
            // 
            // lbldiagnostrico
            // 
            lbldiagnostrico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbldiagnostrico.AutoSize = true;
            lbldiagnostrico.BackColor = System.Drawing.Color.Transparent;
            lbldiagnostrico.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbldiagnostrico.Location = new System.Drawing.Point(318, 353);
            lbldiagnostrico.Name = "lbldiagnostrico";
            lbldiagnostrico.Size = new System.Drawing.Size(130, 29);
            lbldiagnostrico.TabIndex = 52;
            lbldiagnostrico.Text = "Diagnostico";
            // 
            // txtpresionsangre
            // 
            txtpresionsangre.BorderStyle = BorderStyle.FixedSingle;
            txtpresionsangre.Location = new System.Drawing.Point(998, 182);
            txtpresionsangre.Margin = new Padding(3, 2, 3, 2);
            txtpresionsangre.Name = "txtpresionsangre";
            txtpresionsangre.Size = new System.Drawing.Size(195, 32);
            txtpresionsangre.TabIndex = 50;
            // 
            // txtpeso
            // 
            txtpeso.BorderStyle = BorderStyle.FixedSingle;
            txtpeso.Location = new System.Drawing.Point(998, 355);
            txtpeso.Margin = new Padding(3, 2, 3, 2);
            txtpeso.Name = "txtpeso";
            txtpeso.Size = new System.Drawing.Size(195, 32);
            txtpeso.TabIndex = 49;
            // 
            // txtemperatura
            // 
            txtemperatura.BorderStyle = BorderStyle.FixedSingle;
            txtemperatura.Location = new System.Drawing.Point(998, 416);
            txtemperatura.Margin = new Padding(3, 2, 3, 2);
            txtemperatura.Name = "txtemperatura";
            txtemperatura.Size = new System.Drawing.Size(195, 32);
            txtemperatura.TabIndex = 48;
            // 
            // lbltemperature
            // 
            lbltemperature.AutoSize = true;
            lbltemperature.BackColor = System.Drawing.Color.Transparent;
            lbltemperature.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbltemperature.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbltemperature.Location = new System.Drawing.Point(792, 423);
            lbltemperature.Name = "lbltemperature";
            lbltemperature.Size = new System.Drawing.Size(132, 28);
            lbltemperature.TabIndex = 45;
            lbltemperature.Text = "Temperatura";
            // 
            // txtfrecardiaca
            // 
            txtfrecardiaca.BorderStyle = BorderStyle.FixedSingle;
            txtfrecardiaca.Location = new System.Drawing.Point(998, 294);
            txtfrecardiaca.Margin = new Padding(3, 2, 3, 2);
            txtfrecardiaca.Name = "txtfrecardiaca";
            txtfrecardiaca.Size = new System.Drawing.Size(195, 32);
            txtfrecardiaca.TabIndex = 47;
            // 
            // lblfreccardiaca
            // 
            lblfreccardiaca.AutoSize = true;
            lblfreccardiaca.BackColor = System.Drawing.Color.Transparent;
            lblfreccardiaca.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblfreccardiaca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblfreccardiaca.Location = new System.Drawing.Point(792, 300);
            lblfreccardiaca.Name = "lblfreccardiaca";
            lblfreccardiaca.Size = new System.Drawing.Size(200, 28);
            lblfreccardiaca.TabIndex = 43;
            lblfreccardiaca.Text = "Frecuencia cardiaca";
            // 
            // lblpresionsanguinea
            // 
            lblpresionsanguinea.AutoSize = true;
            lblpresionsanguinea.BackColor = System.Drawing.Color.Transparent;
            lblpresionsanguinea.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblpresionsanguinea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblpresionsanguinea.Location = new System.Drawing.Point(792, 182);
            lblpresionsanguinea.Name = "lblpresionsanguinea";
            lblpresionsanguinea.Size = new System.Drawing.Size(184, 28);
            lblpresionsanguinea.TabIndex = 46;
            lblpresionsanguinea.Text = "Presión sanguinea";
            // 
            // lblpeso
            // 
            lblpeso.AutoSize = true;
            lblpeso.BackColor = System.Drawing.Color.Transparent;
            lblpeso.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblpeso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblpeso.Location = new System.Drawing.Point(792, 357);
            lblpeso.Name = "lblpeso";
            lblpeso.Size = new System.Drawing.Size(57, 28);
            lblpeso.TabIndex = 44;
            lblpeso.Text = "Peso";
            // 
            // lblhipotiroidismo
            // 
            lblhipotiroidismo.AutoSize = true;
            lblhipotiroidismo.BackColor = System.Drawing.Color.Transparent;
            lblhipotiroidismo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblhipotiroidismo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblhipotiroidismo.Location = new System.Drawing.Point(792, 528);
            lblhipotiroidismo.Name = "lblhipotiroidismo";
            lblhipotiroidismo.Size = new System.Drawing.Size(154, 28);
            lblhipotiroidismo.TabIndex = 67;
            lblhipotiroidismo.Text = "Hipotiroidismo";
            // 
            // Pulso
            // 
            Pulso.AutoSize = true;
            Pulso.BackColor = System.Drawing.Color.Transparent;
            Pulso.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Pulso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Pulso.Location = new System.Drawing.Point(792, 472);
            Pulso.Name = "Pulso";
            Pulso.Size = new System.Drawing.Size(63, 28);
            Pulso.TabIndex = 66;
            Pulso.Text = "Pulso";
            // 
            // txtpulso
            // 
            txtpulso.BorderStyle = BorderStyle.FixedSingle;
            txtpulso.Location = new System.Drawing.Point(998, 471);
            txtpulso.Margin = new Padding(3, 2, 3, 2);
            txtpulso.Name = "txtpulso";
            txtpulso.Size = new System.Drawing.Size(195, 32);
            txtpulso.TabIndex = 69;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(btnreporte);
            panel1.Controls.Add(btnlimpiar);
            panel1.Controls.Add(Añadir);
            panel1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            panel1.ForeColor = System.Drawing.Color.White;
            panel1.Location = new System.Drawing.Point(415, 662);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(754, 54);
            panel1.TabIndex = 70;
            // 
            // btnreporte
            // 
            btnreporte.BackColor = System.Drawing.Color.LightSeaGreen;
            btnreporte.Location = new System.Drawing.Point(13, 4);
            btnreporte.Margin = new Padding(3, 2, 3, 2);
            btnreporte.Name = "btnreporte";
            btnreporte.Size = new System.Drawing.Size(181, 44);
            btnreporte.TabIndex = 1;
            btnreporte.Text = "Reporte";
            btnreporte.UseVisualStyleBackColor = false;
            btnreporte.Visible = false;
            btnreporte.Click += btnreporte_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = System.Drawing.Color.LightSeaGreen;
            btnlimpiar.Location = new System.Drawing.Point(223, 4);
            btnlimpiar.Margin = new Padding(3, 2, 3, 2);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new System.Drawing.Size(286, 46);
            btnlimpiar.TabIndex = 2;
            btnlimpiar.Text = "Administrar";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // Añadir
            // 
            Añadir.BackColor = System.Drawing.Color.LightSeaGreen;
            Añadir.Location = new System.Drawing.Point(525, 4);
            Añadir.Margin = new Padding(3, 2, 3, 2);
            Añadir.Name = "Añadir";
            Añadir.Size = new System.Drawing.Size(211, 46);
            Añadir.TabIndex = 0;
            Añadir.Text = "Añadir";
            Añadir.UseVisualStyleBackColor = false;
            Añadir.Click += Añadir_Click;
            // 
            // btnregresar
            // 
            btnregresar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnregresar.BackColor = System.Drawing.Color.SteelBlue;
            btnregresar.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnregresar.ForeColor = System.Drawing.Color.White;
            btnregresar.Location = new System.Drawing.Point(12, 663);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new System.Drawing.Size(187, 53);
            btnregresar.TabIndex = 12;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // rdbtnSi
            // 
            rdbtnSi.AutoSize = true;
            rdbtnSi.Location = new System.Drawing.Point(997, 529);
            rdbtnSi.Name = "rdbtnSi";
            rdbtnSi.Size = new System.Drawing.Size(45, 28);
            rdbtnSi.TabIndex = 71;
            rdbtnSi.TabStop = true;
            rdbtnSi.Text = "Si";
            rdbtnSi.UseVisualStyleBackColor = true;
            rdbtnSi.CheckedChanged += rdbtnSi_CheckedChanged;
            // 
            // rdbtnNo
            // 
            rdbtnNo.AutoSize = true;
            rdbtnNo.Location = new System.Drawing.Point(1148, 529);
            rdbtnNo.Name = "rdbtnNo";
            rdbtnNo.Size = new System.Drawing.Size(55, 28);
            rdbtnNo.TabIndex = 72;
            rdbtnNo.TabStop = true;
            rdbtnNo.Text = "No";
            rdbtnNo.UseVisualStyleBackColor = true;
            rdbtnNo.CheckedChanged += rdbtnNo_CheckedChanged;
            // 
            // cbEmpleado
            // 
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Location = new System.Drawing.Point(512, 179);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new System.Drawing.Size(254, 32);
            cbEmpleado.TabIndex = 73;
            // 
            // cbPaciente
            // 
            cbPaciente.FormattingEnabled = true;
            cbPaciente.Location = new System.Drawing.Point(512, 237);
            cbPaciente.Name = "cbPaciente";
            cbPaciente.Size = new System.Drawing.Size(254, 32);
            cbPaciente.TabIndex = 74;
            // 
            // dtRegistroConsulta
            // 
            dtRegistroConsulta.Location = new System.Drawing.Point(512, 294);
            dtRegistroConsulta.Name = "dtRegistroConsulta";
            dtRegistroConsulta.Size = new System.Drawing.Size(254, 32);
            dtRegistroConsulta.TabIndex = 75;
            // 
            // frmconsultas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.consultas1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1281, 728);
            Controls.Add(dtRegistroConsulta);
            Controls.Add(cbPaciente);
            Controls.Add(cbEmpleado);
            Controls.Add(rdbtnNo);
            Controls.Add(rdbtnSi);
            Controls.Add(btnregresar);
            Controls.Add(panel1);
            Controls.Add(txtpulso);
            Controls.Add(lblhipotiroidismo);
            Controls.Add(Pulso);
            Controls.Add(txtoxigeno);
            Controls.Add(lbloxigeno);
            Controls.Add(txtdiagnostico);
            Controls.Add(lblempleadoced);
            Controls.Add(lblcedpatient);
            Controls.Add(lblregconsulta);
            Controls.Add(lbldiagnostrico);
            Controls.Add(txtpresionsangre);
            Controls.Add(txtpeso);
            Controls.Add(txtemperatura);
            Controls.Add(lbltemperature);
            Controls.Add(txtfrecardiaca);
            Controls.Add(lblfreccardiaca);
            Controls.Add(lblpresionsanguinea);
            Controls.Add(lblpeso);
            DoubleBuffered = true;
            Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmconsultas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultas ";
            Load += frmconsultas_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton radiono;
        private System.Windows.Forms.RadioButton radiosi;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.TextBox txtoxigeno;
        private Label lbloxigeno;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.RadioButton FemRadio;
        private System.Windows.Forms.RadioButton MascRadio;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.TextBox txtdiagnostico;
        private System.Windows.Forms.Label lblempleadoced;
        private System.Windows.Forms.Label lblcedpatient;
        private System.Windows.Forms.Label lblregconsulta;
        private System.Windows.Forms.Label lbldiagnostrico;
        private System.Windows.Forms.TextBox txtpresionsangre;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtemperatura;
        private System.Windows.Forms.Label lbltemperature;
        private System.Windows.Forms.TextBox txtfrecardiaca;
        private Label lblfreccardiaca;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblpresionsanguinea;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblhipotiroidismo;
        private System.Windows.Forms.Label Pulso;
        private System.Windows.Forms.TextBox txtpulso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.Button btnregresar;
        private RadioButton rdbtnSi;
        private RadioButton rdbtnNo;
        private ComboBox cbEmpleado;
        private ComboBox cbPaciente;
        private DateTimePicker dtRegistroConsulta;
    }
}