using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace proyectovacunas2._4.Mostrar
{
    public partial class MostrarTablaPaciente : Form
    {
        CapaBD.ConexionBD _con = new CapaBD.ConexionBD();

        public MostrarTablaPaciente()
        {
            InitializeComponent();
        }

        private void MostrarTablaPacientes_Load(object sender, EventArgs e)
        {

        }

        public void BuscarPacientes(string numeroCedula)
        {
            BuscarDatos("PACIENTE", numeroCedula);
        }

        public void CargarTodosLosPacientes()
        {
            CargarTodosLosDatos("PACIENTE");
        }

        private void BuscarDatos(string tabla, string numeroCedula)
        {
            if (string.IsNullOrEmpty(numeroCedula))
            {
                MessageBox.Show("Por favor, ingrese un número de cédula para buscar.");
                return;
            }

            string consultaSQL = $"SELECT PACIENTE_CEDULA, FECHA_INGRESO, ENFERMEDAD_CRONICA FROM {tabla} WHERE PACIENTE_CEDULA = @Cedula";

            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, _con.cn))
                {
                    comando.Parameters.AddWithValue("@Cedula", numeroCedula);

                    DataTable resultado = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                    dtPaciente.AutoGenerateColumns = false;

                    dtPaciente.Columns["PACIENTE_CEDULA"].DataPropertyName = "PACIENTE_CEDULA";
                    dtPaciente.Columns["FECHA_INGRESO"].DataPropertyName = "FECHA_INGRESO";
                    dtPaciente.Columns["ENFERMEDAD_CRONICA"].DataPropertyName = "ENFERMEDAD_CRONICA";

                    dtPaciente.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar pacientes: {ex.Message}");
            }
            finally
            {
                _con.cn.Close();
            }
        }

        private void CargarTodosLosDatos(string tabla)
        {
            dtPaciente.DataSource = null;
            dtPaciente.Rows.Clear();

            string consultaSQL = $"SELECT PACIENTE_CEDULA, FECHA_INGRESO, ENFERMEDAD_CRONICA FROM {tabla}";

            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, _con.cn))
                {
                    DataTable resultado = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                    dtPaciente.AutoGenerateColumns = false;

                    dtPaciente.Columns["PACIENTE_CEDULA"].DataPropertyName = "PACIENTE_CEDULA";
                    dtPaciente.Columns["FECHA_INGRESO"].DataPropertyName = "FECHA_INGRESO";
                    dtPaciente.Columns["ENFERMEDAD_CRONICA"].DataPropertyName = "ENFERMEDAD_CRONICA";

                    dtPaciente.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar todos los pacientes: {ex.Message}");
            }
            finally
            {
                _con.cn.Close();
            }
        }

        private void GuardarCambios(string tabla, DataTable dataSource, string usuario)
        {
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter();
                string consultaSQL = $"UPDATE {tabla} SET " +
                    "FECHA_INGRESO = @FECHA_INGRESO, " +
                    "ENFERMEDAD_CRONICA = @ENFERMEDAD_CRONICA " +
                    "WHERE PACIENTE_CEDULA = @PACIENTE_CEDULA";

                using (SqlConnection conexion = new SqlConnection(_con.cn.ConnectionString))
                {
                    adaptador.SelectCommand = new SqlCommand(consultaSQL, conexion);

                    adaptador.SelectCommand.Parameters.Add("@FECHA_INGRESO", SqlDbType.DateTime, 8, "FECHA_INGRESO");
                    adaptador.SelectCommand.Parameters.Add("@ENFERMEDAD_CRONICA", SqlDbType.NVarChar, 30, "ENFERMEDAD_CRONICA");
                    adaptador.SelectCommand.Parameters.Add("@PACIENTE_CEDULA", SqlDbType.NVarChar, 17, "PACIENTE_CEDULA");

                    foreach (DataRow row in dataSource.Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                        {
                            adaptador.SelectCommand.Parameters["@PACIENTE_CEDULA"].Value = row["PACIENTE_CEDULA"];
                            adaptador.SelectCommand.Parameters["@FECHA_INGRESO"].Value = row["FECHA_INGRESO"];
                            adaptador.SelectCommand.Parameters["@ENFERMEDAD_CRONICA"].Value = row["ENFERMEDAD_CRONICA"];

                            conexion.Open();
                            adaptador.UpdateCommand = adaptador.SelectCommand;
                            adaptador.Update(dataSource);
                            conexion.Close();
                        }
                    }

                    dataSource.AcceptChanges();
                    string mensaje = $"Cambios en la base de datos guardados correctamente por {usuario}";
                    MessageBox.Show(mensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los cambios en la base de datos: {ex.Message}");
            }
            finally
            {
                _con.cn.Close();
            }
        }

        private void GuardarCambiosEnArchivo(DataTable dataSource, string usuario)
        {
            try
            {
                if (dataSource == null || dataSource.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos modificados para guardar en el archivo.");
                    return;
                }

                string nombreArchivo = "registro_cambios_tabla_pacientes.txt";
                string registroCambios = $"Usuario que lo modificó: {usuario}\nFecha y Hora: {DateTime.Now}\n\nCambios:\n";

                foreach (DataRow row in dataSource.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        registroCambios += $"Fila modificada (Cédula: {row["PACIENTE_CEDULA"]})\n";
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

                File.AppendAllText(nombreArchivo, registroCambios);
                string mensaje = $"Cambios registrados en archivo por {usuario}\n\n{registroCambios}";
                MessageBox.Show(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los cambios en el archivo: {ex.Message}");
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            BuscarPacientes(txtBuscar.Text);
            txtBuscar.Text = "";
        }

        private void btnTodo_Click_1(object sender, EventArgs e)
        {
            CargarTodosLosPacientes();

        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {
            if (dtPaciente.DataSource != null)
            {
                DataTable dataSource = (DataTable)dtPaciente.DataSource;
                dataSource.Rows.Clear();
                dtPaciente.DataSource = null;
            }
            else
            {
                dtPaciente.Rows.Clear();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dataSource = (DataTable)dtPaciente.DataSource;
            string usuario = Usuarios.UsuarioActual;
            GuardarCambiosEnArchivo(dataSource, usuario);
            GuardarCambios("PACIENTE", dataSource, usuario);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreArchivo = "registro_cambios_tabla_pacientes.txt";
                if (File.Exists(nombreArchivo))
                {
                    System.Diagnostics.Process.Start("notepad.exe", nombreArchivo);
                }
                else
                {
                    MessageBox.Show("El archivo de registro no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el archivo de registro: {ex.Message}");
            }
        }
    }
}