using Log_Negocio;
using proyectovacunas2._4.Mostrar;
using proyectovacunas2._4.Reportes;
using System;
using System.Drawing;
using System.Windows.Forms;
using CapaBD;
using Log_Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace proyectovacunas2._4
{
    public partial class Pacientes : Form
    {
        CapaBD.ConexionBD _con = new CapaBD.ConexionBD();

        char idsexo = 'M';
        public Pacientes()
        {
            InitializeComponent();
        }


        private void botonsalir_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            Hide();
        }


        private void btnreporte_Click(object sender, EventArgs e)
        {
            new ReportePaciente().Show();
        }

        private void MascRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (MascRadio.Checked)
            {
                idsexo = 'M';
            }
        }

        public void AgregarPersona(Paciente paciente)
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
                    _con.cmd.Parameters.AddWithValue("@Cedula", paciente.Cedula);
                    _con.cmd.Parameters.AddWithValue("@Nombre1", paciente.Nombre1);
                    _con.cmd.Parameters.AddWithValue("@Nombre2", paciente.Nombre2);
                    _con.cmd.Parameters.AddWithValue("@Apellido1", paciente.Apellido1);
                    _con.cmd.Parameters.AddWithValue("@Apellido2", paciente.Apellido2);
                    _con.cmd.Parameters.AddWithValue("@Edad", paciente.Edad);
                    _con.cmd.Parameters.AddWithValue("@Sexo", paciente.Sexo);
                    _con.cmd.Parameters.AddWithValue("@Departamento", paciente.Departamento);

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

        public void AgregarPaciente(Paciente paciente)
        {
            try
            {
                using (_con.cmd = new System.Data.SqlClient.SqlCommand())
                {
                    _con.cmd.Connection = _con.cn; // Asignar la conexión desde la instancia _con
                    _con.cmd.Connection.Open();

                    // Insertar datos en la tabla Paciente
                    _con.cmd.CommandText =
                        "INSERT INTO Paciente (PACIENTE_CEDULA, FECHA_INGRESO, ENFERMEDAD_CRONICA) " +
                        "VALUES (@Cedula, @FechaIngreso, @EnfermedadCronica)";
                    _con.cmd.Parameters.AddWithValue("@Cedula", paciente.Cedula);
                    _con.cmd.Parameters.AddWithValue("@FechaIngreso", paciente.FECHA_INGRESO);
                    _con.cmd.Parameters.AddWithValue("@EnfermedadCronica", paciente.ENFERMEDAD_CRONICA);

                    _con.cmd.ExecuteNonQuery();
                    _con.cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción aquí
                MessageBox.Show("Error al agregar Paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _con.cmd.Connection.Close(); // Asegurarse de cerrar la conexión en caso de error
            }
        }

        public void agregarempleadopersona(Paciente paciente)
        {
            AgregarPersona(paciente);
            AgregarPaciente(paciente);
            MessageBox.Show("Los datos de Paciente se han agregado con exito");

        }

        private void FemRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (FemRadio.Checked)
            {
                idsexo = 'F';
            }
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que no haya campos de texto vacíos
                if (string.IsNullOrWhiteSpace(txtcedula.Text) ||
                    string.IsNullOrWhiteSpace(txtnombre1.Text) ||
                    string.IsNullOrWhiteSpace(txtapellido1.Text) ||
                    string.IsNullOrWhiteSpace(txtapellido2.Text) ||
                    string.IsNullOrWhiteSpace(txtedad.Text) ||
                    string.IsNullOrWhiteSpace(txtEnfermedadCronica.Text) ||
                    string.IsNullOrWhiteSpace(dtFechaIngreso.Text))
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
                string Departamento = txtDepartamento.Text;
                DateTime fechaRegistro = dtFechaIngreso.Value;
                string EnfermedadCronica = txtEnfermedadCronica.Text;

                // Crear una instancia de Empleado
                Paciente paciente = new Paciente(
                    cedula,
                    nombre1,
                    nombre2,
                    apellido1,
                    apellido2,
                    edad,
                    sexo,
                    Departamento,
                    fechaRegistro,
                    EnfermedadCronica

                );

                agregarempleadopersona(paciente);

                // Limpiar los TextBox
                txtcedula.Text = "";
                txtnombre1.Text = "";
                txtnombre2.Text = "";
                txtapellido1.Text = "";
                txtapellido2.Text = "";
                txtedad.Text = "";
                txtDepartamento.Text = "";
                txtEnfermedadCronica.Text = "";
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la conversión de datos.
                // Por ejemplo, valores no válidos en los TextBox.
                MessageBox.Show("Error: " + ex.Message, "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            new MostrarTablaPaciente().Show();
        }
    }
}