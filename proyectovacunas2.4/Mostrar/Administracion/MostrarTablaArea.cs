using Log_Negocio;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using CapaBD;
namespace proyectovacunas2._4.Mostrar
{
    public partial class MostrarTablaArea : Form
    {
        private CapaBD.ConexionBD _con = new CapaBD.ConexionBD();

        public MostrarTablaArea()
        {
            InitializeComponent();
        }

        // Método para insertar datos de un área en la base de datos
        public void AgregarArea(Area area)
        {
            try
            {
                using (_con.cmd = new System.Data.SqlClient.SqlCommand())
                {
                    _con.cmd.Connection = _con.cn;
                    _con.cmd.Connection.Open();

                    _con.cmd.CommandText =
                        "INSERT INTO AREA (NOMBRE_AREA, TIPO_AREA, REGISTRO) " +
                        "VALUES (@NombreArea, @TipoArea, @Registro)";
                    _con.cmd.Parameters.AddWithValue("@NombreArea", area.NOMBRE_AREA);
                    _con.cmd.Parameters.AddWithValue("@TipoArea", area.TIPO_AREA);
                    _con.cmd.Parameters.AddWithValue("@Registro", area.REGISTRO);

                    _con.cmd.ExecuteNonQuery();
                    _con.cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar área: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtnombrearea.Text = "";
            txttipodearea.Text = "";
            dtFechaRegistro.Value = DateTime.Now;
        }

        public void BuscarAreas(int idArea)
        {
            // Verifica si el ID_AREA es válido (mayor que cero)
            if (idArea <= 0)
            {
                MessageBox.Show("Por favor, ingrese un ID_AREA válido para buscar.");
                return; // Sale del método si el ID_AREA no es válido
            }

            // Define la consulta SQL para buscar áreas por ID_AREA
            string consultaSQL = "SELECT ID_AREA, NOMBRE_AREA, TIPO_AREA, REGISTRO FROM AREA WHERE ID_AREA = @IdArea";

            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, _con.cn))
                {
                    // Agrega el parámetro de búsqueda
                    comando.Parameters.AddWithValue("@IdArea", idArea);

                    // Ejecuta la consulta y obtiene los resultados en un DataTable
                    DataTable resultado = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                    // Verifica si la consulta no devolvió filas (ID_AREA no encontrado)
                    if (resultado.Rows.Count == 0)
                    {
                        MessageBox.Show("El ID_AREA no existe o no es accesible.");
                    }
                    else
                    {
                        // Configura el DataGridView para que no autogenere columnas automáticamente
                        dtArea.AutoGenerateColumns = false;

                        // Asigna los datos al DataGridView en las columnas específicas
                        dtArea.Columns["ID_AREA"].DataPropertyName = "ID_AREA";
                        dtArea.Columns["NOMBRE_AREA"].DataPropertyName = "NOMBRE_AREA";
                        dtArea.Columns["TIPO_AREA"].DataPropertyName = "TIPO_AREA";
                        dtArea.Columns["REGISTRO"].DataPropertyName = "REGISTRO";

                        // Muestra los resultados en el DataGridView "dtArea"
                        dtArea.DataSource = resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar áreas: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }

        // Método para cargar todas las áreas
        public void CargarTodasLasAreas()
        {
            // Limpia la tabla antes de cargar todas las áreas
            dtArea.DataSource = null;
            dtArea.Rows.Clear();

            // Define la consulta SQL para seleccionar todas las áreas
            string consultaSQL = "SELECT ID_AREA, NOMBRE_AREA, TIPO_AREA, REGISTRO FROM AREA";

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
                    dtArea.AutoGenerateColumns = false;

                    // Asigna los datos al DataGridView en las columnas específicas
                    dtArea.Columns["ID_AREA"].DataPropertyName = "ID_AREA";
                    dtArea.Columns["NOMBRE_AREA"].DataPropertyName = "NOMBRE_AREA";
                    dtArea.Columns["TIPO_AREA"].DataPropertyName = "TIPO_AREA";
                    dtArea.Columns["REGISTRO"].DataPropertyName = "REGISTRO";

                    // Muestra los resultados en el DataGridView "dtArea"
                    dtArea.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar todas las áreas: " + ex.Message);
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
                string consultaSQL = "UPDATE AREA SET " +
                    "NOMBRE_AREA = @NOMBRE_AREA, " +
                    "TIPO_AREA = @TIPO_AREA, " +
                    "REGISTRO = @REGISTRO " +
                    "WHERE ID_AREA = @ID_AREA";

                // Configura la conexión y el adaptador
                using (SqlConnection conexion = new SqlConnection(_con.cn.ConnectionString))
                {
                    adaptador.SelectCommand = new SqlCommand(consultaSQL, conexion);

                    // Define los parámetros
                    adaptador.SelectCommand.Parameters.Add("@NOMBRE_AREA", SqlDbType.NVarChar, 20, "NOMBRE_AREA");
                    adaptador.SelectCommand.Parameters.Add("@TIPO_AREA", SqlDbType.NVarChar, 20, "TIPO_AREA");
                    adaptador.SelectCommand.Parameters.Add("@REGISTRO", SqlDbType.DateTime, 8, "REGISTRO");
                    adaptador.SelectCommand.Parameters.Add("@ID_AREA", SqlDbType.Int, 4, "ID_AREA");

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
                string nombreArchivo = "registro_cambios_tabla_area.txt";

                // Crear un registro de cambios
                string registroCambios = $"Usuario que lo modificó: {usuario}\nFecha y Hora: {DateTime.Now}\n\nCambios:\n";

                foreach (DataRow row in dataSource.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        registroCambios += $"Fila modificada (ID_AREA: {row["ID_AREA"]})\n";
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
            if (int.TryParse(txtBuscar.Text, out int idArea))
            {
                BuscarAreas(idArea);
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
            CargarTodasLasAreas();

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            // Verifica si el DataGridView está enlazado a un origen de datos
            if (dtArea.DataSource != null)
            {
                // Obtén el origen de datos actual
                DataTable dataSource = (DataTable)dtArea.DataSource;

                // Borra todos los datos en el origen de datos
                dataSource.Rows.Clear();

                // Vuelve a asignar el origen de datos vacío para limpiar el DataGridView
                dtArea.DataSource = null;
            }
            else
            {
                // Si el DataGridView no está enlazado a un origen de datos, simplemente borra las filas
                dtArea.Rows.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén el origen de datos actual del DataGridView
            DataTable dataSource = (DataTable)dtArea.DataSource;
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
                string nombreArchivo = "registro_cambios_tabla_area.txt";
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

        private void Añadir_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreArea = txtnombrearea.Text;
                string tipoArea = txttipodearea.Text;
                DateTime fechaRegistro = dtFechaRegistro.Value;

                // Verificar si los TextBox están vacíos
                if (string.IsNullOrEmpty(nombreArea) || string.IsNullOrEmpty(tipoArea))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar el área.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Sale del método si algún campo está vacío
                }

                Area area = new Area(nombreArea, tipoArea, fechaRegistro);

                AgregarArea(area);

                MessageBox.Show("El área se ha agregado con éxito.");

                // Limpiar los campos después de agregar el área
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarTablaArea_Load(object sender, EventArgs e)
        {

        }
    }
}
