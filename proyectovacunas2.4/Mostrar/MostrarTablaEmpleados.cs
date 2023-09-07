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
    public partial class MostrarTablaEmpleados : Form
    {
        CapaBD.ConexionBD _con = new CapaBD.ConexionBD();

        public MostrarTablaEmpleados()
        {
            InitializeComponent();
        }

        private void MostrarTablaEmpleados_Load(object sender, EventArgs e)
        {

        }

        public void BuscarEmpleados(string numeroCedula)
        {
            // Verifica si el TextBox está vacío
            if (string.IsNullOrEmpty(numeroCedula))
            {
                MessageBox.Show("Por favor, ingrese un número de cédula para buscar.");
                return; // Sale del método si el TextBox está vacío
            }

            // Define la consulta SQL para buscar empleados por número de cédula y selecciona las columnas deseadas
            string consultaSQL = "SELECT EMPLEADO_CEDULA, ID_AREA_EMPLEADO, ID_CARGO_EMPLEADO, FECHA_REGISTRO, ACTIVO, USUARIO FROM EMPLEADO WHERE EMPLEADO_CEDULA = @Cedula";

            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, _con.cn))
                {
                    // Agrega el parámetro de búsqueda
                    comando.Parameters.AddWithValue("@Cedula", numeroCedula);

                    // Ejecuta la consulta y obtiene los resultados en un DataTable
                    DataTable resultado = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                    // Configura el DataGridView para que no autogenera columnas automáticamente
                    dtEmpleado.AutoGenerateColumns = false;

                    // Asigna los datos al DataGridView en las columnas específicas
                    dtEmpleado.Columns["EMPLEADO_CEDULA"].DataPropertyName = "EMPLEADO_CEDULA";
                    dtEmpleado.Columns["ID_AREA_EMPLEADO"].DataPropertyName = "ID_AREA_EMPLEADO";
                    dtEmpleado.Columns["ID_CARGO_EMPLEADO"].DataPropertyName = "ID_CARGO_EMPLEADO";
                    dtEmpleado.Columns["FECHA_REGISTRO"].DataPropertyName = "FECHA_REGISTRO";
                    dtEmpleado.Columns["ACTIVO"].DataPropertyName = "ACTIVO";
                    dtEmpleado.Columns["USUARIO"].DataPropertyName = "USUARIO"; // Agrega esta línea para la columna USUARIO

                    // Muestra los resultados en el DataGridView "dtEmpleado"
                    dtEmpleado.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar empleados: " + ex.Message);
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
                string consultaSQL = "UPDATE EMPLEADO SET " +
                    "ID_AREA_EMPLEADO = @ID_AREA_EMPLEADO, " +
                    "ID_CARGO_EMPLEADO = @ID_CARGO_EMPLEADO, " +
                    "FECHA_REGISTRO = @FECHA_REGISTRO, " +
                    "ACTIVO = @ACTIVO, " +
                    "USUARIO = @USUARIO " + // Agrega la columna USUARIO
                    "WHERE EMPLEADO_CEDULA = @EMPLEADO_CEDULA";

                // Configura la conexión y el adaptador
                using (SqlConnection conexion = new SqlConnection(_con.cn.ConnectionString))
                {
                    adaptador.SelectCommand = new SqlCommand(consultaSQL, conexion);

                    // Define los parámetros
                    adaptador.SelectCommand.Parameters.Add("@ID_AREA_EMPLEADO", SqlDbType.Int, 4, "ID_AREA_EMPLEADO");
                    adaptador.SelectCommand.Parameters.Add("@ID_CARGO_EMPLEADO", SqlDbType.Int, 4, "ID_CARGO_EMPLEADO");
                    adaptador.SelectCommand.Parameters.Add("@FECHA_REGISTRO", SqlDbType.DateTime, 8, "FECHA_REGISTRO");
                    adaptador.SelectCommand.Parameters.Add("@ACTIVO", SqlDbType.Bit, 1, "ACTIVO");
                    adaptador.SelectCommand.Parameters.Add("@EMPLEADO_CEDULA", SqlDbType.NVarChar, 17, "EMPLEADO_CEDULA");
                    adaptador.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.NVarChar, 25, "USUARIO"); // Agrega el parámetro USUARIO

                    // Antes de guardar, verifica si se modificó la cédula en alguna fila
                    foreach (DataRow row in dataSource.Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                        {
                            // Si la cédula original es diferente de la nueva cédula, muestra un mensaje y no guarda
                            if (row.HasVersion(DataRowVersion.Original) &&
                                !row["EMPLEADO_CEDULA", DataRowVersion.Original].ToString()
                                .Equals(row["EMPLEADO_CEDULA"].ToString()))
                            {
                                MessageBox.Show("No se permite modificar la columna de cédula.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return; // Sale del método sin guardar
                            }
                        }
                    }

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
                string nombreArchivo = "registro_cambios_tabla_empleados.txt";

                // Crear un registro de cambios
                string registroCambios = $"Usuario que lo modificó: {usuario}\nFecha y Hora: {DateTime.Now}\n\nCambios:\n";

                foreach (DataRow row in dataSource.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        registroCambios += $"Fila modificada (Cédula: {row["EMPLEADO_CEDULA"]})\n";
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




        public void CargarTodosLosEmpleados()
        {
            // Limpia la tabla antes de cargar todos los empleados
            dtEmpleado.DataSource = null;
            dtEmpleado.Rows.Clear();

            // Define la consulta SQL para seleccionar todos los empleados
            string consultaSQL = "SELECT EMPLEADO_CEDULA, ID_AREA_EMPLEADO, ID_CARGO_EMPLEADO, FECHA_REGISTRO, ACTIVO, USUARIO FROM EMPLEADO";

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
                    dtEmpleado.AutoGenerateColumns = false;

                    // Asigna los datos al DataGridView en las columnas específicas
                    dtEmpleado.Columns["EMPLEADO_CEDULA"].DataPropertyName = "EMPLEADO_CEDULA";
                    dtEmpleado.Columns["ID_AREA_EMPLEADO"].DataPropertyName = "ID_AREA_EMPLEADO";
                    dtEmpleado.Columns["ID_CARGO_EMPLEADO"].DataPropertyName = "ID_CARGO_EMPLEADO";
                    dtEmpleado.Columns["FECHA_REGISTRO"].DataPropertyName = "FECHA_REGISTRO";
                    dtEmpleado.Columns["ACTIVO"].DataPropertyName = "ACTIVO";
                    dtEmpleado.Columns["USUARIO"].DataPropertyName = "USUARIO"; // Agrega esta línea para la columna USUARIO

                    // Muestra los resultados en el DataGridView "dtEmpleado"
                    dtEmpleado.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar todos los empleados: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarEmpleados(txtBuscar.Text);
            txtBuscar.Text = "";
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            CargarTodosLosEmpleados();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            // Verifica si el DataGridView está enlazado a un origen de datos
            if (dtEmpleado.DataSource != null)
            {
                // Obtén el origen de datos actual
                DataTable dataSource = (DataTable)dtEmpleado.DataSource;

                // Borra todos los datos en el origen de datos
                dataSource.Rows.Clear();

                // Vuelve a asignar el origen de datos vacío para limpiar el DataGridView
                dtEmpleado.DataSource = null;
            }
            else
            {
                // Si el DataGridView no está enlazado a un origen de datos, simplemente borra las filas
                dtEmpleado.Rows.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén el origen de datos actual del DataGridView
            DataTable dataSource = (DataTable)dtEmpleado.DataSource;
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
                string nombreArchivo = "registro_cambios_tabla_empleados.txt";
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


    }
}
