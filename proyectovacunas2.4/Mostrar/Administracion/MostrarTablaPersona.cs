using CapaBD;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace proyectovacunas2._4.Mostrar
{
    public partial class MostrarTablaPersona : Form
    {
        CapaBD.ConexionBD _con = new CapaBD.ConexionBD();

        public MostrarTablaPersona()
        {
            InitializeComponent();
        }

        private void BuscarPersona(string cedula)
        {
            if (string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("Por favor, ingrese un número de cédula para buscar.");
                return;
            }

            string consultaSQL = "SELECT CEDULA, NOMBRE_1, NOMBRE_2, APELLIDO_1, APELLIDO_2, EDAD, SEXO, DEPARTAMENTO FROM PERSONA WHERE CEDULA = @Cedula";

            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, _con.cn))
                {
                    comando.Parameters.AddWithValue("@Cedula", cedula);

                    DataTable resultado = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                    dtPersona.AutoGenerateColumns = false;

                    dtPersona.Columns["CEDULA"].DataPropertyName = "CEDULA";
                    dtPersona.Columns["NOMBRE_1"].DataPropertyName = "NOMBRE_1";
                    dtPersona.Columns["NOMBRE_2"].DataPropertyName = "NOMBRE_2";
                    dtPersona.Columns["APELLIDO_1"].DataPropertyName = "APELLIDO_1";
                    dtPersona.Columns["APELLIDO_2"].DataPropertyName = "APELLIDO_2";
                    dtPersona.Columns["EDAD"].DataPropertyName = "EDAD";
                    dtPersona.Columns["SEXO"].DataPropertyName = "SEXO";
                    dtPersona.Columns["DEPARTAMENTO"].DataPropertyName = "DEPARTAMENTO";

                    dtPersona.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar persona: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }

        private void CargarTodasLasPersonas()
        {
            dtPersona.DataSource = null;
            dtPersona.Rows.Clear();

            string consultaSQL = "SELECT CEDULA, NOMBRE_1, NOMBRE_2, APELLIDO_1, APELLIDO_2, EDAD, SEXO, DEPARTAMENTO FROM PERSONA";

            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, _con.cn))
                {
                    DataTable resultado = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                    dtPersona.AutoGenerateColumns = false;

                    dtPersona.Columns["CEDULA"].DataPropertyName = "CEDULA";
                    dtPersona.Columns["NOMBRE_1"].DataPropertyName = "NOMBRE_1";
                    dtPersona.Columns["NOMBRE_2"].DataPropertyName = "NOMBRE_2";
                    dtPersona.Columns["APELLIDO_1"].DataPropertyName = "APELLIDO_1";
                    dtPersona.Columns["APELLIDO_2"].DataPropertyName = "APELLIDO_2";
                    dtPersona.Columns["EDAD"].DataPropertyName = "EDAD";
                    dtPersona.Columns["SEXO"].DataPropertyName = "SEXO";
                    dtPersona.Columns["DEPARTAMENTO"].DataPropertyName = "DEPARTAMENTO";

                    dtPersona.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar todas las personas: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPersona(txtBuscar.Text);
            txtBuscar.Text = "";
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            CargarTodasLasPersonas();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (dtPersona.DataSource != null)
            {
                DataTable dataSource = (DataTable)dtPersona.DataSource;
                dataSource.Rows.Clear();
                dtPersona.DataSource = null;
            }
            else
            {
                dtPersona.Rows.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreArchivo = "registro_cambios_tabla_persona.txt";
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
                MessageBox.Show("Error al abrir el archivo de registro: " + ex.Message);
            }
        }
    }
}
