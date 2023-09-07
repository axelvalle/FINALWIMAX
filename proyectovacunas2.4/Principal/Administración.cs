using proyectovacunas2._4.Mostrar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyectovacunas2._4
{
    public partial class Administración : Form
    {
        public Administración()
        {
            InitializeComponent();
        }

        private void btnarea_Click(object sender, EventArgs e)
        {
            new MostrarTablaArea().Show();
        }

        private void btncargo_Click(object sender, EventArgs e)
        {
            new MostrarTablaCargo().Show();
        }

        private void btnsalario_Click(object sender, EventArgs e)
        {
            new MostrarTablaSalarios_cargo().Show();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmPrincipal().Show();
        }

        private void btnpersona_Click(object sender, EventArgs e)
        {
            new MostrarTablaPersona().Show();
        }
    }
}
