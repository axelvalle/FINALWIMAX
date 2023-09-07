using Microsoft.IdentityModel.Tokens;
using proyectovacunas2._4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Log_Negocio;
using proyectovacunas2._4.Mostrar;
using proyectovacunas2._4.Reportes;

namespace Empleados
{

    public partial class frmEmpleados : Form
    {
        CapaBD.ConexionBD _con = new CapaBD.ConexionBD();
        byte idactivo = 0;
        char idsexo = 'M';
        public frmEmpleados()
        {
            InitializeComponent();


        }



        // Método para obtener el ID de un área a partir del nombre seleccionado en un ComboBox
        public int ObtenerIdAreaPorNombre(string nombreArea)
        {
            int idArea = -1; // Valor predeterminado en caso de que no se encuentre el nombre del área

            using (_con.cmd = new System.Data.SqlClient.SqlCommand())
            {
                _con.cmd.Connection = _con.cn; // Asignar la conexión desde la instancia _con
                _con.cmd.Connection.Open();

                string query = "SELECT ID_AREA FROM AREA WHERE NOMBRE_AREA = @NombreArea";
                _con.cmd.CommandText = query;
                _con.cmd.Parameters.AddWithValue("@NombreArea", nombreArea);

                using (_con.rd = _con.cmd.ExecuteReader())
                {
                    if (_con.rd.Read())
                    {
                        idArea = _con.rd.GetInt32(0); // Suponiendo que el ID_AREA es la primera columna en el resultado
                    }
                }
            }
            _con.cmd.Connection.Close();
            return idArea;
        }

        // Método para obtener el ID de un cargo a partir del nombre seleccionado en un ComboBox
        public int ObtenerIdCargoPorNombre(string nombreCargo)
        {
            int idCargo = -1; // Valor predeterminado en caso de que no se encuentre el nombre del cargo

            using (_con.cmd = new System.Data.SqlClient.SqlCommand())
            {
                _con.cmd.Connection = _con.cn; // Asignar la conexión desde la instancia _con
                _con.cmd.Connection.Open();

                string query = "SELECT ID_CARGO FROM CARGO WHERE NOMBRE_CARGO = @NombreCargo";
                _con.cmd.CommandText = query;
                _con.cmd.Parameters.AddWithValue("@NombreCargo", nombreCargo);

                using (_con.rd = _con.cmd.ExecuteReader())
                {
                    if (_con.rd.Read())
                    {
                        idCargo = _con.rd.GetInt32(0); // Suponiendo que el ID_CARGO es la primera columna en el resultado
                    }
                }
            }
            _con.cmd.Connection.Close();
            return idCargo;
        }




