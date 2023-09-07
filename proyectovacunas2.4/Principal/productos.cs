using proyectovacunas2._4.Mostrar;
using proyectovacunas2._4.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Log_Negocio;

namespace proyectovacunas2._4
{
    public partial class frmproductos : Form
    {
        CapaBD.ConexionBD _con = new CapaBD.ConexionBD();
        public frmproductos()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            frmPrincipal f = new frmPrincipal();
            f.Show();
            Hide();
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            new ReporteProductos().Show();
        }
        private void InsertarProducto(Producto producto)
        {
            try
            {
                string connectionString = _con.cn.ConnectionString; // Reemplaza con tu cadena de conexión SQL
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO PRODUCTO (NOMBRE_PRODUCTO, FECHA_VECIMIENTO, EFECTOS, INFORMACION) VALUES (@NOMBRE_PRODUCTO, @FECHA_VECIMIENTO, @EFECTOS, @INFORMACION)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NOMBRE_PRODUCTO", producto.NOMBRE_PRODUCTO);
                    command.Parameters.AddWithValue("@FECHA_VECIMIENTO", producto.FECHA_VECIMIENTO);
                    command.Parameters.AddWithValue("@EFECTOS", producto.EFECTOS);
                    command.Parameters.AddWithValue("@INFORMACION", producto.INFORMACION);

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Se han insertado correctamente los datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la producto: " + ex.Message, "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            new MostrarTablaProducto().Show();
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            string nombreproducto = txtprodname.Text;
            DateTime fechaVencimiento = dtFechaVencimiento.Value;
            string efectos = txtefectos.Text;
            string informacion = txtinfo.Text;

            Producto producto = new Producto(nombreproducto, fechaVencimiento, efectos, informacion);

            InsertarProducto(producto);

            txtprodname.Text = "";
            dtFechaVencimiento.Value = DateTime.Now;
            txtefectos.Text = "";
            txtinfo.Text = "";
        }
    }
}
