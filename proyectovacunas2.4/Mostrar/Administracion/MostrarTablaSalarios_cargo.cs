using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CapaBD;
using Log_Negocio;
using static System.Windows.Forms.MonthCalendar;

namespace proyectovacunas2._4.Mostrar
{

    public partial class MostrarTablaSalarios_cargo : Form
    {
        private CapaBD.ConexionBD _con = new CapaBD.ConexionBD();
        public MostrarTablaSalarios_cargo()
        {
            InitializeComponent();
        }

        public void AgregarSalarioCargo(SalarioCargo salarioCargo)
        {
            try
            {
                using (_con.cmd = new System.Data.SqlClient.SqlCommand())
                {
                    _con.cmd.Connection = _con.cn;
                    _con.cmd.Connection.Open();

                    _con.cmd.CommandText =
                        "INSERT INTO SALARIOS_CARGOS (CARGO_ID, VALIDO_DESDE, SALARIO) " +
                        "VALUES (@CargoId, @ValidoDesde, @Salario)";
                    _con.cmd.Parameters.AddWithValue("@CargoId", salarioCargo.CARGO_ID);
                    _con.cmd.Parameters.AddWithValue("@ValidoDesde", salarioCargo.VALIDO_DESDE);
                    _con.cmd.Parameters.AddWithValue("@Salario", salarioCargo.SALARIO);

                    _con.cmd.ExecuteNonQuery();
                    _con.cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar salario y cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtSalario.Text = "";
            cbCargo.Text = "";
            dtRegistroSalario.Value = DateTime.Now;
        }

        public void BuscarSalarioCargoPorID(int idSalarioCargo)
        {
            // Verifica si el ID_SALARIOS_CARGOS es válido (mayor que cero)
            if (idSalarioCargo <= 0)
            {
                MessageBox.Show("Por favor, ingrese un ID_SALARIOS_CARGOS válido para buscar.");
                return; // Sale del método si el ID_SALARIOS_CARGOS no es válido
            }

            // Define la consulta SQL para buscar salarios por ID_SALARIOS_CARGOS en la tabla SALARIOS_CARGOS
            string consultaSQL = "SELECT ID_SALARIOS_CARGOS, CARGO_ID, VALIDO_DESDE, SALARIO FROM SALARIOS_CARGOS WHERE ID_SALARIOS_CARGOS = @IdSalarioCargo";

            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, _con.cn))
                {
                    // Agrega el parámetro de búsqueda
                    comando.Parameters.AddWithValue("@IdSalarioCargo", idSalarioCargo);

                    // Ejecuta la consulta y obtiene los resultados en un DataTable
                    DataTable resultado = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                    // Verifica si la consulta no devolvió filas (ID_SALARIOS_CARGOS no encontrado)
                    if (resultado.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron resultados para el ID_SALARIOS_CARGOS proporcionado.");
                        // Puedes realizar alguna acción adicional si no se encuentra el dato.
                    }
                    else
                    {
                        // Configura el DataGridView dtSalarioCargo para que no autogenere columnas automáticamente
                        dtSalarioCargo.AutoGenerateColumns = false;

                        // Asigna los datos al DataGridView en las columnas específicas (asegúrate de que los nombres coincidan)
                        dtSalarioCargo.Columns["ID_SALARIOS_CARGOS"].DataPropertyName = "ID_SALARIOS_CARGOS";
                        dtSalarioCargo.Columns["CARGO_ID"].DataPropertyName = "CARGO_ID";
                        dtSalarioCargo.Columns["VALIDO_DESDE"].DataPropertyName = "VALIDO_DESDE";
                        dtSalarioCargo.Columns["SALARIO"].DataPropertyName = "SALARIO";

                        // Muestra los resultados en el DataGridView dtSalarioCargo
                        dtSalarioCargo.DataSource = resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar salarios por ID_SALARIOS_CARGOS: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }

        public void CargarTodosLosSalariosCargos()
        {
            // Limpia la tabla antes de cargar todos los salarios cargos
            dtSalarioCargo.DataSource = null;
            dtSalarioCargo.Rows.Clear();

            // Define la consulta SQL para seleccionar todos los salarios cargos
            string consultaSQL = "SELECT ID_SALARIOS_CARGOS, CARGO_ID, VALIDO_DESDE, SALARIO FROM SALARIOS_CARGOS";

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
                    dtSalarioCargo.AutoGenerateColumns = false;

                    // Asigna los datos al DataGridView en las columnas específicas
                    dtSalarioCargo.Columns["ID_SALARIOS_CARGOS"].DataPropertyName = "ID_SALARIOS_CARGOS";
                    dtSalarioCargo.Columns["CARGO_ID"].DataPropertyName = "CARGO_ID";
                    dtSalarioCargo.Columns["VALIDO_DESDE"].DataPropertyName = "VALIDO_DESDE";
                    dtSalarioCargo.Columns["SALARIO"].DataPropertyName = "SALARIO";

                    // Muestra los resultados en el DataGridView "dtSalarioCargo"
                    dtSalarioCargo.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar todos los salarios cargos: " + ex.Message);
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
                string consultaSQL = "UPDATE SALARIOS_CARGOS SET " +
                    "SALARIO = @SALARIO " +
                    "WHERE ID_SALARIOS_CARGOS = @ID_SALARIOS_CARGOS";

                // Configura la conexión y el adaptador
                using (SqlConnection conexion = new SqlConnection(_con.cn.ConnectionString))
                {
                    adaptador.SelectCommand = new SqlCommand(consultaSQL, conexion);

                    // Define los parámetros
                    adaptador.SelectCommand.Parameters.Add("@SALARIO", SqlDbType.Decimal, 19, "SALARIO");
                    adaptador.SelectCommand.Parameters.Add("@ID_SALARIOS_CARGOS", SqlDbType.Int, 4, "ID_SALARIOS_CARGOS");

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
                string nombreArchivo = "registro_cambios_tabla_salario_cargo.txt";

                // Crear un registro de cambios
                string registroCambios = $"Usuario que lo modificó: {usuario}\nFecha y Hora: {DateTime.Now}\n\nCambios:\n";

                foreach (DataRow row in dataSource.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        registroCambios += $"Fila modificada (ID_SALARIOS_CARGOS: {row["ID_SALARIOS_CARGOS"]})\n";
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
        private void lblempleados_Click(object sender, EventArgs e)
        {

        }

        private void txtipodearea_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarTablaSalarios_cargo_Load(object sender, EventArgs e)
        {
            insertardatoscb(cbCargo, "CARGO");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar.Text, out int idSalarioCargo))
            {
                BuscarSalarioCargoPorID(idSalarioCargo);
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
            CargarTodosLosSalariosCargos();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            // Verifica si el DataGridView está enlazado a un origen de datos
            if (dtSalarioCargo.DataSource != null)
            {
                // Obtén el origen de datos actual
                DataTable dataSource = (DataTable)dtSalarioCargo.DataSource;

                // Borra todos los datos en el origen de datos
                dataSource.Rows.Clear();

                // Vuelve a asignar el origen de datos vacío para limpiar el DataGridView
                dtSalarioCargo.DataSource = null;
            }
            else
            {
                // Si el DataGridView no está enlazado a un origen de datos, simplemente borra las filas
                dtSalarioCargo.Rows.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén el origen de datos actual del DataGridView
            DataTable dataSource = (DataTable)dtSalarioCargo.DataSource;
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
                string nombreArchivo = "registro_cambios_tabla_salario_cargo.txt";
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
            if (string.IsNullOrEmpty(cbCargo.Text) || string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar el cargo.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método si algún campo está vacío
            }

            if (!int.TryParse(cbCargo.Text, out int IDCargo))
            {
                MessageBox.Show("El ID del cargo debe ser un número válido.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Sale del método si no se puede convertir a int
            }

            if (!decimal.TryParse(txtSalario.Text, out decimal Salario))
            {
                MessageBox.Show("El salario debe ser un valor decimal válido.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Sale del método si no se puede convertir a decimal
            }

            DateTime fechaRegistro = dtRegistroSalario.Value;

            SalarioCargo salariocargo = new SalarioCargo(IDCargo, fechaRegistro, Salario);

            try
            {
                AgregarSalarioCargo(salariocargo);
                MessageBox.Show("El cargo se ha agregado con éxito.");

                // Limpiar los campos después de agregar el cargo
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
