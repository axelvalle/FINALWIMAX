using CapaBD;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Collections.Generic;

namespace proyectovacunas2._4.Mostrar
{
    public partial class MostrarTablaConsulta : Form
    {
        CapaBD.ConexionBD _con = new CapaBD.ConexionBD();

        public MostrarTablaConsulta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Intenta convertir el contenido del cuadro de texto a un número entero
            if (int.TryParse(txtBuscar.Text, out int idConsulta))
            {
                // Llama a BuscarConsulta con el valor convertido
                BuscarConsulta(idConsulta);
                txtBuscar.Text = ""; // Limpia el cuadro de texto después de la búsqueda
            }
            else
            {
                // Si no se pudo convertir a un número, muestra un mensaje de error
                MessageBox.Show("Por favor, ingrese un número de consulta válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnTodo_Click(object sender, EventArgs e)
        {
            CargarTodasLasConsultas();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            // Verifica si el DataGridView está enlazado a un origen de datos
            if (dtConsulta.DataSource != null)
            {
                // Obtén el origen de datos actual
                DataTable dataSource = (DataTable)dtConsulta.DataSource;

                // Borra todos los datos en el origen de datos
                dataSource.Rows.Clear();

                // Vuelve a asignar el origen de datos vacío para limpiar el DataGridView
                dtConsulta.DataSource = null;
            }
            else
            {
                // Si el DataGridView no está enlazado a un origen de datos, simplemente borra las filas
                dtConsulta.Rows.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén el origen de datos actual del DataGridView
            DataTable dataSource = (DataTable)dtConsulta.DataSource;
            string usuario = Usuarios.UsuarioActual;
            // Llama al método GuardarCambios para guardar los cambios en la base de datos
            GuardarCambiosEnArchivo(dataSource, usuario);
            GuardarCambiosEnBaseDeDatos(dataSource, usuario);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si el archivo existe antes de intentar abrirlo
                string nombreArchivo = "registro_cambios_tabla_consultas.txt";
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

        public void BuscarConsulta(int idConsulta)
        {
            // Define la consulta SQL para buscar una consulta por ID de consulta
            string consultaSQL = "SELECT * FROM Consulta WHERE ID_CONSULTA = @IdConsulta";

            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, _con.cn))
                {
                    // Agrega el parámetro de búsqueda
                    comando.Parameters.AddWithValue("@IdConsulta", idConsulta);

                    // Ejecuta la consulta y obtiene los resultados en un DataTable
                    DataTable resultado = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                    // Configura el DataGridView para que no autogenera columnas automáticamente
                    dtConsulta.AutoGenerateColumns = false;

                    // Asigna los datos al DataGridView en las columnas específicas
                    // Asegúrate de que los nombres de las columnas coinciden con las de tu DataGridView
                    dtConsulta.Columns["ID_CONSULTA"].DataPropertyName = "ID_CONSULTA";
                    dtConsulta.Columns["EMPLEADO_CEDULA"].DataPropertyName = "EMPLEADO_CEDULA";
                    dtConsulta.Columns["PACIENTE_CEDULA"].DataPropertyName = "PACIENTE_CEDULA";
                    dtConsulta.Columns["REGISTRO_CONSULTA"].DataPropertyName = "REGISTRO_CONSULTA";
                    dtConsulta.Columns["DIADNOSTICO"].DataPropertyName = "DIADNOSTICO";
                    dtConsulta.Columns["PRESION_SANGUINEA"].DataPropertyName = "PRESION_SANGUINEA";
                    dtConsulta.Columns["OXIGENO"].DataPropertyName = "OXIGENO";
                    dtConsulta.Columns["FRECUENCIA_CARDIACA"].DataPropertyName = "FRECUENCIA_CARDIACA";
                    dtConsulta.Columns["PESO"].DataPropertyName = "PESO";
                    dtConsulta.Columns["TEMPERATURA"].DataPropertyName = "TEMPERATURA";
                    dtConsulta.Columns["PULSO"].DataPropertyName = "PULSO";
                    dtConsulta.Columns["HIPOTIROIDISMO"].DataPropertyName = "HIPOTIROIDISMO";

                    // Verifica si se encontraron resultados
                    if (resultado.Rows.Count == 0)
                    {
                        MessageBox.Show("Consulta inexistente o no disponible.");
                    }
                    else
                    {
                        // Muestra los resultados en el DataGridView "dtConsulta"
                        dtConsulta.DataSource = resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la consulta: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }

        public void CargarTodasLasConsultas()
        {
            // Define la consulta SQL para cargar todas las consultas
            string consultaSQL = "SELECT * FROM Consulta";

            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, _con.cn))
                {
                    // Ejecuta la consulta y obtiene los resultados en un DataTable
                    DataTable resultado = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                    // Configura el DataGridView para que no autogenera columnas automáticamente
                    dtConsulta.AutoGenerateColumns = false;

                    // Asigna los datos al DataGridView en las columnas específicas
                    // Asegúrate de que los nombres de las columnas coinciden con las de tu DataGridView
                    dtConsulta.Columns["ID_CONSULTA"].DataPropertyName = "ID_CONSULTA";
                    dtConsulta.Columns["EMPLEADO_CEDULA"].DataPropertyName = "EMPLEADO_CEDULA";
                    dtConsulta.Columns["PACIENTE_CEDULA"].DataPropertyName = "PACIENTE_CEDULA";
                    dtConsulta.Columns["REGISTRO_CONSULTA"].DataPropertyName = "REGISTRO_CONSULTA";
                    dtConsulta.Columns["DIADNOSTICO"].DataPropertyName = "DIADNOSTICO";
                    dtConsulta.Columns["PRESION_SANGUINEA"].DataPropertyName = "PRESION_SANGUINEA";
                    dtConsulta.Columns["OXIGENO"].DataPropertyName = "OXIGENO";
                    dtConsulta.Columns["FRECUENCIA_CARDIACA"].DataPropertyName = "FRECUENCIA_CARDIACA";
                    dtConsulta.Columns["PESO"].DataPropertyName = "PESO";
                    dtConsulta.Columns["TEMPERATURA"].DataPropertyName = "TEMPERATURA";
                    dtConsulta.Columns["PULSO"].DataPropertyName = "PULSO";
                    dtConsulta.Columns["HIPOTIROIDISMO"].DataPropertyName = "HIPOTIROIDISMO";

                    // Muestra los resultados en el DataGridView "dtConsulta"
                    dtConsulta.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar todas las consultas: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }

        public void GuardarCambiosEnBaseDeDatos(DataTable dataSource, string usuario)
        {
            try
            {
                // Crear un adaptador de datos para actualizar la base de datos
                SqlDataAdapter adaptador = new SqlDataAdapter();

                // Define la consulta SQL de actualización
                string consultaSQL = "UPDATE Consulta SET " +
                    "EMPLEADO_CEDULA = @EmpleadoCedula, " +
                    "PACIENTE_CEDULA = @PacienteCedula, " +
                    "REGISTRO_CONSULTA = @RegistroConsulta, " +
                    "DIADNOSTICO = @Diagnostico, " +
                    "PRESION_SANGUINEA = @PresionSanguinea, " +
                    "OXIGENO = @Oxigeno, " +
                    "FRECUENCIA_CARDIACA = @FrecuenciaCardiaca, " +
                    "PESO = @Peso, " +
                    "TEMPERATURA = @Temperatura, " +
                    "PULSO = @Pulso, " +
                    "HIPOTIROIDISMO = @Hipotiroidismo " +
                    "WHERE ID_CONSULTA = @IdConsulta";

                // Configura la conexión y el adaptador
                using (SqlConnection conexion = new SqlConnection(_con.cn.ConnectionString))
                {
                    adaptador.SelectCommand = new SqlCommand(consultaSQL, conexion);

                    // Define los parámetros
                    adaptador.SelectCommand.Parameters.Add("@PacienteCedula", SqlDbType.NVarChar, 17, "PACIENTE_CEDULA");
                    adaptador.SelectCommand.Parameters.Add("@EmpleadoCedula", SqlDbType.NVarChar, 17, "EMPLEADO_CEDULA");
                    adaptador.SelectCommand.Parameters.Add("@RegistroConsulta", SqlDbType.DateTime, 8, "REGISTRO_CONSULTA");
                    adaptador.SelectCommand.Parameters.Add("@Diagnostico", SqlDbType.NVarChar, 255, "DIADNOSTICO");
                    adaptador.SelectCommand.Parameters.Add("@PresionSanguinea", SqlDbType.NVarChar, 255, "PRESION_SANGUINEA");
                    adaptador.SelectCommand.Parameters.Add("@Oxigeno", SqlDbType.NVarChar, 255, "OXIGENO");
                    adaptador.SelectCommand.Parameters.Add("@FrecuenciaCardiaca", SqlDbType.NVarChar, 255, "FRECUENCIA_CARDIACA");
                    adaptador.SelectCommand.Parameters.Add("@Peso", SqlDbType.NVarChar, 255, "PESO");
                    adaptador.SelectCommand.Parameters.Add("@Temperatura", SqlDbType.NVarChar, 255, "TEMPERATURA");
                    adaptador.SelectCommand.Parameters.Add("@Pulso", SqlDbType.NVarChar, 255, "PULSO");
                    adaptador.SelectCommand.Parameters.Add("@Hipotiroidismo", SqlDbType.Char, 1, "HIPOTIROIDISMO");
                    adaptador.SelectCommand.Parameters.Add("@IdConsulta", SqlDbType.Int, 4, "ID_CONSULTA");

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
                string nombreArchivo = "registro_cambios_tabla_consultas.txt";

                // Crear un registro de cambios
                string registroCambios = $"Usuario que lo modificó: {usuario}\nFecha y Hora: {DateTime.Now}\n\nCambios:\n";

                foreach (DataRow row in dataSource.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        registroCambios += $"Fila modificada (ID Consulta: {row["ID_CONSULTA"]})\n";
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


    }
}