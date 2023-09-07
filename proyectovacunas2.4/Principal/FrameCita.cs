using Log_Negocio;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using CapaBD;

namespace proyectovacunas2._4.Mostrar
{
    public partial class FrameCita : Form
    {
        private CapaBD.ConexionBD _con = new CapaBD.ConexionBD();

        public FrameCita()
        {
            InitializeComponent();
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
        private void CargarCedulasEmpleado()
        {
            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand("SELECT EMPLEADO_CEDULA FROM EMPLEADO", _con.cn))
                {
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        string cedulaEmpleado = reader["EMPLEADO_CEDULA"].ToString();
                        cbEmpleado.Items.Add(cedulaEmpleado);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cédulas de empleado: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }

        private void CargarCedulasPaciente()
        {
            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand("SELECT PACIENTE_CEDULA FROM PACIENTE", _con.cn))
                {
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        string cedulaPaciente = reader["PACIENTE_CEDULA"].ToString();
                        cbPaciente.Items.Add(cedulaPaciente);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cédulas de paciente: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }

        // Método para insertar datos de una cita en la base de datos
        public void AgregarCita(Citas cita)
        {
            try
            {
                using (_con.cmd = new System.Data.SqlClient.SqlCommand())
                {
                    _con.cmd.Connection = _con.cn;
                    _con.cmd.Connection.Open();

                    _con.cmd.CommandText =
                        "INSERT INTO CITAS (EMPLEADO_CEDULA, PACIENTE_CEDULA, REGISTRO_CITA_DESDE, REGISTRO_CITA_HASTA) " +
                        "VALUES (@EmpleadoCedula, @PacienteCedula, @RegistroCitaDesde, @RegistroCitaHasta)";
                    _con.cmd.Parameters.AddWithValue("@EmpleadoCedula", cita.EMPLEADO_CEDULA);
                    _con.cmd.Parameters.AddWithValue("@PacienteCedula", cita.PACIENTE_CEDULA);
                    _con.cmd.Parameters.AddWithValue("@RegistroCitaDesde", cita.REGISTRO_CITA_DESDE);
                    _con.cmd.Parameters.AddWithValue("@RegistroCitaHasta", cita.REGISTRO_CITA_HASTA);

                    _con.cmd.ExecuteNonQuery();
                    _con.cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para buscar citas por ID_CITA
        public void BuscarCitas(int idCita)
        {
            // Verifica si el ID_CITA es válido (mayor que cero)
            if (idCita <= 0)
            {
                MessageBox.Show("Por favor, ingrese un ID_CITA válido para buscar.");
                return; // Sale del método si el ID_CITA no es válido
            }

            // Define la consulta SQL para buscar citas por ID_CITA
            string consultaSQL = "SELECT ID_CITA, EMPLEADO_CEDULA, PACIENTE_CEDULA, REGISTRO_CITA_DESDE, REGISTRO_CITA_HASTA FROM CITAS WHERE ID_CITA = @IdCita";

            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, _con.cn))
                {
                    // Agrega el parámetro de búsqueda
                    comando.Parameters.AddWithValue("@IdCita", idCita);

                    // Ejecuta la consulta y obtiene los resultados en un DataTable
                    DataTable resultado = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                    // Verifica si la consulta no devolvió filas (ID_CITA no encontrado)
                    if (resultado.Rows.Count == 0)
                    {
                        MessageBox.Show("El ID_CITA no existe o no es accesible.");
                    }
                    else
                    {
                        // Configura el DataGridView para que no autogenere columnas automáticamente
                        dtCitas.AutoGenerateColumns = false;

                        // Asigna los datos al DataGridView en las columnas específicas
                        dtCitas.Columns["ID_CITA"].DataPropertyName = "ID_CITA";
                        dtCitas.Columns["EMPLEADO_CEDULA"].DataPropertyName = "EMPLEADO_CEDULA";
                        dtCitas.Columns["PACIENTE_CEDULA"].DataPropertyName = "PACIENTE_CEDULA";
                        dtCitas.Columns["REGISTRO_CITA_DESDE"].DataPropertyName = "REGISTRO_CITA_DESDE";
                        dtCitas.Columns["REGISTRO_CITA_HASTA"].DataPropertyName = "REGISTRO_CITA_HASTA";

                        // Muestra los resultados en el DataGridView "dtCitas"
                        dtCitas.DataSource = resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar citas: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }

        // Método para cargar todas las citas
        public void CargarTodasLasCitas()
        {
            // Limpia la tabla antes de cargar todas las citas
            dtCitas.DataSource = null;
            dtCitas.Rows.Clear();

            // Define la consulta SQL para seleccionar todas las citas
            string consultaSQL = "SELECT ID_CITA, EMPLEADO_CEDULA, PACIENTE_CEDULA, REGISTRO_CITA_DESDE, REGISTRO_CITA_HASTA FROM CITAS";

            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, _con.cn))
                {
                    // Ejecuta la consulta y obtiene los resultados en un DataTable
                    DataTable resultado = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                    // Configura el DataGridView para que no autogenere columnas automáticamente
                    dtCitas.AutoGenerateColumns = false;

                    // Asigna los datos al DataGridView en las columnas específicas
                    dtCitas.Columns["ID_CITA"].DataPropertyName = "ID_CITA";
                    dtCitas.Columns["EMPLEADO_CEDULA"].DataPropertyName = "EMPLEADO_CEDULA";
                    dtCitas.Columns["PACIENTE_CEDULA"].DataPropertyName = "PACIENTE_CEDULA";
                    dtCitas.Columns["REGISTRO_CITA_DESDE"].DataPropertyName = "REGISTRO_CITA_DESDE";
                    dtCitas.Columns["REGISTRO_CITA_HASTA"].DataPropertyName = "REGISTRO_CITA_HASTA";

                    // Muestra los resultados en el DataGridView "dtCitas"
                    dtCitas.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar todas las citas: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }

        // Método para guardar los cambios en la base de datos
        public void GuardarCambiosEnBaseDeDatos(DataTable dataSource, string usuario)
        {
            try
            {
                // Crear un adaptador de datos para actualizar la base de datos
                SqlDataAdapter adaptador = new SqlDataAdapter();

                // Define la consulta SQL de actualización
                string consultaSQL = "UPDATE CITAS SET " +
                    "EMPLEADO_CEDULA = @EMPLEADO_CEDULA, " +
                    "PACIENTE_CEDULA = @PACIENTE_CEDULA, " +
                    "REGISTRO_CITA_DESDE = @REGISTRO_CITA_DESDE, " +
                    "REGISTRO_CITA_HASTA = @REGISTRO_CITA_HASTA " +
                    "WHERE ID_CITA = @ID_CITA";

                // Configura la conexión y el adaptador
                using (SqlConnection conexion = new SqlConnection(_con.cn.ConnectionString))
                {
                    adaptador.SelectCommand = new SqlCommand(consultaSQL, conexion);

                    // Define los parámetros
                    adaptador.SelectCommand.Parameters.Add("@EMPLEADO_CEDULA", SqlDbType.NVarChar, 17, "EMPLEADO_CEDULA");
                    adaptador.SelectCommand.Parameters.Add("@PACIENTE_CEDULA", SqlDbType.NVarChar, 17, "PACIENTE_CEDULA");
                    adaptador.SelectCommand.Parameters.Add("@REGISTRO_CITA_DESDE", SqlDbType.DateTime, 8, "REGISTRO_CITA_DESDE");
                    adaptador.SelectCommand.Parameters.Add("@REGISTRO_CITA_HASTA", SqlDbType.DateTime, 8, "REGISTRO_CITA_HASTA");
                    adaptador.SelectCommand.Parameters.Add("@ID_CITA", SqlDbType.Int, 4, "ID_CITA");

                    // Abre la conexión a la base de datos
                    conexion.Open();

                    // Actualiza la base de datos (fuera del bucle foreach)
                    adaptador.UpdateCommand = adaptador.SelectCommand;
                    adaptador.Update(dataSource);

                    // Confirma los cambios en la base de datos
                    dataSource.AcceptChanges();

                    // Muestra un mensaje con los cambios guardados
                    string mensaje = $"Cambios en la base de datos guardados correctamente por {usuario}";
                    MessageBox.Show(mensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios en la base de datos: " + ex.Message);
            }
            finally
            {
                _con.cn.Close(); // Cierra la conexión en el bloque finally
            }
        }

        // Método para guardar los cambios en un archivo de registro
        public void GuardarCambiosEnArchivo(DataTable dataSource, string usuario)
        {
            try
            {
                if (dataSource == null || dataSource.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos modificados para guardar en el archivo.");
                    return;
                }

                // Nombre del archivo de registro
                string nombreArchivo = "registro_cambios_tabla_citas.txt";

                // Crear un registro de cambios
                string registroCambios = $"Usuario que lo modificó: {usuario}\nFecha y Hora: {DateTime.Now}\n\nCambios:\n";

                foreach (DataRow row in dataSource.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        registroCambios += $"Fila modificada (ID_CITA: {row["ID_CITA"]})\n";
                        foreach (DataColumn column in dataSource.Columns)
                        {
                            var originalValue = row[column, DataRowVersion.Original];
                            var currentValue = row[column];

                            if (!object.Equals(originalValue, currentValue))
                            {
                                registroCambios += $"\t{column.ColumnName}: {originalValue} -> {currentValue}\n";
                            }
                        }
                        registroCambios += "------------------------------------\n";
                    }
                }

                // Guardar el registro de cambios en un archivo
                File.AppendAllText(nombreArchivo, registroCambios);

                // Muestra un mensaje con el registro de cambios
                string mensaje = $"Cambios registrados en archivo por {usuario}\n\n{registroCambios}";
                MessageBox.Show(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios en el archivo: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar.Text, out int idCita))
            {
                BuscarCitas(idCita);
                txtBuscar.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido en el cuadro de búsqueda.");
                // Puedes manejar el valor no válido de alguna otra manera aquí si es necesario.
            }
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            CargarTodasLasCitas();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            // Verifica si el DataGridView está enlazado a un origen de datos
            if (dtCitas.DataSource != null)
            {
                // Obtén el origen de datos actual
                DataTable dataSource = (DataTable)dtCitas.DataSource;

                // Borra todos los datos en el origen de datos
                dataSource.Rows.Clear();

                // Vuelve a asignar el origen de datos vacío para limpiar el DataGridView
                dtCitas.DataSource = null;
            }
            else
            {
                // Si el DataGridView no está enlazado a un origen de datos, simplemente borra las filas
                dtCitas.Rows.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén el origen de datos actual del DataGridView
            DataTable dataSource = (DataTable)dtCitas.DataSource;
            string usuario = Usuarios.UsuarioActual;

            // Llama al método GuardarCambios para guardar los cambios en la base de datos y en el archivo
            GuardarCambiosEnArchivo(dataSource, usuario);
            GuardarCambiosEnBaseDeDatos(dataSource, usuario);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si el archivo existe antes de intentar abrirlo
                string nombreArchivo = "registro_cambios_tabla_citas.txt";
                if (File.Exists(nombreArchivo))
                {
                    // Crear un proceso para abrir el archivo de registro con el visor de texto predeterminado
                    System.Diagnostics.Process.Start("notepad.exe", nombreArchivo);
                }
                else
                {
                    MessageBox.Show("El archivo de registro no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo de registro: " + ex.Message);
            }
        }

        private void btncitanew_Click(object sender, EventArgs e)
        {
            try
            {
                string empleadoCedula = cbEmpleado.Text;
                string pacienteCedula = cbPaciente.Text;
                DateTime registroCitaDesde = dtpCitadesde.Value;
                DateTime registroCitaHasta = dtpCitahasta.Value;

                // Verificar si los TextBox están vacíos
                if (string.IsNullOrEmpty(empleadoCedula) || string.IsNullOrEmpty(pacienteCedula))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar la cita.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Sale del método si algún campo está vacío
                }

                // Verificar si el empleado está activo
                if (!EmpleadoEstaActivo(empleadoCedula))
                {
                    MessageBox.Show("El empleado seleccionado se encuentra inactivo.", "Empleado inactivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método si el empleado está inactivo
                }

                Citas cita = new Citas(empleadoCedula, pacienteCedula, registroCitaDesde, registroCitaHasta);

                AgregarCita(cita);

                MessageBox.Show("La cita se ha agregado con éxito.");

                // Limpiar los campos después de agregar la cita
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            cbEmpleado.Text = "";
            cbPaciente.Text = "";
            dtpCitadesde.Value = DateTime.Now;
            dtpCitahasta.Value = DateTime.Now;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmPrincipal().Show();
        }

        private void Cita_Load(object sender, EventArgs e)
        {
            CargarCedulasEmpleado();
            CargarCedulasPaciente();
        }
    }
}
