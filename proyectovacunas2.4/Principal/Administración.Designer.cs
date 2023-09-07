namespace proyectovacunas2._4
{
    partial class Administración
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administración));
            btnarea = new System.Windows.Forms.Button();
            btncargo = new System.Windows.Forms.Button();
            btnpersona = new System.Windows.Forms.Button();
            btnsalario = new System.Windows.Forms.Button();
            btnregresar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnarea
            // 
            btnarea.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnarea.FlatAppearance.BorderSize = 4;
            btnarea.Font = new System.Drawing.Font("Calibri", 19.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnarea.Location = new System.Drawing.Point(212, 259);
            btnarea.Name = "btnarea";
            btnarea.Size = new System.Drawing.Size(372, 87);
            btnarea.TabIndex = 0;
            btnarea.Text = "Area";
            btnarea.UseVisualStyleBackColor = true;
            btnarea.Click += btnarea_Click;
            // 
            // btncargo
            // 
            btncargo.Font = new System.Drawing.Font("Calibri", 19.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btncargo.Location = new System.Drawing.Point(212, 371);
            btncargo.Name = "btncargo";
            btncargo.Size = new System.Drawing.Size(372, 87);
            btncargo.TabIndex = 1;
            btncargo.Text = "Cargo";
            btncargo.UseVisualStyleBackColor = true;
            btncargo.Click += btncargo_Click;
            // 
            // btnpersona
            // 
            btnpersona.Font = new System.Drawing.Font("Calibri", 19.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnpersona.Location = new System.Drawing.Point(617, 259);
            btnpersona.Name = "btnpersona";
            btnpersona.Size = new System.Drawing.Size(372, 87);
            btnpersona.TabIndex = 2;
            btnpersona.Text = "Persona";
            btnpersona.UseVisualStyleBackColor = true;
            btnpersona.Click += btnpersona_Click;
            // 
            // btnsalario
            // 
            btnsalario.Font = new System.Drawing.Font("Calibri", 19.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnsalario.Location = new System.Drawing.Point(617, 371);
            btnsalario.Name = "btnsalario";
            btnsalario.Size = new System.Drawing.Size(372, 87);
            btnsalario.TabIndex = 3;
            btnsalario.Text = "Salario";
            btnsalario.UseVisualStyleBackColor = true;
            btnsalario.Click += btnsalario_Click;
            // 
            // btnregresar
            // 
            btnregresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnregresar.BackColor = System.Drawing.Color.SteelBlue;
            btnregresar.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnregresar.ForeColor = System.Drawing.Color.White;
            btnregresar.Location = new System.Drawing.Point(12, 606);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new System.Drawing.Size(187, 53);
            btnregresar.TabIndex = 13;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // Administración
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.admin;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1196, 671);
            ControlBox = false;
            Controls.Add(btnregresar);
            Controls.Add(btnsalario);
            Controls.Add(btnpersona);
            Controls.Add(btncargo);
            Controls.Add(btnarea);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Administración";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Administración";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnarea;
        private System.Windows.Forms.Button btncargo;
        private System.Windows.Forms.Button btnpersona;
        private System.Windows.Forms.Button btnsalario;
        private System.Windows.Forms.Button btnregresar;
    }
}