        public void AgregarPersona(Empleado empleado)
        {
            try
            {
                using (_con.cmd = new System.Data.SqlClient.SqlCommand())
                {
                    _con.cmd.Connection = _con.cn; // Asignar la conexión desde la instancia _con
                    _con.cmd.Connection.Open();

                    // Insertar datos en la tabla Persona
                    _con.cmd.CommandText =
                        "INSERT INTO PERSONA (CEDULA, NOMBRE_1, NOMBRE_2, APELLIDO_1, APELLIDO_2, EDAD, SEXO, DEPARTAMENTO) " +
                        "VALUES (@Cedula, @Nombre1, @Nombre2, @Apellido1, @Apellido2, @Edad, @Sexo, @Departamento)";
                    _con.cmd.Parameters.AddWithValue("@Cedula", empleado.Cedula);
                    _con.cmd.Parameters.AddWithValue("@Nombre1", empleado.Nombre1);
                    _con.cmd.Parameters.AddWithValue("@Nombre2", empleado.Nombre2);
                    _con.cmd.Parameters.AddWithValue("@Apellido1", empleado.Apellido1);
                    _con.cmd.Parameters.AddWithValue("@Apellido2", empleado.Apellido2);
                    _con.cmd.Parameters.AddWithValue("@Edad", empleado.Edad);
                    _con.cmd.Parameters.AddWithValue("@Sexo", empleado.Sexo);
                    _con.cmd.Parameters.AddWithValue("@Departamento", empleado.Departamento);

                    _con.cmd.ExecuteNonQuery();
                    _con.cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción aquí
                MessageBox.Show("Error al agregar persona: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _con.cmd.Connection.Close(); // Asegurarse de cerrar la conexión en caso de error
            }
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            try
            {
                using (_con.cmd = new System.Data.SqlClient.SqlCommand())
                {
                    _con.cmd.Connection = _con.cn; // Asignar la conexión desde la instancia _con
                    _con.cmd.Connection.Open();

                    // Insertar datos en la tabla Empleado
                    _con.cmd.CommandText =
                        "INSERT INTO Empleado (EMPLEADO_CEDULA, ID_AREA_EMPLEADO, ID_CARGO_EMPLEADO, FECHA_REGISTRO, ACTIVO, USUARIO, CONTRASENA) " +
                        "VALUES (@Cedula, @ID_AREA, @ID_CARGO, @FechaRegistro, @Activo, @Usuario, HASHBYTES('SHA2_512', @Contrasena))";
                    _con.cmd.Parameters.AddWithValue("@Cedula", empleado.Cedula);
                    _con.cmd.Parameters.AddWithValue("@ID_AREA", empleado.ID_AREA);
                    _con.cmd.Parameters.AddWithValue("@ID_CARGO", empleado.ID_CARGO);
                    _con.cmd.Parameters.AddWithValue("@FechaRegistro", empleado.fechaderegistro);
                    _con.cmd.Parameters.AddWithValue("@Activo", empleado.activo);
                    _con.cmd.Parameters.AddWithValue("@Usuario", empleado.usuario);
                    _con.cmd.Parameters.AddWithValue("@Contrasena", empleado.contrasena);

                    _con.cmd.ExecuteNonQuery();
                    _con.cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción aquí
                MessageBox.Show("Error al agregar empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _con.cmd.Connection.Close(); // Asegurarse de cerrar la conexión en caso de error
            }
        }


        public void insertardatoscb(System.Windows.Forms.ComboBox cmb, string nombretabla)
        {

            string cadenasql = "SELECT * FROM " + nombretabla;
            string[] reg = new string[2];

            cmb.Items.Clear();
            try
            {
                _con.cn.Open();
                _con.cmd = new System.Data.SqlClient.SqlCommand(cadenasql, _con.cn);
                _con.rd = _con.cmd.ExecuteReader();

                while (_con.rd.Read())
                {
                    reg[1] = _con.rd[1].ToString();

                    cmb.Items.Add(reg[1]);
                }

                _con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                _con.cn.Close();
            }
        }


        private void frmEmpleados_Load_1(object sender, EventArgs e)
        {
            insertardatoscb(cbArea, "AREA");
            insertardatoscb(cbCargo, "CARGO");
        }
        public void agregarempleadopersona(Empleado empleado)
        {
            AgregarPersona(empleado);
            AgregarEmpleado(empleado);
            MessageBox.Show("Los datos de empleado se han agregado con exito");

        }
        private void Añadir_Click(object sender, EventArgs e)
        {

            try
            {
                // Validar que no haya campos de texto vacíos
                if (string.IsNullOrWhiteSpace(txtcedula.Text) ||
                    string.IsNullOrWhiteSpace(txtnombre1.Text) ||
                    string.IsNullOrWhiteSpace(txtapellido1.Text) ||
                    string.IsNullOrWhiteSpace(txtedad.Text) ||
                    string.IsNullOrWhiteSpace(txtdepartamento.Text) ||
                    cbArea.SelectedIndex == -1 ||
                    cbCargo.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(dtpFechadeIngreso.Text) ||
                    string.IsNullOrWhiteSpace(txtusuario.Text) ||
                    string.IsNullOrWhiteSpace(txtcontrasena.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método si hay campos vacíos
                }

                // Obtener los valores de los TextBox
                string cedula = txtcedula.Text;
                string nombre1 = txtnombre1.Text;
                string nombre2 = txtnombre2.Text;
                string apellido1 = txtapellido1.Text;
                string apellido2 = txtapellido2.Text;
                int edad = int.Parse(txtedad.Text);
                char sexo = MascRadio.Checked ? 'M' : 'F';
                string departamento = txtdepartamento.Text;
                int idArea = ObtenerIdAreaPorNombre(cbArea.Text);
                int idCargo = ObtenerIdCargoPorNombre(cbCargo.Text);
                DateTime fechaRegistro = dtpFechadeIngreso.Value;
                byte activo = idactivo;
                string usuario = txtusuario.Text;
                string contrasena = txtcontrasena.Text;

                // Crear una instancia de Empleado
                Empleado empleado = new Empleado(
                    cedula,
                    nombre1,
                    nombre2,
                    apellido1,
                    apellido2,
                    edad,
                    sexo,
                    departamento,
                    idArea,
                    idCargo,
                    fechaRegistro,
                    activo,
                    usuario,
                    contrasena
                );

                agregarempleadopersona(empleado);

                // Limpiar los TextBox
                txtcedula.Text = "";
                txtnombre1.Text = "";
                txtnombre2.Text = "";
                txtapellido1.Text = "";
                txtapellido2.Text = "";
                txtedad.Text = "";
                txtdepartamento.Text = "";
                cbArea.SelectedIndex = -1;
                cbCargo.SelectedIndex = -1;
                txtusuario.Text = "";
                txtcontrasena.Text = "";
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la conversión de datos.
                // Por ejemplo, valores no válidos en los TextBox.
                MessageBox.Show("Error: " + ex.Message, "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            Hide();
        }

        private void chkActivo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkActivo.Checked)
            {
                idactivo = 1;
            }
            else
            {
                idactivo = 0;
            }
        }

        private void MascRadio_CheckedChanged_1(object sender, EventArgs e)
        {
            if (MascRadio.Checked)
            {
                idsexo = 'M';
            }
        }

        private void FemRadio_CheckedChanged_1(object sender, EventArgs e)
        {
            if (FemRadio.Checked)
            {
                idsexo = 'F';
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            new MostrarTablaEmpleados().Show();
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            new ReporteEmpleado().Show();
        }
    }
}
