using Log_Negocio;
using proyectovacunas2._4.Mostrar;
using proyectovacunas2._4.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace proyectovacunas2._4
{
    public partial class frmconsultas : Form
    {
        CapaBD.ConexionBD _con = new CapaBD.ConexionBD();
        char idHp = 'N';
        public frmconsultas()
        {
            InitializeComponent();
        }

        public void insertardatoscb(System.Windows.Forms.ComboBox cmb, string nombretabla)
        {

            string cadenasql = "SELECT * FROM " + nombretabla;
            string[] reg = new string[1];

            cmb.Items.Clear();
            try
            {
                _con.cn.Open();
                _con.cmd = new System.Data.SqlClient.SqlCommand(cadenasql, _con.cn);
                _con.rd = _con.cmd.ExecuteReader();

                while (_con.rd.Read())
                {
                    reg[0] = _con.rd[0].ToString();

                    cmb.Items.Add(reg[0]);
                }

                _con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                _con.cn.Close();
            }
        }
        public void AgregarConsulta(Consulta consulta)
        {
            try
            {
                using (_con.cmd = new System.Data.SqlClient.SqlCommand())
                {
                    _con.cmd.Connection = _con.cn; // Asignar la conexión desde la instancia _con
                    _con.cmd.Connection.Open();

                    // Insertar datos en la tabla Empleado
                    _con.cmd.CommandText =
                        "INSERT INTO CONSULTA (EMPLEADO_CEDULA, PACIENTE_CEDULA, REGISTRO_CONSULTA, DIADNOSTICO, PRESION_SANGUINEA, OXIGENO, FRECUENCIA_CARDIACA, PESO, TEMPERATURA, PULSO, HIPOTIROIDISMO) " +
                        "VALUES (@EMPLEADO_CEDULA, @PACIENTE_CEDULA, @REGISTRO_CONSULTA, @DIADNOSTICO, @PRESION_SANGUINEA, @OXIGENO, @FRECUENCIA_CARDIACA, @PESO, @TEMPERATURA, @PULSO, @HIPOTIROIDISMO)";
                    _con.cmd.Parameters.AddWithValue("@EMPLEADO_CEDULA", consulta.EMPLEADO_CEDULA);
                    _con.cmd.Parameters.AddWithValue("@PACIENTE_CEDULA", consulta.PACIENTE_CEDULA);
                    _con.cmd.Parameters.AddWithValue("@REGISTRO_CONSULTA", consulta.REGISTRO_CONSULTA);
                    _con.cmd.Parameters.AddWithValue("@DIADNOSTICO", consulta.DIAGNOSTICO);
                    _con.cmd.Parameters.AddWithValue("@PRESION_SANGUINEA", consulta.PRESION_SANGUINEA);
                    _con.cmd.Parameters.AddWithValue("@OXIGENO", consulta.OXIGENO);
                    _con.cmd.Parameters.AddWithValue("@FRECUENCIA_CARDIACA", consulta.FRECUENCIA_CARDIACA);
                    _con.cmd.Parameters.AddWithValue("@PESO", consulta.PESO);
                    _con.cmd.Parameters.AddWithValue("@TEMPERATURA", consulta.TEMPERATURA);
                    _con.cmd.Parameters.AddWithValue("@PULSO", consulta.PULSO);
                    _con.cmd.Parameters.AddWithValue("@HIPOTIROIDISMO", consulta.HIPOTIROIDISMO);


                    _con.cmd.ExecuteNonQuery();
                    _con.cmd.Connection.Close();
                }
                MessageBox.Show("Los datos de consulta se han agregado exitosamente");
            }
            catch (Exception ex)
            {
                // Manejar la excepción aquí
                MessageBox.Show("Error al agregar consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _con.cmd.Connection.Close(); // Asegurarse de cerrar la conexión en caso de error
            }
        }

        private void txtoxigeno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            Hide();
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            new ReporteConsulta().Show();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            new MostrarTablaConsulta().Show();
        }

        private void rdbtnSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnSi.Checked)
            {
                idHp = 'S';
            }
        }

        private void rdbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnNo.Checked)
            {

                idHp = 'N';
            }
        }

        private void frmconsultas_Load(object sender, EventArgs e)
        {
            insertardatoscb(cbEmpleado, "EMPLEADO");
            insertardatoscb(cbPaciente, "PACIENTE");
        }

        private bool EmpleadoEstaActivo(string cedulaEmpleado)
        {
            // Define la consulta SQL para verificar si el empleado está activo
            string consultaSQL = "SELECT ACTIVO FROM EMPLEADO WHERE EMPLEADO_CEDULA = @Cedula";

            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, _con.cn))
                {
                    // Agrega el parámetro de búsqueda
                    comando.Parameters.AddWithValue("@Cedula", cedulaEmpleado);

                    // Ejecuta la consulta y obtiene el valor de ACTIVO
                    bool activo = (bool)comando.ExecuteScalar();

                    return activo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el estado del empleado: " + ex.Message);
                return false; // En caso de error, asumimos que el empleado está inactivo
            }
            finally
            {
                _con.cn.Close();
            }
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que no haya campos de texto vacíos
                if (string.IsNullOrWhiteSpace(cbEmpleado.Text) ||
                    string.IsNullOrWhiteSpace(cbPaciente.Text) ||
                    string.IsNullOrWhiteSpace(txtdiagnostico.Text) ||
                    string.IsNullOrWhiteSpace(txtpresionsangre.Text) ||
                    string.IsNullOrWhiteSpace(txtfrecardiaca.Text) ||
                    string.IsNullOrWhiteSpace(txtoxigeno.Text) ||
                    string.IsNullOrWhiteSpace(txtpeso.Text) ||
                    string.IsNullOrWhiteSpace(txtemperatura.Text) ||
                    string.IsNullOrWhiteSpace(txtpulso.Text)
                )
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método si hay campos vacíos
                }

                // Obtener los valores de los TextBox
                string empleadoCedula = cbEmpleado.Text;
                string pacienteCedula = cbPaciente.Text;
                DateTime fechaConsulta = dtRegistroConsulta.Value;
                string diagnostico = txtdiagnostico.Text;
                string presionSanguinea = txtpresionsangre.Text;
                string oxigeno = txtoxigeno.Text;
                string frecuenciaCardiaca = txtfrecardiaca.Text;
                string peso = txtpeso.Text;
                string temperatura = txtemperatura.Text;
                string pulso = txtpulso.Text;
                char hipotiroidismo = idHp; // Valor de hipotiroidismo_


                // Verificar si el empleado está activo
                if (!EmpleadoEstaActivo(empleadoCedula))
                {
                    MessageBox.Show("El empleado seleccionado se encuentra inactivo.", "Empleado inactivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método si el empleado está inactivo
                }

                // Crear una instancia de Consulta
                Consulta consulta = new Consulta(
                    empleadoCedula,
                    pacienteCedula,
                    fechaConsulta,
                    diagnostico,
                    presionSanguinea,
                    oxigeno,
                    frecuenciaCardiaca,
                    peso,
                    temperatura,
                    pulso,
                    hipotiroidismo
                );

                // Llamar a la función para agregar la consulta a la base de datos
                AgregarConsulta(consulta);

                // Limpiar los TextBox
                cbEmpleado.Text = "";
                cbPaciente.Text = "";
                txtdiagnostico.Text = "";
                txtpresionsangre.Text = "";
                txtoxigeno.Text = "";
                txtfrecardiaca.Text = "";
                txtpeso.Text = "";
                txtemperatura.Text = "";
                txtpulso.Text = "";
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la conversión de datos.
                // Por ejemplo, valores no válidos en los TextBox.
                MessageBox.Show("Error: " + ex.Message, "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
