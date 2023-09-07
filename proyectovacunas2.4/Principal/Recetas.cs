using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using proyectovacunas2._4.Mostrar;
using proyectovacunas2._4.Reportes;

namespace proyectovacunas2._4
{
    public partial class Recetas : Form
    {
        CapaBD.ConexionBD _con = new CapaBD.ConexionBD();
        public Recetas()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            frmPrincipal g = new frmPrincipal();
            g.Show();
            Hide();
        }

        private void Recetas_Load(object sender, EventArgs e)
        {
            CargarNombresProductos();
            CargarCedulasPacientes();
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            string PacienteCedula = cbPacienteCedula.Text;
            int IDProducto = BuscarIdProductoPorNombre(cbIDProducto.Text);
            int cantidadEntera = (int)numUpDowCantidad.Value;

            Receta receta = new Receta(PacienteCedula, IDProducto, cantidadEntera);
            InsertarReceta(receta);
            MessageBox.Show("Receta agregada con exito");
            cbPacienteCedula.Text = "";
            cbIDProducto.Text = "";
            numUpDowCantidad.Value = 0;
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            new ReporteReceta().Show();
        }

        // Método para cargar los nombres de productos desde la tabla PRODUCTO
        private void CargarNombresProductos()
        {
            try
            {
                string connectionString = _con.cn.ConnectionString; // Reemplaza con tu cadena de conexión SQL
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT NOMBRE_PRODUCTO FROM PRODUCTO";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombreProducto = reader["NOMBRE_PRODUCTO"].ToString();
                            cbIDProducto.Items.Add(nombreProducto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los nombres de productos: " + ex.Message);
            }
        }

        // Método para buscar el ID_PRODUCTO por nombre de producto
        private int BuscarIdProductoPorNombre(string nombreProducto)
        {
            int idProducto = -1; // Valor por defecto si no se encuentra el producto

            try
            {
                string connectionString = _con.cn.ConnectionString; // Reemplaza con tu cadena de conexión SQL
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT ID_PRODUCTO FROM PRODUCTO WHERE NOMBRE_PRODUCTO = @NombreProducto";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NombreProducto", nombreProducto);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        idProducto = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el ID del producto: " + ex.Message);
            }

            return idProducto;
        }

        // Método para cargar las cédulas de pacientes desde la tabla PACIENTE
        private void CargarCedulasPacientes()
        {
            try
            {
                string connectionString = _con.cn.ConnectionString; // Reemplaza con tu cadena de conexión SQL
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT PACIENTE_CEDULA FROM PACIENTE";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string cedulaPaciente = reader["PACIENTE_CEDULA"].ToString();
                            // Agregar cedulaPaciente a un ComboBox u otra lista en tu formulario
                            // Ejemplo: comboBoxCedulasPacientes.Items.Add(cedulaPaciente)
                            cbPacienteCedula.Items.Add(cedulaPaciente);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cédulas de pacientes: " + ex.Message);
            }
        }

        private void InsertarReceta(Receta receta)
        {
            try
            {
                string connectionString = _con.cn.ConnectionString; // Reemplaza con tu cadena de conexión SQL
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO RECETA (PACIENTE_CEDULA, ID_PRODUCTO_RECETA, CANTIDAD) VALUES (@CedulaPaciente, @IdProducto, @Cantidad)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CedulaPaciente", receta.PACIENTE_CEDULA);
                    command.Parameters.AddWithValue("@IdProducto", receta.ID_PRODUCTO_RECETA);
                    command.Parameters.AddWithValue("@Cantidad", receta.CANTIDAD);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la receta: " + ex.Message, "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            new MostrarTablaReceta().Show();
        }
    }
}
