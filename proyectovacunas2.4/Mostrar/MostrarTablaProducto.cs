using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Log_Negocio;
using System.IO;

namespace proyectovacunas2._4.Mostrar
{
    public partial class MostrarTablaProducto : Form
    {
        CapaBD.ConexionBD _con = new CapaBD.ConexionBD();

        public MostrarTablaProducto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Puedes llamar a la función BuscarRecetas y ajustar los nombres según corresponda
            // Recuerda que la tabla de SQL es PRODUCTO, no RECETA, por lo que debes ajustar la consulta SQL
            BuscarProductos(txtBuscar.Text);
            txtBuscar.Text = "";
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            // Puedes llamar a la función CargarTodasLasRecetas y ajustar los nombres según corresponda
            // Recuerda que la tabla de SQL es PRODUCTO, no RECETA, por lo que debes ajustar la consulta SQL
            CargarTodosLosProductos();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            // Puedes adaptar el método para limpiar el DataGridView según tus necesidades
            LimpiarDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Puedes adaptar el método para guardar cambios en la base de datos y en el archivo
            // Recuerda que la tabla de SQL es PRODUCTO, no RECETA, por lo que debes ajustar la función GuardarCambiosEnBaseDeDatos
            // y GuardarCambiosEnArchivo para trabajar con productos en lugar de recetas
            GuardarCambiosEnArchivo(dtProducto.DataSource as DataTable, Usuarios.UsuarioActual);
            GuardarCambiosEnBaseDeDatos(dtProducto.DataSource as DataTable, Usuarios.UsuarioActual);
            
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            // Puedes adaptar el método para abrir el archivo de registro según tus necesidades
            AbrirArchivoDeRegistro();
        }

        // Puedes adaptar los siguientes métodos según tus necesidades

        public void BuscarProductos(string nombreProducto)
        {
            // Define la consulta SQL para buscar productos por nombre
            string consultaSQL = "SELECT ID_PRODUCTO, NOMBRE_PRODUCTO, FECHA_VECIMIENTO, EFECTOS, INFORMACION FROM PRODUCTO WHERE NOMBRE_PRODUCTO LIKE @NombreProducto";

            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, _con.cn))
                {
                    // Agrega el parámetro de búsqueda
                    comando.Parameters.AddWithValue("@NombreProducto", "%" + nombreProducto + "%");

                    // Ejecuta la consulta y obtiene los resultados en un DataTable
                    DataTable resultado = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                    // Configura el DataGridView para que no autogenera columnas automáticamente
                    dtProducto.AutoGenerateColumns = false;

                    // Asigna los datos al DataGridView en las columnas específicas
                    dtProducto.Columns["ID_PRODUCTO"].DataPropertyName = "ID_PRODUCTO";
                    dtProducto.Columns["NOMBRE_PRODUCTO"].DataPropertyName = "NOMBRE_PRODUCTO";
                    dtProducto.Columns["FECHA_VENCIMIENTO"].DataPropertyName = "FECHA_VECIMIENTO";
                    dtProducto.Columns["EFECTOS"].DataPropertyName = "EFECTOS";
                    dtProducto.Columns["INFORMACION"].DataPropertyName = "INFORMACION";

                    // Muestra los resultados en el DataGridView "dtProducto"
                    dtProducto.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar productos: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }

        public void CargarTodosLosProductos()
        {
            // Define la consulta SQL para seleccionar todos los productos
            string consultaSQL = "SELECT ID_PRODUCTO, NOMBRE_PRODUCTO, FECHA_VECIMIENTO, EFECTOS, INFORMACION FROM PRODUCTO";

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
                    dtProducto.AutoGenerateColumns = false;

                    // Asigna los datos al DataGridView en las columnas específicas
                    dtProducto.Columns["ID_PRODUCTO"].DataPropertyName = "ID_PRODUCTO";
                    dtProducto.Columns["NOMBRE_PRODUCTO"].DataPropertyName = "NOMBRE_PRODUCTO";
                    dtProducto.Columns["FECHA_VENCIMIENTO"].DataPropertyName = "FECHA_VECIMIENTO";
                    dtProducto.Columns["EFECTOS"].DataPropertyName = "EFECTOS";
                    dtProducto.Columns["INFORMACION"].DataPropertyName = "INFORMACION";

                    // Muestra los resultados en el DataGridView "dtProducto"
                    dtProducto.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar todos los productos: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }

        public void LimpiarDataGridView()
        {
            dtProducto.DataSource = null;
            dtProducto.Rows.Clear();
        }

        public void AbrirArchivoDeRegistro()
        {
            try
            {
                // Verificar si el archivo existe antes de intentar abrirlo
                string nombreArchivo = "registro_cambios_tabla_productos.txt";
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
                string consultaSQL = "UPDATE PRODUCTO SET " +
                    "NOMBRE_PRODUCTO = @NOMBRE_PRODUCTO, " +
                    "FECHA_VECIMIENTO = @FECHA_VECIMIENTO, " +
                    "EFECTOS = @EFECTOS, " +
                    "INFORMACION = @INFORMACION " +
                    "WHERE ID_PRODUCTO = @ID_PRODUCTO";

                // Configura la conexión y el adaptador
                using (SqlConnection conexion = new SqlConnection(_con.cn.ConnectionString))
                {
                    adaptador.SelectCommand = new SqlCommand(consultaSQL, conexion);

                    // Define los parámetros
                    adaptador.SelectCommand.Parameters.Add("@NOMBRE_PRODUCTO", SqlDbType.NVarChar, 50, "NOMBRE_PRODUCTO");
                    adaptador.SelectCommand.Parameters.Add("@FECHA_VECIMIENTO", SqlDbType.DateTime, 8, "FECHA_VECIMIENTO");
                    adaptador.SelectCommand.Parameters.Add("@EFECTOS", SqlDbType.NVarChar, 50, "EFECTOS");
                    adaptador.SelectCommand.Parameters.Add("@INFORMACION", SqlDbType.NVarChar, 50, "INFORMACION");
                    adaptador.SelectCommand.Parameters.Add("@ID_PRODUCTO", SqlDbType.Int, 4, "ID_PRODUCTO");

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
                string nombreArchivo = "registro_cambios_tabla_productos.txt";

                // Crear un registro de cambios
                string registroCambios = $"Usuario que lo modificó: {usuario}\nFecha y Hora: {DateTime.Now}\n\nCambios:\n";

                foreach (DataRow row in dataSource.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        registroCambios += $"Fila modificada (ID_PRODUCTO: {row["ID_PRODUCTO"]})\n";
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