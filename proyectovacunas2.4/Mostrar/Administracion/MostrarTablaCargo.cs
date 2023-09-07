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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace proyectovacunas2._4.Mostrar
{
    public partial class MostrarTablaCargo : Form
    {
        private CapaBD.ConexionBD _con = new CapaBD.ConexionBD();

        public MostrarTablaCargo()
        {
            InitializeComponent();
        }

        // Método para insertar datos de un cargo en la base de datos
        public void AgregarCargo(Cargo cargo)
        {
            try
            {
                using (_con.cmd = new System.Data.SqlClient.SqlCommand())
                {
                    _con.cmd.Connection = _con.cn;
                    _con.cmd.Connection.Open();

                    _con.cmd.CommandText =
                        "INSERT INTO CARGO (NOMBRE_CARGO, ESPECIALIDAD, REGISTRO) " +
                        "VALUES (@NombreCargo, @Especialidad, @Registro)";
                    _con.cmd.Parameters.AddWithValue("@NombreCargo", cargo.NOMBRE_CARGO);
                    _con.cmd.Parameters.AddWithValue("@Especialidad", cargo.ESPECIALIDAD);
                    _con.cmd.Parameters.AddWithValue("@Registro", cargo.REGISTRO);

                    _con.cmd.ExecuteNonQuery();
                    _con.cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtnombrecargo.Text = "";
            txtespecialidad.Text = "";
            dtRegistroCargo.Value = DateTime.Now;
        }

        public void BuscarCargo(int idCargo)
        {
            // Verifica si el ID_CARGO es válido (mayor que cero)
            if (idCargo <= 0)
            {
                MessageBox.Show("Por favor, ingrese un ID_CARGO válido para buscar.");
                return; // Sale del método si el ID_CARGO no es válido
            }

            // Define la consulta SQL para buscar cargos por ID_CARGO
            string consultaSQL = "SELECT ID_CARGO, NOMBRE_CARGO, ESPECIALIDAD, REGISTRO FROM CARGO WHERE ID_CARGO = @IdCargo";

            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, _con.cn))
                {
                    // Agrega el parámetro de búsqueda
                    comando.Parameters.AddWithValue("@IdCargo", idCargo);

                    // Ejecuta la consulta y obtiene los resultados en un DataTable
                    DataTable resultado = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                    // Verifica si la consulta no devolvió filas (ID_CARGO no encontrado)
                    if (resultado.Rows.Count == 0)
                    {
                        MessageBox.Show("El ID_CARGO no existe o no es accesible.");
                    }
                    else
                    {
                        // Configura el DataGridView para que no autogenere columnas automáticamente
                        dtCargo.AutoGenerateColumns = false;

                        // Asigna los datos al DataGridView en las columnas específicas
                        dtCargo.Columns["ID_CARGO"].DataPropertyName = "ID_CARGO";
                        dtCargo.Columns["NOMBRE_CARGO"].DataPropertyName = "NOMBRE_CARGO";
                        dtCargo.Columns["ESPECIALIDAD"].DataPropertyName = "ESPECIALIDAD";
                        dtCargo.Columns["REGISTRO"].DataPropertyName = "REGISTRO";

                        // Muestra los resultados en el DataGridView "dtCargo"
                        dtCargo.DataSource = resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cargos: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }


        // Método para cargar todos los cargos
        public void CargarTodosLosCargos()
        {
            // Limpia la tabla antes de cargar todos los cargos
            dtCargo.DataSource = null;
            dtCargo.Rows.Clear();

            // Define la consulta SQL para seleccionar todos los cargos
            string consultaSQL = "SELECT ID_CARGO, NOMBRE_CARGO, ESPECIALIDAD, REGISTRO FROM CARGO";

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
                    dtCargo.AutoGenerateColumns = false;

                    // Asigna los datos al DataGridView en las columnas específicas
                    dtCargo.Columns["ID_CARGO"].DataPropertyName = "ID_CARGO";
                    dtCargo.Columns["NOMBRE_CARGO"].DataPropertyName = "NOMBRE_CARGO";
                    dtCargo.Columns["ESPECIALIDAD"].DataPropertyName = "ESPECIALIDAD";
                    dtCargo.Columns["REGISTRO"].DataPropertyName = "REGISTRO";

                    // Muestra los resultados en el DataGridView "dtCargo"
                    dtCargo.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar todos los cargos: " + ex.Message);
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
                string consultaSQL = "UPDATE CARGO SET " +
                    "NOMBRE_CARGO = @NOMBRE_CARGO, " +
                    "ESPECIALIDAD = @ESPECIALIDAD, " +
                    "REGISTRO = @REGISTRO " +
                    "WHERE ID_CARGO = @ID_CARGO";

                // Configura la conexión y el adaptador
                using (SqlConnection conexion = new SqlConnection(_con.cn.ConnectionString))
                {
                    adaptador.SelectCommand = new SqlCommand(consultaSQL, conexion);

                    // Define los parámetros
                    adaptador.SelectCommand.Parameters.Add("@NOMBRE_CARGO", SqlDbType.NVarChar, 20, "NOMBRE_CARGO");
                    adaptador.SelectCommand.Parameters.Add("@ESPECIALIDAD", SqlDbType.NVarChar, 20, "ESPECIALIDAD");
                    adaptador.SelectCommand.Parameters.Add("@REGISTRO", SqlDbType.DateTime, 8, "REGISTRO");
                    adaptador.SelectCommand.Parameters.Add("@ID_CARGO", SqlDbType.Int, 4, "ID_CARGO");

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
                string nombreArchivo = "registro_cambios_tabla_cargo.txt";

                // Crear un registro de cambios
                string registroCambios = $"Usuario que lo modificó: {usuario}\nFecha y Hora: {DateTime.Now}\n\nCambios:\n";

                foreach (DataRow row in dataSource.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        registroCambios += $"Fila modificada (ID_CARGO: {row["ID_CARGO"]})\n";
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
            if (int.TryParse(txtBuscar.Text, out int idCargo))
            {
                BuscarCargo(idCargo);
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
            CargarTodosLosCargos();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            // Verifica si el DataGridView está enlazado a un origen de datos
            if (dtCargo.DataSource != null)
            {
                // Obtén el origen de datos actual
                DataTable dataSource = (DataTable)dtCargo.DataSource;

                // Borra todos los datos en el origen de datos
                dataSource.Rows.Clear();

                // Vuelve a asignar el origen de datos vacío para limpiar el DataGridView
                dtCargo.DataSource = null;
            }
            else
            {
                // Si el DataGridView no está enlazado a un origen de datos, simplemente borra las filas
                dtCargo.Rows.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén el origen de datos actual del DataGridView
            DataTable dataSource = (DataTable)dtCargo.DataSource;
            string usuario = Usuarios.UsuarioActual;
            // Llama al método GuardarCambios para guardar los cambios en la base de datos
            GuardarCambiosEnArchivo(dataSource, usuario);
            GuardarCambiosEnBaseDeDatos(dataSource, usuario);
        }

        private void btnLog_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Verificar si el archivo existe antes de intentar abrirlo
                string nombreArchivo = "registro_cambios_tabla_cargo.txt";
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

        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreCargo = txtnombrecargo.Text;
                string especialidad = txtespecialidad.Text;
                DateTime fechaRegistro = dtRegistroCargo.Value;

                // Verificar si los TextBox están vacíos
                if (string.IsNullOrEmpty(nombreCargo) || string.IsNullOrEmpty(especialidad))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar el cargo.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Sale del método si algún campo está vacío
                }
                Cargo cargo = new Cargo(nombreCargo, especialidad, fechaRegistro);

                AgregarCargo(cargo);

                MessageBox.Show("El cargo se ha agregado con éxito.");

                // Limpiar los campos después de agregar el cargo
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarTablaCargo_Load(object sender, EventArgs e)
        {

        }
    }
}
