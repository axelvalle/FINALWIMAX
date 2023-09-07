

using Empleados;
using Log_Negocio;
using proyectovacunas2._4.Mostrar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectovacunas2._4
{
    public partial class frmPrincipal : Form
    {
        string usuario = Usuarios.UsuarioActual;
        string cargo = "";
        public frmPrincipal()
        {
            InitializeComponent();
            design();
        }
        private void design()
        {
            panelsubmenu.Visible = false;
            panelsubmenuatencionmed.Visible = false;
            panelsubmenucontable.Visible = false;
        }
        private void esconder()
        {
            if (panelsubmenu.Visible == true)
            {
                panelsubmenu.Visible = false;
            }



        }
        public void esconder2()
        {
            if (panelsubmenuatencionmed.Visible == true)
            {
                panelsubmenuatencionmed.Visible = false;
            }
        }
        public void esconder3()
        {
            if (panelsubmenucontable.Visible == true)
            {
                panelsubmenucontable.Visible = false;
            }
        }
        private void show(Panel submenu)
        {
            if (panelsubmenu.Visible == false)
            {

                esconder();
                panelsubmenu.Visible = true;

            }
            else
            {
                panelsubmenu.Visible = false;
            }
        }
        private void show1(Panel submenuatencionmed)
        {
            if (panelsubmenuatencionmed.Visible == false)
            {

                esconder2();
                panelsubmenuatencionmed.Visible = true;

            }
            else
            {
                panelsubmenuatencionmed.Visible = false;
            }



        }
        private void show2(Panel submenucontable)
        {
            if (panelsubmenucontable.Visible == false)
            {

                esconder3();
                panelsubmenucontable.Visible = true;

            }
            else
            {
                panelsubmenucontable.Visible = false;
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Usuarios().Show();


        }
        private void btnEmp_Click(object sender, EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            empleados.Show();
            Hide();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Pacientes v = new Pacientes();
            v.Show();
            Hide();



        }

        private void btnJornadas_Click(object sender, EventArgs e)
        {
            frmproductos c = new frmproductos();
            c.Show();

            Hide();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmconsultas b = new frmconsultas();
            b.Show();
            Hide();


        }

        private void btnAdminVac_Click(object sender, EventArgs e)
        {
            Recetas v = new Recetas();
            v.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Hide();
        }

        private void btnadministracion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Administración().Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {


            if (Usuarios.IDCargo == 1)
            {
                // Ocultar btnpersona y btncontabilidad
                btnpersonas.Visible = false;
                btncontabilidad.Visible = false;
                cargo = "Doctor: ";
            }
            else if (Usuarios.IDCargo == 6)
            {
                // Ocultar btnatencionmedica
                btnatencionmedica.Visible = false;
                cargo = "Contadora: ";
            }
            else if (Usuarios.IDCargo == 7)
            {
                cargo = "Administrador: ";

            }

            lblUsuarioLogeado.Text = cargo + usuario;

        }

        private void btndespleagar_Click(object sender, EventArgs e)
        {
            show(panelsubmenu);

        }

        private void btn_Click(object sender, EventArgs e)
        {
            show1(panelsubmenuatencionmed);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            show2(panelsubmenucontable);
        }

        private void btncitas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrameCita().Show();
        }
    }
}
