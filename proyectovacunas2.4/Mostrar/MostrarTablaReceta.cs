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
    public partial class MostrarTablaReceta : Form
    {
        CapaBD.ConexionBD _con = new CapaBD.ConexionBD();

        public MostrarTablaReceta()
        {
            InitializeComponent();
        }

        private void MostrarTablaReceta_Load(object sender, EventArgs e)
        {

        }

        public void BuscarRecetas(string cedulaPaciente)
        {
            // Verifica si el TextBox está vacío
            if (string.IsNullOrEmpty(cedulaPaciente))
            {
                MessageBox.Show("Por favor, ingrese una cédula de paciente para buscar.");
                return; // Sale del método si el TextBox está vacío
            }

            // Define la consulta SQL para buscar recetas por cédula de paciente y selecciona las columnas deseadas
            string consultaSQL = "SELECT ID_RECETA, PACIENTE_CEDULA, ID_PRODUCTO_RECETA, CANTIDAD FROM RECETA WHERE PACIENTE_CEDULA = @Cedula";

            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, _con.cn))
                {
                    // Agrega el parámetro de búsqueda
                    comando.Parameters.AddWithValue("@Cedula", cedulaPaciente);

                    // Ejecuta la consulta y obtiene los resultados en un DataTable
                    DataTable resultado = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                    // Configura el DataGridView para que no autogenera columnas automáticamente
                    dtReceta.AutoGenerateColumns = false;

                    // Asigna los datos al DataGridView en las columnas específicas
                    dtReceta.Columns["ID_RECETA"].DataPropertyName = "ID_RECETA";
                    dtReceta.Columns["PACIENTE_CEDULA"].DataPropertyName = "PACIENTE_CEDULA";
                    dtReceta.Columns["ID_PRODUCTO_RECETA"].DataPropertyName = "ID_RECETA_PRODUCTO";
                    dtReceta.Columns["CANTIDAD"].DataPropertyName = "CANTIDAD";

                    // Muestra los resultados en el DataGridView "dtReceta"
                    dtReceta.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar recetas: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }

        public void CargarTodasLasRecetas()
        {
            // Limpia la tabla antes de cargar todas las recetas
            dtReceta.DataSource = null;
            dtReceta.Rows.Clear();

            // Define la consulta SQL para seleccionar todas las recetas
            string consultaSQL = "SELECT ID_RECETA, PACIENTE_CEDULA, ID_RECETA_PRODUCTO, CANTIDAD FROM RECETA";

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
                    dtReceta.AutoGenerateColumns = false;

                    // Asigna los datos al DataGridView en las columnas específicas
                    dtReceta.Columns["ID_RECETA"].DataPropertyName = "ID_RECETA";
                    dtReceta.Columns["PACIENTE_CEDULA"].DataPropertyName = "PACIENTE_CEDULA";
                    dtReceta.Columns["ID_PRODUCTO_RECETA"].DataPropertyName = "ID_RECETA_PRODUCTO";
                    dtReceta.Columns["CANTIDAD"].DataPropertyName = "CANTIDAD";

                    // Muestra los resultados en el DataGridView "dtReceta"
                    dtReceta.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar todas las recetas: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarRecetas(txtBuscar.Text);
            txtBuscar.Text = "";
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            CargarTodasLasRecetas();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            // Verifica si el DataGridView está enlazado a un origen de datos
            if (dtReceta.DataSource != null)
            {
                // Obtén el origen de datos actual
                DataTable dataSource = (DataTable)dtReceta.DataSource;

                // Borra todos los datos en el origen de datos
                dataSource.Rows.Clear();

                // Vuelve a asignar el origen de datos vacío para limpiar el DataGridView
                dtReceta.DataSource = null;
            }
            else
            {
                // Si el DataGridView no está enlazado a un origen de datos, simplemente borra las filas
                dtReceta.Rows.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén el origen de datos actual del DataGridView
            DataTable dataSource = (DataTable)dtReceta.DataSource;
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
                string nombreArchivo = "registro_cambios_tabla_recetas.txt";
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

        public void GuardarCambiosEnBaseDeDatos(DataTable dataSource, string usuario)
        {
            try
            {
                // Crear un adaptador de datos para actualizar la base de datos
                SqlDataAdapter adaptador = new SqlDataAdapter();

                // Define la consulta SQL de actualización
                string consultaSQL = "UPDATE RECETA SET " +
                    "ID_RECETA_PRODUCTO = @ID_PRODUCTO_RECETA, " +
                    "CANTIDAD = @CANTIDAD " +
                    "WHERE ID_RECETA = @ID_RECETA";

                // Configura la conexión y el adaptador
                using (SqlConnection conexion = new SqlConnection(_con.cn.ConnectionString))
                {
                    adaptador.SelectCommand = new SqlCommand(consultaSQL, conexion);

                    // Define los parámetros
                    adaptador.SelectCommand.Parameters.Add("@ID_PRODUCTO_RECETA", SqlDbType.Int, 4, "ID_PRODUCTO_RECETA");
                    adaptador.SelectCommand.Parameters.Add("@CANTIDAD", SqlDbType.Int, 4, "CANTIDAD");
                    adaptador.SelectCommand.Parameters.Add("@ID_RECETA", SqlDbType.Int, 4, "ID_RECETA");

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
                string nombreArchivo = "registro_cambios_tabla_recetas.txt";

                // Crear un registro de cambios
                string registroCambios = $"Usuario que lo modificó: {usuario}\nFecha y Hora: {DateTime.Now}\n\nCambios:\n";

                foreach (DataRow row in dataSource.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        registroCambios += $"Fila modificada (ID_RECETA: {row["ID_RECETA"]})\n";
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


        private void dtReceta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
